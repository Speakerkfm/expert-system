using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;
using ExpertSystem.model;
using ExpertSystem.src.entity;

namespace ExpertSystem.src.entity
{
    enum MemoryItemType
    {
        Rule,
        Fact
    }

    [Serializable]
    class WorkingMemory
    {
        public List<WorkingMemoryItem> KnownItems { get; set; }

        public WorkingMemory()
        {
            KnownItems = new List<WorkingMemoryItem>();
        }

        public Value GetValueFromMemory(Variable variable)
        {
            foreach (WorkingMemoryItem item in this.KnownItems)
            {
                if (item.Type == MemoryItemType.Fact && item.Fact.Variable == variable)
                {
                    return item.Fact.Value;
                }
            }

            return null;
        }
    }
}
