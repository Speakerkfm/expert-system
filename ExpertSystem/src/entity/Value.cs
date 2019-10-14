using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    [Serializable]
    class Value
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Val { get; set; }

        public Value(int number, string value)
        {
            this.Number = number;
            this.Val = value;
        }

        public override string ToString()
        {
            return this.Val;
        }
    }
}
