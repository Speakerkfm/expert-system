﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.model;

namespace ExpertSystem.model
{
    class Variable
    {
        public const string Concluded = "Выводимая";
        public const string Requested = "Запрашиваемая";
        public const string ConcludedRequested = "Выводимо-Запрашиваемая";
        
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

        public Variable()
        {

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
