﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    class CurrentExpertSystem
    {
        private int id;
        private string name;

        public int Id => id;
        public string Name => name;

        public List<Variable> Variables { get; set; }
        public List<Domain> Domains { get; set; }

        public CurrentExpertSystem(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}