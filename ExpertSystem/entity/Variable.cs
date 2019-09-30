using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    class Variable
    {
        private int id;
        private string name;
        private int number;
        private string type;
        private int domainId;

        private Domain domain;

        public int DomainId => domainId;
        public Domain Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        public Variable(int id, string name, int number, string type, int domainId)
        {
            this.id = id;
            this.name = name;
            this.number = number;
            this.type = type;
            this.domainId = domainId;
        }
    }
}
