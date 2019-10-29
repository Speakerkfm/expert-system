using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;
using ExpertSystem.model;

namespace ExpertSystem.src.entity
{
    [Serializable]
    class WorkingMemoryItem
    {
        public MemoryItemType Type { get; }
        public Fact Fact { get; }
        public Rule Rule { get; }

        public WorkingMemoryItem(Fact fact)
        {
            this.Type = MemoryItemType.Fact;
            this.Fact = fact;
        }

        public WorkingMemoryItem(Rule rule)
        {
            this.Type = MemoryItemType.Rule;
            this.Rule = rule;
        }
    }
}
