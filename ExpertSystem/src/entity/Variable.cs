﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    class Variable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public int DomainId { get; set; }

        private Domain domain;
        public Domain Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        public Variable(int id, string name, int number, string type, int domainId)
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.Type = type;
            this.DomainId = domainId;
        }
    }
}