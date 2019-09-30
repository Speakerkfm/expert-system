using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.model
{
    class Rule
    {
        private int id;
        private int number;
        private string name;
        private List<RuleCondition> conditions;
        private List<RuleResult> results;

    }
}
