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

        public List<Domain> GetDomains()
        {
            return dataContainer.ExpertSystem.Domains;
        }
    }
}