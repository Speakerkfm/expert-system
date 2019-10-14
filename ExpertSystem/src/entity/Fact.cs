using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.model;

namespace ExpertSystem.entity
{
    [Serializable]
    class Fact
    {
        public int Id { get; set; }
        public Variable Variable { get; set; }
        public Value Value { get; set; }

        public List<Rule> UsedRules { get; set; }

        public Fact()
        {
            this.UsedRules = new List<Rule>();
        }

        public Fact(Variable variable, Value value)
        {
            this.Variable = variable;
            this.Value = value;
            this.UsedRules = new List<Rule>();
        }
    }
}
