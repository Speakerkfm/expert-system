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
        private Domain domain;

        public DomainForm()
        {
            InitializeComponent();
        }

        public DomainForm(Domain domain)
        {
            InitializeComponent();

            this.domain = domain;

            FillData();
        }

        private void FillData()
        {
            tbDomainName.Text = domain.Name;
            cbDomainType.Text = domain.Type;
            lvValues.Columns.Add("№", -2, HorizontalAlignment.Left);
            lvValues.Columns.Add("Value", -2, HorizontalAlignment.Left);
            foreach (Value value in domain.Values)
            {
                lvValues.Items.Add(new ListViewItem(new [] {value.}));
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {

        }
    }
}
