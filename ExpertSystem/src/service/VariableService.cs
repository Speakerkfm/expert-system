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

        public List<Variable> Variables
        {
            get
            {
                return dataContainer?.ExpertSystem?.Variables;
            }
        }

        public void AddVariable(Variable variable)
        {
            variable.Number = Variables.Count + 1;
            Variables.Add(variable);
        }

        public void DeleteVariableByIdx(int index)
        {
            Variables.RemoveAt(index);

            for (int i = index; i < Variables.Count; i++)
            {
                Variables[i].Number = index + 1;
            }
        }
    }
}
