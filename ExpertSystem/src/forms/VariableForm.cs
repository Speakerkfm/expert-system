using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.model;
using ExpertSystem.src.service;

namespace ExpertSystem.src.forms
{
    internal partial class VariableForm : Form
    {
        private DomainService domainService;
        public Variable Variable { get; set; }
        private Domain selectedDomain;

        public VariableForm(DomainService domainService)
        {
            this.domainService = domainService;

            InitializeComponent();

            FillDomainsCb();
        }

        public VariableForm(Variable variable, DomainService domainService)
        {
            this.domainService = domainService;
            this.Variable = variable;

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            tbVariableName.Text = Variable.Name;
            switch (Variable.Type)
            {
                case Variable.Concluded:
                    rbTypeConcluded.Checked = true;
                    break;
                case Variable.Requested:
                    rbTypeRequested.Checked = true;
                    break;
                case Variable.ConcludedRequested:
                    rbTypeConcludedRequested.Checked = true;
                    break;
                default:
                    rbTypeRequested.Checked = true;
                    break;
            }

            cbDomains.Items.Add(Variable.Domain);
            cbDomains.SelectedIndex = 0;
            selectedDomain = Variable.Domain;

            FillDomainsCb();
            FillValuesLv();
        }

        private void FillDomainsCb()
        {
            foreach (Domain domain in domainService.Domains)
            {
                if (domain == selectedDomain)
                {
                    continue;
                }

                cbDomains.Items.Add(domain);
            }
        }

        public void FillValuesLv()
        {
            lvValues.Items.Clear();
            foreach (Value value in selectedDomain.Values)
            {
                lvValues.Items.Add(new ListViewItem(new[] { (lvValues.Items.Count + 1).ToString(), value.Val }));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VariableForm_Load(object sender, EventArgs e)
        {

        }

        private void btDomainEdit_Click(object sender, EventArgs e)
        {
            Domain selectedDomain = (Domain)cbDomains.SelectedItem;
            DomainForm domainForm = new DomainForm(selectedDomain, domainService);
            if (domainForm.ShowDialog(this) == DialogResult.OK)
            {
                FillValuesLv();
            }

            domainForm.Dispose();
        }

        private void cbDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDomain = (Domain)cbDomains.SelectedItem;
            btDomainEdit.Enabled = true;
            FillValuesLv();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbType_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (this.Variable == null)
            {
                this.Variable = new Variable();
            }

            this.Variable.Name = tbVariableName.Text;
            if (rbTypeRequested.Checked)
            {
                this.Variable.Type = Variable.Requested;
            }
            if (rbTypeConcluded.Checked)
            {
                this.Variable.Type = Variable.Concluded;
            }
            if (rbTypeConcludedRequested.Checked)
            {
                this.Variable.Type = Variable.ConcludedRequested;
            }

            this.Variable.Domain = selectedDomain;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btDomainAdd_Click(object sender, EventArgs e)
        {
            DomainForm domainForm = new DomainForm(domainService);
            if (domainForm.ShowDialog(this) == DialogResult.OK)
            {
                this.domainService.AddDomain(domainForm.Domain);
                cbDomains.Items.Add(domainForm.Domain);
                cbDomains.SelectedItem = domainForm.Domain;
            }

            domainForm.Dispose();
        }
    }
}
