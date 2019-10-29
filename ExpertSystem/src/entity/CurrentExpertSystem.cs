using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;
using ExpertSystem.src.entity;

namespace ExpertSystem.model
{
    [Serializable]
    class CurrentExpertSystem
    {
        private int id;
        private string name;

        public int Id => id;
        public string Name => name;

        public Variable Goal { get; set; }
        public List<Variable> Variables { get; set; }
        public List<Domain> Domains { get; set; }
        public List<Rule> Rules { get; set; }
        public List<Fact> Facts { get; set; }
        public WorkingMemory Memory { get; set; }

        public CurrentExpertSystem(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.Variables = new List<Variable>();
            this.Domains = new List<Domain>();
            this.Facts = new List<Fact>();
            this.Rules = new List<Rule>();
            this.Memory = new WorkingMemory();
        }
    }
}
