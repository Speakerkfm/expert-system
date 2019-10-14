using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;
using ExpertSystem.model;

namespace ExpertSystem.src.service
{
    class DomainService
    {
        private DataContainer dataContainer;

        private VariableService variableService;
        private FactService factService;

        public DomainService(DataContainer dataContainer, VariableService variableService, FactService factService)
        {
            this.dataContainer = dataContainer;
            this.variableService = variableService;
            this.factService = factService;
        }

        public List<Domain> Domains
        {
            get { return dataContainer.ExpertSystem?.Domains; }
        }

        public void AddDomain(Domain domain)
        {
            domain.Number = Domains.Count + 1;
            Domains.Add(domain);
        }

        public void DeleteDomainByIdx(int index)
        {
            Domain deletedDomain = Domains[index];

            foreach (Variable variable in deletedDomain.UsedVariables)
            {
                variableService.DeleteVariable(variable);
            }
            Domains.Remove(deletedDomain);

            for (int i = index; i < Domains.Count; i++)
            {
                Domains[i].Number = index + 1;
            }
        }

        public Value GetOrCreateDomainValue(List<Value> values, string val)
        {
            Value v = GetValue(values, val);

            if (v != null)
            {
                return v;
            }

            return new Value(values.Count + 1, val);
        }

        public Value GetValue(List<Value> values, string val)
        {
            foreach (Value value in values)
            {
                if (value.Val == val)
                {
                    return value;
                }
            }

            return null;
        }

        public void DeleteValue(Value value)
        {
            foreach (Fact fact in value.UsedFacts)
            {
                factService.DeleteFact(fact);
            }
        }
    }
}