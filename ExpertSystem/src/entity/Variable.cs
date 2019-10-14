using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;
using ExpertSystem.model;

namespace ExpertSystem.model
{
    [Serializable]
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
        
        public Domain Domain { get; set; }

        public List<Fact> UsedFacts { get; set; }

        public Variable()
        {
            this.UsedFacts = new List<Fact>();
        }

        public Variable(int id, string name, int number, string type, int domainId)
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.Type = type;
            this.DomainId = domainId;
            this.UsedFacts = new List<Fact>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
