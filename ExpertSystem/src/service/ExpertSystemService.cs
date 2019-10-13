using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;
using ExpertSystem.model;

namespace ExpertSystem.service
{
    class ExpertSystemService
    {
        private DataContainer dataContainer;

        public ExpertSystemService(DataContainer dataContainer)
        {
            this.dataContainer = dataContainer;
        }

        public List<CurrentExpertSystem> GetExpertSystems()
        {
            return dataContainer.Store.GetExpertSystem();
        }

        public void CreateExpertSystem(string name)
        {
            dataContainer.ExpertSystem = dataContainer.Store.CreateExpertSystem(name);
        }

        public void SelectExpertSystem(CurrentExpertSystem expertSystem)
        {
            LoadExpertSystem(expertSystem);
            dataContainer.ExpertSystem = expertSystem;
        }

        private void LoadExpertSystem(CurrentExpertSystem expertSystem)
        {
            expertSystem.Variables = dataContainer.Store.GetVariables(expertSystem.Id);
            expertSystem.Domains = dataContainer.Store.GetDomains(expertSystem.Id);
            
            Fact fact1 = new Fact();
            fact1.Variable = expertSystem.Variables[0];
            fact1.Value = fact1.Variable.Domain.Values[0];

            Fact fact2 = new Fact();
            fact2.Variable = expertSystem.Variables[1];
            fact2.Value = fact2.Variable.Domain.Values[0];

            Fact fact3 = new Fact();
            fact3.Variable = expertSystem.Variables[0];
            fact3.Value = fact3.Variable.Domain.Values[1];

            expertSystem.Facts.Add(fact1);
            expertSystem.Facts.Add(fact2);
            expertSystem.Facts.Add(fact3);

            Rule rule1 = new Rule();
            rule1.Name = "Rule1";
            rule1.Conditions.Add(fact1);
            rule1.Conditions.Add(fact2);
            rule1.Conclusions.Add(fact3);

            Rule rule2 = new Rule();
            rule2.Name = "Rule2";
            rule2.Conditions.Add(fact1);
            rule2.Conclusions.Add(fact2);
            rule2.Conclusions.Add(fact3);

            expertSystem.Rules.Add(rule1);
            expertSystem.Rules.Add(rule2);
        }
    }
}
