using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    class Value
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Val { get; set; }

        public Value(int id, int number, string value)
        {
            this.Id = id;
            this.Number = number;
            this.Val = value;
        }
    }
}
