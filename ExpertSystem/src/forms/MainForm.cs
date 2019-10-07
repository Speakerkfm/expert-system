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
        private ExpertSystemService _expertSystemService;

        private VariableService _variableService;

        private DomainService _domainService;

        public MainForm(ExpertSystemService expertSystemService, VariableService variableService, DomainService domainService)
        {
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
            VariablesEditForm variablesEditor = new VariablesEditForm(_variableService);
            variablesEditor.Show();
        }

        private void domainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainsEditForm domainEditor = new DomainsEditForm(_domainService);
            domainEditor.Show();
        }
    }
}
