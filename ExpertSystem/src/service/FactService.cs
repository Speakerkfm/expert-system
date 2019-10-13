using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;
using ExpertSystem.model;

namespace ExpertSystem.src.service
{
    class FactService
    {
        private DataContainer dataContainer;

        public FactService(DataContainer dataContainer)
        {
            this.dataContainer = dataContainer;
        }

        public List<Fact> GetFacts()
        {
            return dataContainer.ExpertSystem?.Facts;
        }

        public Fact GetOrCreateFactByVarVal(Variable variable, Value value)
        {
            foreach (Fact fact in GetFacts())
            {
                if (fact.Variable == variable && fact.Value == value)
                {
                    return fact;
                }
            }

            return new Fact(variable, value);
        }
    }
}
