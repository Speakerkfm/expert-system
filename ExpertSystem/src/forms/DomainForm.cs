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
    internal partial class DomainForm : Form
    {
        public Domain Domain { get; set; }

        private List<Value> values;
        private List<Value> deletedValues;
        private List<Value> addedValues;

        private DomainService domainService;

        public DomainForm(DomainService domainService)
        {
            InitializeComponent();

            this.domainService = domainService;
            this.values = new List<Value>();
            this.deletedValues = new List<Value>();
            this.addedValues = new List<Value>();
        }

        public DomainForm(Domain domain, DomainService domainService)
        {
            InitializeComponent();

            this.Domain = domain;
            this.domainService = domainService;
            this.values = new List<Value>();
            this.deletedValues = new List<Value>();
            this.addedValues = new List<Value>();

            foreach (Value value in domain.Values)
            {
                this.values.Add(value);
            }

            FillData();
        }

        private void FillData()
        {
            tbDomainName.Text = Domain.Name;
            cbDomainType.Text = Domain.Type;

            FillValuesLv();
        }

        private void FillValuesLv()
        {
            lvValues.Items.Clear();

            foreach (Value value in this.values)
            {
                lvValues.Items.Add(new ListViewItem(new[] { (lvValues.Items.Count + 1).ToString(), value.Val }));
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
            foreach (Value value in this.deletedValues)
            {
                this.Domain.Values.Remove(value);
                this.domainService.DeleteValue(value);
            }
            foreach (Value value in this.addedValues)
            {
                this.Domain.Values.Add(value);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btValueAdd_Click(object sender, EventArgs e)
        {
            Value existValue = domainService.GetValue(this.values, tbNewValue.Text);
            if (existValue != null)
            {
                MessageBox.Show("Value already exist");
                return;
            }

            Value newValue = domainService.GetOrCreateDomainValue(this.Domain.Values, tbNewValue.Text);
            newValue.Number = this.values.Count + 1;
            this.values.Add(newValue);
            this.addedValues.Add(newValue);
            this.deletedValues.Remove(newValue);

            FillValuesLv();
            tbNewValue.Text = "";
        }

        private void btValueDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvValues.SelectedIndices)
            {
                this.deletedValues.Add(this.values[index]);
                this.addedValues.Remove(this.values[index]);
                this.values.RemoveAt(index);

                for (int i = index; i < this.values.Count; i++)
                {
                    this.values[i].Number = i + 1;
                }

                FillData();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
