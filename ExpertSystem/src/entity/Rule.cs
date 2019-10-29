using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;

namespace ExpertSystem.model
{
    [Serializable]
    class Rule
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string ExplainText { get; set; }
        public List<Fact> Conditions { get; set; }
        public List<Fact> Conclusions { get; set; }

        public Rule()
        {
            this.Conditions = new List<Fact>();
            this.Conclusions = new List<Fact>();
        }

        public override string ToString()
        {
            string ruleString = "IF (";

            for(int i = 0; i < Conditions.Count; i++)
            {
                ruleString += Conditions[i].Variable.Name + " == " + Conditions[i].Value.Val;
                if (i != Conditions.Count - 1)
                {
                    ruleString += " AND ";
                }
            }

            ruleString += ") THEN (";

            for (int i = 0; i < Conclusions.Count; i++)
            {
                ruleString += Conclusions[i].Variable.Name + " = " + Conclusions[i].Value.Val;
                if (i != Conclusions.Count - 1)
                {
                    ruleString += ", ";
                }
            }

            ruleString += ")";

            return ruleString;
        }

        public bool ProvesTheGoal(Variable goal)
        {
            foreach (Fact conclusion in Conclusions)
            {
                if (conclusion.Variable == goal)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
