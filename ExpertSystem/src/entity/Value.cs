using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;

namespace ExpertSystem.model
{
    [Serializable]
    class Value
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Val { get; set; }

        public List<Fact> UsedFacts { get; set; }

        public Value(int number, string value)
        {
            this.Number = number;
            this.Val = value;
            this.UsedFacts = new List<Fact>();
        }

        public override string ToString()
        {
            return this.Val;
        }
    }
}
