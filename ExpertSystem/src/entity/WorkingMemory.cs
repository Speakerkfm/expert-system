using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;

namespace ExpertSystem.src.entity
{
    class WorkingMemory
    {
        public List<Fact> KnownFacts { get; set; }

        public WorkingMemory()
        {
            KnownFacts = new List<Fact>();
        }
    }
}
