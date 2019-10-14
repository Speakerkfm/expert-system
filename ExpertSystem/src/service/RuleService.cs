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

        public List<Rule> Rules
        {
            get { return dataContainer.ExpertSystem?.Rules; }
        }

        public void AddRule(Rule rule)
        {
            this.dataContainer.ExpertSystem.Rules.Add(rule);
        }

        public void DeleteRuleByIdx(int index)
        {
            Rule deletedRule = Rules[index];
            Rules?.Remove(deletedRule);
        }

        public void DeleteRule(Rule rule)
        {
            int index = Rules.IndexOf(rule);

            if (index != -1)
            {
                DeleteRuleByIdx(Rules.IndexOf(rule));
            }
        }
    }
}
