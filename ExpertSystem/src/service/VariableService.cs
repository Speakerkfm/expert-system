using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.model;

namespace ExpertSystem.src.service
{
    class VariableService
    {
        private DataContainer dataContainer;

        public VariableService(DataContainer dataContainer)
        {
            this.dataContainer = dataContainer;
        }

        public List<Variable> GetVariables()
        {
            return dataContainer.ExpertSystem.Variables;
        }
    }
}
