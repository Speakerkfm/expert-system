using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.model;
using ExpertSystem.service;
using ExpertSystem.src.forms;
using ExpertSystem.src.service;
using ExpertSystem.store;
using Rule = ExpertSystem.model.Rule;

namespace ExpertSystem
{
    internal partial class MainForm : Form
    {
        private CurrentExpertSystem expertSystem;

        private ExpertSystemService _expertSystemService;

        private VariableService _variableService;

        private DomainService _domainService;

        private FactService _factService;

        private RuleService _ruleService;

        private ConsultService _consultService;

        public MainForm(CurrentExpertSystem expertSystem,
            ExpertSystemService expertSystemService, 
            VariableService variableService, 
            DomainService domainService, 
            RuleService ruleService, 
            FactService factService,
            ConsultService consultService)
        {
            this.expertSystem = expertSystem;
            this._expertSystemService = expertSystemService;
            this._variableService = variableService;
            this._domainService = domainService;
            this._factService = factService;
            this._ruleService = ruleService;
            this._consultService = consultService;

            InitializeComponent();
        }

        private void FillRulesLv()
        {
            if (this.expertSystem == null)
            {
                return;
            }

            lvRules.Items.Clear();
            foreach (Rule rule in this.expertSystem.Rules)
            {
                lvRules.Items.Add(new ListViewItem(new[] { rule.Name, rule.ToString()}));
            }
        }

        private void expertSystemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpertSystemCreator expertSystemCreator = new ExpertSystemCreator(_expertSystemService);
            expertSystemCreator.Show();
        }

        private void expertSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpertSystemSelectForm expertSystemSelector = new ExpertSystemSelectForm(_expertSystemService);
            if (expertSystemSelector.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem = _expertSystemService.GetCurrentExpertSystem();
            }

            expertSystemSelector.Dispose();

            FillRulesLv();
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesEditForm variablesEditor = new VariablesEditForm(_variableService, _domainService);
            if (variablesEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Variables = variablesEditor.Variables;
            }

            variablesEditor.Dispose();

            FillRulesLv();
        }

        private void domainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainsEditForm domainEditor = new DomainsEditForm(_domainService);
            if (domainEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Domains = domainEditor.Domains;
            }

            domainEditor.Dispose();

            FillRulesLv();
        }

        private void btRuleAdd_Click(object sender, EventArgs e)
        {
            string ruleName = "Rule " + (lvRules.Items.Count + 1);
            RuleForm ruleEditor = new RuleForm(ruleName, _ruleService, _variableService, _factService, _domainService);
            if (ruleEditor.ShowDialog() == DialogResult.OK)
            {
                this._ruleService.AddRule(ruleEditor.Rule);
            }

            ruleEditor.Dispose();

            FillRulesLv();
        }

        private void btRuleEdit_Click(object sender, EventArgs e)
        {
            if (lvRules.SelectedIndices.Count == 1)
            {
                Rule selectedRule = this.expertSystem.Rules[lvRules.SelectedIndices[0]];
                RuleForm ruleEditor = new RuleForm(selectedRule, _ruleService, _variableService, _factService,
                    _domainService);

                if (ruleEditor.ShowDialog() == DialogResult.OK && !this.expertSystem.Rules.Contains(selectedRule))
                {
                    this._ruleService.AddRule(ruleEditor.Rule);
                }

                ruleEditor.Dispose();

                FillRulesLv();
            }
        }
        
        private void btRuleDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvRules.SelectedIndices)
            {
                this._ruleService.DeleteRuleByIdx(index);
                lvRules.Items.RemoveAt(index);
            }
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("es.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, expertSystem);
            }
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("es.dat", FileMode.OpenOrCreate))
            {
                this.expertSystem = (CurrentExpertSystem) formatter.Deserialize(fs);
                this._expertSystemService.SelectExpertSystem(this.expertSystem);
            }

            FillRulesLv();
        }

        private void setGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable goal = this.expertSystem.Goal;
            GoalForm goalEditor = goal == null ? new GoalForm(_variableService) : new GoalForm(goal, _variableService);

            if (goalEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Goal = goalEditor.Goal;
            }

            goalEditor.Dispose();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Value result = _consultService.BeginConsult(_expertSystemService.GetCurrentExpertSystem());

            MessageBox.Show(result?.Val);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExplainForm explain = new ExplainForm(_expertSystemService.GetCurrentExpertSystem().Memory);

            if (explain.ShowDialog() == DialogResult.OK)
            {
            }

            explain.Dispose();
        }
    }
}
