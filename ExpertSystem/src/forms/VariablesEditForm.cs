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
    internal partial class VariablesEditForm : Form
    {
        private VariableService variableService;
        private List<Variable> variables;

        public VariablesEditForm(VariableService variableService)
        {
            this.variableService = variableService;
            this.variables = variableService.GetVariables();

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            dgvVariables.DataSource = variables;

            if (dgvVariables.Columns.Count != 0)
            {
                dgvVariables.Columns[0].Visible = false;
                dgvVariables.Columns[2].Visible = false;
                dgvVariables.Columns[4].Visible = false;
            }
        }
    }
}
