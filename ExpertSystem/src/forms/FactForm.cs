using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.entity;
using ExpertSystem.model;
using ExpertSystem.src.service;

namespace ExpertSystem.src.forms
{
    enum FactType
    {
        Condition,
        Conclusion
    }

    internal partial class FactForm : Form
    {
        public Fact Fact { get; set; }
        public FactType Type { get; set; }

        private VariableService variableService;
        private FactService factService;
        private Variable selectedVariable;
        
        public FactForm(VariableService variableService, FactService factService, FactType type)
        {
            this.variableService = variableService;
            this.factService = factService;
            this.Type = type;

            InitializeComponent();
            
            FillOperationCb();
            FillVariableCb();
        }

        public FactForm(Fact fact, VariableService variableService, FactService factService, FactType type)
        {
            this.Fact = fact;
            this.variableService = variableService;
            this.factService = factService;
            this.Type = type;

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            cbVariable.Items.Add(this.Fact.Variable);
            cbVariable.SelectedIndex = 0;
            selectedVariable = this.Fact.Variable;

            FillOperationCb();
            FillVariableCb();
        }

        private void FillVariableCb()
        {
            cbVariable.Items.Clear();

            foreach (Variable variable in variableService.GetVariables())
            {
                if (variable.Number == selectedVariable?.Number)
                {
                    continue;
                }

                cbVariable.Items.Add(variable);
            }
        }

        private void FillValueCb()
        {
            cbValue.Items.Clear();
        }

        private void FillOperationCb()
        {
            cbOperation.Items.Clear();

            switch (this.Type)
            {
                case FactType.Conclusion:
                    cbOperation.Items.Add("=");
                    break;
                case FactType.Condition:
                    cbOperation.Items.Add("==");
                    break;
            }

            cbOperation.SelectedIndex = 0;
        }

        private void cbVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillValueCb();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Fact = this.factService.GetOrCreateFactByVarVal((Variable) cbVariable.SelectedItem, (Value) cbValue.SelectedItem);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
