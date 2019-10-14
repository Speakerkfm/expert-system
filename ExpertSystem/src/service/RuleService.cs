using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.model;

namespace ExpertSystem.src.service
{
    class RuleService
    {
        private DataContainer dataContainer;

        public RuleService(DataContainer dataContainer)
        {
            this.dataContainer = dataContainer;
        }

        public List<Rule> GetRules()
        {
            return dataContainer.ExpertSystem?.Rules;
        }

        public void AddRule(Rule rule)
        {
            this.dataContainer.ExpertSystem.Rules.Add(rule);
        }
    }
}
