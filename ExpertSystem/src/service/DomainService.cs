using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.model;

namespace ExpertSystem.src.service
{
    class DomainService
    {
        private DataContainer dataContainer;

        public DomainService(DataContainer dataContainer)
        {
            this.dataContainer = dataContainer;
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
            Domains.RemoveAt(index);

            for (int i = index; i < Domains.Count; i++)
            {
                Domains[i].Number = index + 1;
            }
        }

        public Value GetOrCreateDomainValue(List<Value> values, string val)
        {
            foreach (Value value in values)
            {
                if (value.Val == val)
                {
                    return value;
                }
            }

            return new Value(values.Count + 1, val);
        }
    }
}