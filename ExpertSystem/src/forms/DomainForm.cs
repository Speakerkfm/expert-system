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

        private DomainService domainService;

        public DomainForm(DomainService domainService)
        {
            InitializeComponent();

            this.domainService = domainService;
            this.values = new List<Value>();
        }

        public DomainForm(Domain domain, DomainService domainService)
        {
            InitializeComponent();

            this.Domain = domain;
            this.domainService = domainService;
            this.values = new List<Value>();

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
            foreach (Value value in Domain.Values)
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
            this.Domain.Values.Clear();
            foreach (ListViewItem lvValuesItem in lvValues.Items)
            {
                Value newValue = domainService.GetOrCreateDomainValue(this.values, lvValuesItem.SubItems[1].Text);
                Domain.Values.Add(newValue);
            }
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

                for (int i = index; i < lvValues.Items.Count; i++)
                {
                    lvValues.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
