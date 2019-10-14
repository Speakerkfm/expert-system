using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        public MainForm(CurrentExpertSystem expertSystem, ExpertSystemService expertSystemService, VariableService variableService, DomainService domainService, RuleService ruleService, FactService factService)
        {
            this.expertSystem = expertSystem;
            this._expertSystemService = expertSystemService;
            this._variableService = variableService;
            this._domainService = domainService;
            this._factService = factService;
            this._ruleService = ruleService;

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

                FillRulesLv();
            }

            expertSystemSelector.Dispose();
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesEditForm variablesEditor = new VariablesEditForm(_variableService, _domainService);
            if (variablesEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Variables = variablesEditor.Variables;
            }

            variablesEditor.Dispose();
        }

        private void domainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainsEditForm domainEditor = new DomainsEditForm(_domainService);
            if (domainEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Domains = domainEditor.Domains;
            }

            domainEditor.Dispose();
        }

        private void btRuleAdd_Click(object sender, EventArgs e)
        {
            RuleForm ruleEditor = new RuleForm(_ruleService, _variableService, _factService, _domainService);
            if (ruleEditor.ShowDialog() == DialogResult.OK)
            {
                this._ruleService.AddRule(ruleEditor.Rule);
                lvRules.Items.Add(new ListViewItem(new[] { ruleEditor.Rule.Name, ruleEditor.Rule.ToString() }));
            }

            ruleEditor.Dispose();
        }

        private void btRuleEdit_Click(object sender, EventArgs e)
        {
            if (lvRules.SelectedIndices.Count == 1)
            {
                Rule selectedRule = this.expertSystem.Rules[lvRules.SelectedIndices[0]];
                RuleForm ruleEditor = new RuleForm(selectedRule, _ruleService, _variableService, _factService,
                    _domainService);
                if (ruleEditor.ShowDialog() == DialogResult.OK)
                {
                    FillRulesLv();
                }

                ruleEditor.Dispose();
            }
        }
        
        private void btRuleDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvRules.SelectedIndices)
            {
                this.expertSystem.Rules.RemoveAt(index);
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
    }
}
