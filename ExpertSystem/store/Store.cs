using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ExpertSystem.model;
using MySql.Data.MySqlClient;

namespace ExpertSystem.store
{
    class Store
    {
        private MySqlConnection _conn;
        public MySqlConnection _Connection => _conn;

        public Store(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                                + ";port=" + port + ";User Id=" + username + ";password=" + password;
            
            _conn = new MySqlConnection(connString);
            _conn.Open();
        }

        public void CloseConnection()
        {
            this?._conn.Close();
        }

        private int GetLastInsertId()
        {
            string sql = "SELECT LAST_INSERT_ID();";
            MySqlCommand command = new MySqlCommand(sql, _conn);

            return int.Parse(command.ExecuteScalar().ToString());
        }

        public CurrentExpertSystem CreateExpertSystem(string name)
        {
            string sql = "INSERT INTO expert_system (name) VALUES (@name);";
            MySqlCommand command = new MySqlCommand(sql, _conn);
            command.Parameters.AddWithValue("@name", name);

            command.ExecuteNonQuery();

            int id = GetLastInsertId();

            return new CurrentExpertSystem(id, name);
        }

        public List<Value> GetValuesByDomainId(int domainId)
        {
            List<Value> values = new List<Value>();

            string sql = "SELECT * FROM domain_values WHERE domain_id=@domainId;";
            MySqlCommand command = new MySqlCommand(sql, _conn);
            command.Parameters.AddWithValue("@domainId", domainId);

            MySqlDataReader rowReader = command.ExecuteReader();

            while (rowReader.Read() && rowReader.HasRows)
            {
                int id = int.Parse(rowReader[0].ToString());
                int number = int.Parse(rowReader[1].ToString());
                string value = rowReader[2].ToString();

                Value val = new Value(id, number, value);

                values.Add(val);
            }
            rowReader.Close(); 

            return values;
        }

        public Domain GetDomainById(int domainId)
        {
            string sql = "SELECT * FROM domains WHERE id=@domainId;";
            MySqlCommand command = new MySqlCommand(sql, _conn);
            command.Parameters.AddWithValue("@domainId", domainId);

            MySqlDataReader rowReader = command.ExecuteReader();

            rowReader.Read();

            if (!rowReader.HasRows)
            {
                return null;
            }

            int id = int.Parse(rowReader[0].ToString());
            string name = rowReader[1].ToString();
            string type = rowReader[2].ToString();
            int number = int.Parse(rowReader[3].ToString());

            rowReader.Close();

            Domain domain = new Domain(id, name, type, number);
            domain.Values = GetValuesByDomainId(id);

            return domain;
        }

        public List<Domain> GetDomains(int expertSystemId)
        {
            List<Domain> domains = new List<Domain>();

            string sql = "SELECT * FROM domains WHERE expert_system_id=@expertSystemId;";
            MySqlCommand command = new MySqlCommand(sql, _conn);
            command.Parameters.AddWithValue("@expertSystemId", expertSystemId);

            MySqlDataReader rowReader = command.ExecuteReader();

            while (rowReader.Read() && rowReader.HasRows)
            {
                int id = int.Parse(rowReader[0].ToString());
                string name = rowReader[1].ToString();
                string type = rowReader[2].ToString();
                int number = int.Parse(rowReader[4].ToString());

                Domain domain = new Domain(id, name, type, number);

                domains.Add(domain);
            }

            rowReader.Close();

            foreach (Domain domain in domains)
            {
                domain.Values = GetValuesByDomainId(domain.Id);
            }

            return domains;
        }

        public Variable GetVariableById(int variableId)
        {
            string sql = "SELECT * FROM variables WHERE id=@variableId;";
            MySqlCommand command = new MySqlCommand(sql, _conn);
            command.Parameters.AddWithValue("@variableId", variableId);

            MySqlDataReader rowReader = command.ExecuteReader();

            rowReader.Read();

            if (!rowReader.HasRows)
            {
                return null;
            }

            int id = int.Parse(rowReader[0].ToString());
            int number = int.Parse(rowReader[1].ToString());
            string name = rowReader[2].ToString();
            string type = rowReader[3].ToString();
            int domainId = int.Parse(rowReader[4].ToString());

            rowReader.Close();

            Variable variable = new Variable(id, name, number, type, domainId);
            variable.Domain = GetDomainById(domainId);

            return variable;
        }

        public List<Variable> GetVariables(int expertSystemId)
        {
            List<Variable> variables = new List<Variable>();

            string sql = "SELECT * FROM variables WHERE expert_system_id=@expertSystemId;";
            MySqlCommand command = new MySqlCommand(sql, _conn);
            command.Parameters.AddWithValue("@expertSystemId", expertSystemId);

            MySqlDataReader rowReader = command.ExecuteReader();

            while (rowReader.Read() && rowReader.HasRows)
            {
                int id = int.Parse(rowReader[0].ToString());
                int number = int.Parse(rowReader[1].ToString());
                string name = rowReader[2].ToString();
                string type = rowReader[3].ToString();
                int domainId = int.Parse(rowReader[4].ToString());

                Variable variable = new Variable(id, name, number, type, domainId);

                variables.Add(variable);
            }

            rowReader.Close();

            foreach (Variable variable in variables)
            {
                variable.Domain = GetDomainById(variable.DomainId);
            }

            return variables;
        }
    }
}
