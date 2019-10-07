using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
