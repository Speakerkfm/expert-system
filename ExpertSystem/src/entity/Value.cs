using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    class Value
    {
        private int id;
        private int number;
        private string value;

        public Value(int id, int number, string value)
        {
            this.id = id;
            this.number = number;
            this.value = value;
        }
    }
}
