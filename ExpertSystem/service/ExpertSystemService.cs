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

        public void CreateExpertSystem(string name)
        {
            dataContainer.ExpertSystem = dataContainer.Store.CreateExpertSystem(name);
        }
    }
}
