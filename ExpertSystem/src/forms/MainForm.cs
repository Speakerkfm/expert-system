using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.model;
using ExpertSystem.service;
using ExpertSystem.src.forms;
using ExpertSystem.src.service;
using ExpertSystem.store;

namespace ExpertSystem
{
    internal partial class MainForm : Form
    {
        private CurrentExpertSystem expertSystem;

        private ExpertSystemService _expertSystemService;

        private VariableService _variableService;

        private DomainService _domainService;

        public MainForm(CurrentExpertSystem expertSystem, ExpertSystemService expertSystemService, VariableService variableService, DomainService domainService)
        {
            this.expertSystem = expertSystem;
            this._expertSystemService = expertSystemService;
            this._variableService = variableService;
            this._domainService = domainService;

            InitializeComponent();
        }

        private void expertSystemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpertSystemCreator expertSystemCreator = new ExpertSystemCreator(_expertSystemService);
            expertSystemCreator.Show();
        }

        private void expertSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpertSystemSelectForm expertSystemSelector = new ExpertSystemSelectForm(_expertSystemService);
            expertSystemSelector.Show();
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesEditForm variablesEditor = new VariablesEditForm(_variableService, _domainService);
            if (variablesEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Variables = variablesEditor.Variables;
            }
        }

        private void domainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainsEditForm domainEditor = new DomainsEditForm(_domainService);
            if (domainEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Domains = domainEditor.Domains;
            }
        }
    }
}
