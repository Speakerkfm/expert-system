﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    [Serializable]
    class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }

        private List<Value> values;
        public List<Value> Values
        {
            get { return values; }
            set { values = value; }
        }

        public List<Variable> UsedVariables { get; set; }

        public Domain()
        {
            this.values = new List<Value>();
            this.UsedVariables = new List<Variable>();
        }

        public Domain(int id, string name, string type, int number)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Number = number;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
