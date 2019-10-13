using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }

        private List<Value> values;
        public List<Value> Values
        {
            get { return values; }
            set { values = value; }
        }

        public Domain()
        {
            this.values = new List<Value>();
        }

        public Domain(int id, string name, string type, int number)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Number = number;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
