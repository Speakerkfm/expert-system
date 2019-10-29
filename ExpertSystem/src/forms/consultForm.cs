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
using ExpertSystem.src.service;

namespace ExpertSystem.src.forms
{
    internal partial class ConsultForm : Form
    {
        private Variable variable;
        public Value ResultValue { get; set; }

        public ConsultForm(Variable variable)
        {
            this.variable = variable;

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            this.TextAsk.Text = variable.TextAsk;
            FillValuesLv();
        }

        public void FillValuesLv()
        {
            lvValues.Items.Clear();
            foreach (Value value in this.variable.Domain.Values)
            {
                lvValues.Items.Add(new ListViewItem(new[] { (lvValues.Items.Count + 1).ToString(), value.Val }));
            }
        }

        private void lvValues_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btOk_Click_1(object sender, EventArgs e)
        {
            if (lvValues.SelectedItems.Count == 1)
            {
                ResultValue = this.variable.Domain.Values[lvValues.SelectedIndices[0]];

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void lvValues_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
