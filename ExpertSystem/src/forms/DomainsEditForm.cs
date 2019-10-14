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
        public List<Domain> Domains { get; set; }

        public DomainsEditForm(DomainService domainService)
        {
            this.domainService = domainService;
            this.Domains = domainService.Domains;

            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            lvDomains.Items.Clear();
            foreach (Domain domain in Domains)
            {
                lvDomains.Items.Add(new ListViewItem(new[] { (lvDomains.Items.Count + 1).ToString(), domain.Name, domain.Type }));
            }
        }

        private void btVariableAdd_Click(object sender, EventArgs e)
        {
            DomainForm domainForm = new DomainForm(domainService);
            if (domainForm.ShowDialog(this) == DialogResult.OK)
            {
                domainService.AddDomain(domainForm.Domain);

                FillData();
            }

            domainForm.Dispose();
        }

        private void btVariableEdit_Click(object sender, EventArgs e)
        {
            if (lvDomains.SelectedIndices.Count == 1)
            {
                Domain selectedDomain = Domains[lvDomains.SelectedIndices[0]];
                DomainForm domainForm = new DomainForm(selectedDomain, domainService);
                if (domainForm.ShowDialog(this) == DialogResult.OK)
                {
                    FillData();
                }

                domainForm.Dispose();
            }
        }

        private void btVariableDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvDomains.SelectedIndices)
            {
                domainService.DeleteDomainByIdx(index);
            }

            FillData();
        }

        private void btDomainsSave_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
