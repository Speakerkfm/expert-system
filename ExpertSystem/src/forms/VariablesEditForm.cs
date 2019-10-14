using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.model;
using ExpertSystem.src.service;

namespace ExpertSystem.src.forms
{
    internal partial class VariablesEditForm : Form
    {
        private VariableService variableService;
        private DomainService domainService;
        public List<Variable> Variables { get; set; }

        public VariablesEditForm(VariableService variableService, DomainService domainService)
        {
            this.variableService = variableService;
            this.domainService = domainService;
            this.Variables = variableService.Variables;

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            lvVariables.Items.Clear();
            foreach (Variable variable in Variables)
            {
                lvVariables.Items.Add(new ListViewItem(new[] { variable.Number.ToString(), variable.Name, variable.Type, variable.Domain.Name }));
            }
        }

        private void btVariableSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btVariableAdd_Click(object sender, EventArgs e)
        {
            VariableForm variableForm = new VariableForm(domainService);
            if (variableForm.ShowDialog(this) == DialogResult.OK)
            {
                variableService.AddVariable(variableForm.Variable);

                FillData();
            }

            variableForm.Dispose();
        }

        private void btVariableEdit_Click(object sender, EventArgs e)
        {
            if (lvVariables.SelectedIndices.Count == 1)
            {
                Variable selectedVariable = Variables[lvVariables.SelectedIndices[0]];
                VariableForm variableForm = new VariableForm(selectedVariable, domainService);
                if (variableForm.ShowDialog(this) == DialogResult.OK)
                {
                    FillData();
                }

                variableForm.Dispose();
            }
        }

        private void btVariableDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvVariables.SelectedIndices)
            {
                variableService.DeleteVariableByIdx(index);
            }

            FillData();
        }
    }
}
