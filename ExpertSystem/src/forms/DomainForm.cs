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

namespace ExpertSystem.src.forms
{
    internal partial class DomainForm : Form
    {
        public Domain Domain { get; set; }

        public DomainForm()
        {
            InitializeComponent();
        }

        public DomainForm(Domain domain)
        {
            InitializeComponent();

            this.Domain = domain;

            FillData();
        }

        private void FillData()
        {
            tbDomainName.Text = Domain.Name;
            cbDomainType.Text = Domain.Type;
            foreach (Value value in Domain.Values)
            {
                lvValues.Items.Add(new ListViewItem(new [] {(lvValues.Items.Count + 1).ToString(), value.Val}));
            }
        }
        
        private void btOk_Click(object sender, EventArgs e)
        {
            if (this.Domain == null)
            {
                this.Domain = new Domain();
            }
            this.Domain.Name = tbDomainName.Text;
            this.Domain.Type = cbDomainType.Text;
            this.Domain.Values.Clear();
            foreach (ListViewItem lvValuesItem in lvValues.Items)
            {
                Value newValue = new Value(0, lvValuesItem.Index, lvValuesItem.SubItems[1].Text);
                Domain.Values.Add(newValue);
            }
            Domain.Values.Sort((x, y) => x.Number.CompareTo(y.Number));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btValueAdd_Click(object sender, EventArgs e)
        {
            lvValues.Items.Add(new ListViewItem(new[] { (lvValues.Items.Count + 1).ToString(), tbNewValue.Text}));
            tbNewValue.Text = "";
        }

        private void btValueDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvValues.SelectedIndices)
            {
                lvValues.Items.RemoveAt(index);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
