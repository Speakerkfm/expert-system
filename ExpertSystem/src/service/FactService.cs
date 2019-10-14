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

        private RuleService ruleService;

        public FactService(DataContainer dataContainer, RuleService ruleService)
        {
            this.dataContainer = dataContainer;
            this.ruleService = ruleService;
        }

        public List<Fact> Facts
        {
            get { return dataContainer.ExpertSystem?.Facts; }
        }

        public Fact GetOrCreateFactByVarVal(Variable variable, Value value)
        {
            foreach (Fact fact in Facts)
            {
                if (fact.Variable == variable && fact.Value == value)
                {
                    return fact;
                }
            }

            return new Fact(variable, value);
        }

        public void AddFact(Fact fact)
        {
            this.dataContainer.ExpertSystem.Facts?.Add(fact);
        }

        public void DeleteFactByIdx(int index)
        {
            Fact deletedFact = Facts[index];

            foreach (Rule rule in deletedFact.UsedRules)
            {
                ruleService.DeleteRule(rule);
            }

            Facts?.Remove(deletedFact);
        }

        public void DeleteFact(Fact fact)
        {
            int index = Facts.IndexOf(fact);

            if (index != -1)
            {
                DeleteFactByIdx(Facts.IndexOf(fact));
            }
        }
    }
}
