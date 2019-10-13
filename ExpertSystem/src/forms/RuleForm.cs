using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.model;
using ExpertSystem.src.service;

namespace ExpertSystem.src.forms
{
    internal partial class RuleForm : Form
    {
        private RuleService ruleService;
        public Rule Rule { get; set; }

        public RuleForm(RuleService ruleService)
        {
            this.ruleService = ruleService;

            InitializeComponent();
        }

        public RuleForm(Rule rule, RuleService ruleService)
        {
            this.Rule = rule;
            this.ruleService = ruleService;

            InitializeComponent();
        }


    }
}
