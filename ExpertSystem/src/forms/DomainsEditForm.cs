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
        }
    }
}
