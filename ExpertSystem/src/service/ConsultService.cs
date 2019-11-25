using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.entity;
using ExpertSystem.model;
using ExpertSystem.src.entity;
using ExpertSystem.src.forms;

namespace ExpertSystem.src.service
{
    class ConsultService
    {
        private DataContainer dataContainer;
        private WorkingMemory memory;
        private List<Rule> rules;

        public ConsultService(DataContainer dataContainer)
        {
            this.dataContainer = dataContainer;
        }

        public Value BeginConsult(CurrentExpertSystem expertSystem)
        {
            try
            {
                dataContainer.ExpertSystem.Memory = new WorkingMemory();
                this.memory = dataContainer.ExpertSystem.Memory;
                this.rules = this.dataContainer.ExpertSystem.Rules;

                Value result = KnowValue(expertSystem.Goal);

                return result;
            } catch (InvalidDataException e)
            {
                return null;
            }
        }
    

        public Value KnowValue(Variable variable)
        {
            Value knownValue = memory.GetValueFromMemory(variable);

            if (knownValue == null)
            {
                switch (variable.Type)
                {
                    case Variable.Requested:
                        knownValue = RequestValue(variable);
                        memory.KnownItems.Add(new WorkingMemoryItem(new Fact(variable, knownValue)));
                        break;
                    case Variable.Concluded:
                        knownValue = ConsultUser(variable);
                        break;
                    case Variable.ConcludedRequested:
                        knownValue = ConsultUser(variable);
                        if (knownValue == null)
                        {
                            knownValue = RequestValue(variable);
                            memory.KnownItems.Add(new WorkingMemoryItem(new Fact(variable, knownValue)));
                        }
                        break;
                }
            }

            return knownValue;
        }

        public Value ConsultUser(Variable currentGoal)
        {
            for (int i = 0; i < rules.Count; i++)
            {
                if (rules[i].ProvesTheGoal(currentGoal))
                {
                    bool isTrue = true;

                    for (int j = 0; j < rules[i].Conditions.Count; j++)
                    {
                        Fact condition = rules[i].Conditions[j];
                        Value knownValue = KnowValue(condition.Variable);
                        
                        if (condition.Value != knownValue)
                        {
                            isTrue = false;
                            break;
                        }
                    }

                    for (int j = 0; isTrue && j < rules[i].Conclusions.Count; j++)
                    {
                        //memory.KnownItems.Add(new WorkingMemoryItem(rules[i]));
                        memory.KnownItems.Add(new WorkingMemoryItem(rules[i].Conclusions[j], rules[i]));
                    }
                }
            }

            return memory.GetValueFromMemory(currentGoal);
        }

        public Value RequestValue(Variable variable)
        {
            Value resultValue = null;
            
            ConsultForm consultator = new ConsultForm(variable);
            if (consultator.ShowDialog() == DialogResult.OK)
            {
                resultValue = consultator.ResultValue;
            }
            else
            {
                throw new InvalidDataException();
            }

            consultator.Dispose();

            return resultValue;
        }
    }
}
