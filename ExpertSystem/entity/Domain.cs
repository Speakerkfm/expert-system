using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    class Domain
    {
        private int id;
        private string name;
        private string type;
        private int number;
        private List<Value> values;

        public int Id => id;
        public List<Value> Values
        {
            get { return values; }
            set { values = value; }
        } 

        public Domain(int id, string name, string type, int number)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.number = number;
        }
    }
}
