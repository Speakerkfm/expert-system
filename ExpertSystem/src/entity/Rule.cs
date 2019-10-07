using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystem.entity;

namespace ExpertSystem.model
{
    class Rule
    {
        private int id;
        private int number;
        private string name;
        private List<Fact> conditions;
        private List<Fact> results;

    }
}
