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

namespace ExpertSystem.src.forms
{
    internal partial class ExpertSystemSelectForm : Form
    {
        private ExpertSystemService expertSystemService;
        private List<CurrentExpertSystem> expertSystems;

        public ExpertSystemSelectForm(ExpertSystemService expertSystemService)
        {
            this.expertSystemService = expertSystemService;
            this.expertSystems = expertSystemService.GetExpertSystems();

            InitializeComponent();
            
            FillCombobox();
        }

        private void FillCombobox()
        {
            foreach (CurrentExpertSystem expertSystem in expertSystems)
            {
                cbExpertSystem.Items.Add(expertSystem.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btSelectExpertSystem.Enabled = true;
        }

        private void btSelectExpertSystem_Click(object sender, EventArgs e)
        {
            expertSystemService.SelectExpertSystem(expertSystems[cbExpertSystem.SelectedIndex]);

            this.Close();
        }
    }
}
