using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;
using ExpertSystem.model;

namespace ExpertSystem.src.service
{
    class VariableService
    {
        private DataContainer dataContainer;

        private FactService factService;

        public VariableService(DataContainer dataContainer, FactService factService)
        {
            this.dataContainer = dataContainer;
            this.factService = factService;
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
            Variable deletedVariable = Variables[index];

            foreach (Fact fact in deletedVariable.UsedFacts)
            {
                factService.DeleteFact(fact);
            }
            Variables.RemoveAt(index);

            for (int i = index; i < Variables.Count; i++)
            {
                Variables[i].Number = index + 1;
            }
        }

        public void DeleteVariable(Variable variable)
        {
            int index = Variables.IndexOf(variable);

            if (index != -1)
            {
                DeleteVariableByIdx(index);
            }
        }
    }
}
