using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.entity;
using ExpertSystem.store;
using ExpertSystem.model;
using ExpertSystem.service;
using ExpertSystem.src.service;

namespace ExpertSystem
{
    class DataContainer
    {
        private Store st;
        private model.CurrentExpertSystem expertSystem;

        public Store Store => st;
        public model.CurrentExpertSystem ExpertSystem
        {
            get { return expertSystem; }
            set { expertSystem = value; }
        }

        public DataContainer(Store st, model.CurrentExpertSystem expertSystem)
        {
            this.st = st;
            this.expertSystem = expertSystem;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //mysql
            string host = "127.0.0.1";
            int port = 3306;
            string database = "expert-system";
            string username = "root";
            string password = "root";
            Store st = new Store(host, port, database, username, password);

            DataContainer dataContainer = new DataContainer(st, null);

            //services
            ExpertSystemService expertSystemService = new ExpertSystemService(dataContainer);
            RuleService ruleService = new RuleService(dataContainer);
            FactService factService = new FactService(dataContainer, ruleService);
            VariableService variableService = new VariableService(dataContainer, factService);
            DomainService domainService = new DomainService(dataContainer, variableService, factService);

            dataContainer.ExpertSystem = new CurrentExpertSystem(0, "default");

            ConsultService consultService = new ConsultService(dataContainer);

            //forms
            MainForm mainForm = new MainForm(
                dataContainer.ExpertSystem, 
                expertSystemService, 
                variableService, 
                domainService,
                ruleService,
                factService,
                consultService);

            Application.Run(mainForm);

            st.CloseConnection();
        }
    }
}
