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
using ExpertSystem.src.service;

namespace ExpertSystem.src.forms
{
    internal partial class GoalForm : Form
    {
        private VariableService variableService;
        private Variable selectedGoal;

        public Variable Goal { get; set; }

        public GoalForm(VariableService variableService)
        {
            this.variableService = variableService;

            InitializeComponent();

            FillVariableCb();
        }

        public GoalForm(Variable goal, VariableService variableService)
        {
            this.variableService = variableService;
            this.selectedGoal = goal;

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            cbVariable.Items.Add(selectedGoal);
            cbVariable.SelectedIndex = 0;
            
            FillVariableCb();
        }

        private void FillVariableCb()
        {
            foreach (Variable variable in variableService.Variables)
            {
                if (variable == selectedGoal)
                {
                    continue;
                }

                cbVariable.Items.Add(variable);
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Goal = selectedGoal;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedGoal = (Variable)cbVariable.SelectedItem;
        }
    }
}
