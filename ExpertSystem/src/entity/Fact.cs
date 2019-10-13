using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.model;

namespace ExpertSystem.entity
{
    class Fact
    {
        public int Id { get; set; }
        public Variable Variable { get; set; }
        public Value Value { get; set; }

        public Fact()
        {

        }
    }
}
