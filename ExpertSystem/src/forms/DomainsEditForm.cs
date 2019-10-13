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
using MySql.Data.Types;

namespace ExpertSystem.src.forms
{
    internal partial class DomainsEditForm : Form
    {
        private DomainService domainService;
        private List<Domain> domains;

        public DomainsEditForm(DomainService domainService)
        {
            this.domainService = domainService;
            this.domains = domainService.GetDomains();

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            dgvDomains.DataSource = domains;

            if (dgvDomains.Columns.Count != 0)
            {
                dgvDomains.Columns[3].Visible = false;
            }
        }

        private void dgvDomains_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MessageBox.Show("kek");
        }

        private void btVariableAdd_Click(object sender, EventArgs e)
        {
            DomainForm domainForm = new DomainForm();
            domainForm.Show();
        }

        private void btVariableEdit_Click(object sender, EventArgs e)
        {
            DomainForm domainForm = new DomainForm((Domain)dgvDomains.SelectedRows[0].DataBoundItem);
            domainForm.Show();
        }

        private void btVariableDelete_Click(object sender, EventArgs e)
        {
            dgvDomains.DataSource = null;

            foreach (var selectedRow in dgvDomains.SelectedRows)
            {
                domains.RemoveAt(((DataGridViewRow)selectedRow).Index);
            }

            dgvDomains.DataSource = domains;
            dgvDomains.Refresh();
        }
    }
}
