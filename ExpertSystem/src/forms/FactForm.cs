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
        private DomainService domainService;


        private Variable selectedVariable;
        private Value selectedValue;

        private bool loading = false;
        
        public FactForm(VariableService variableService, FactService factService, DomainService domainService, FactType type)
        {
            this.variableService = variableService;
            this.factService = factService;
            this.domainService = domainService;
            this.Type = type;

            InitializeComponent();
            
            FillOperationCb();
            FillVariableCb();
        }

        public FactForm(Fact fact, VariableService variableService, FactService factService, DomainService domainService, FactType type)
        {
            this.Fact = fact;
            selectedVariable = fact.Variable;
            selectedValue = fact.Value;
            this.variableService = variableService;
            this.factService = factService;
            this.domainService = domainService;
            this.Type = type;

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            loading = true;

            cbVariable.Items.Add(selectedVariable);
            cbVariable.SelectedIndex = 0;

            cbValue.Items.Add(selectedValue);
            cbValue.SelectedIndex = 0;

            loading = false;

            FillOperationCb();
            FillVariableCb();
            FillValueCb();
        }

        private void FillVariableCb()
        {
            foreach (Variable variable in variableService.Variables)
            {
                if (variable == selectedVariable)
                {
                    continue;
                }

                cbVariable.Items.Add(variable);
            }
        }

        private void FillValueCb()
        {
            foreach (Value value in selectedVariable.Domain.Values)
            {
                if (value == selectedValue)
                {
                    continue;
                }

                cbValue.Items.Add(value);
            }
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
            cbValue.Enabled = cbVariable.Items.Count != 0;
            btVariableEdit.Enabled = cbVariable.Items.Count != 0;

            if (loading)
            {
                return;
            }

            selectedVariable = (Variable)cbVariable.SelectedItem;
            selectedValue = null;
            cbValue.Items.Clear();
            FillValueCb();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Fact = this.factService.GetOrCreateFactByVarVal((Variable) cbVariable.SelectedItem,
                    (Value)cbValue.SelectedItem);
            
            this.Fact.Variable.UsedFacts.Add(this.Fact);
            this.Fact.Value.UsedFacts.Add(this.Fact);
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
            this.selectedValue = (Value) cbValue.SelectedItem;
        }

        private void FactForm_Load(object sender, EventArgs e)
        {

        }

        private void btVariableAdd_Click(object sender, EventArgs e)
        {
            VariableForm variableForm = new VariableForm(domainService);
            if (variableForm.ShowDialog(this) == DialogResult.OK)
            {
                this.variableService.AddVariable(variableForm.Variable);
                cbVariable.Items.Add(variableForm.Variable);
            }

            variableForm.Dispose();
        }

        private void btVariableEdit_Click(object sender, EventArgs e)
        {
            Variable selectedVariable = (Variable) cbVariable.SelectedItem;
            VariableForm variableForm = new VariableForm(selectedVariable, domainService);
            if (variableForm.ShowDialog(this) == DialogResult.OK)
            {
                cbValue.Items.Clear();
                FillValueCb();
            }

            variableForm.Dispose();
        }
    }
}
