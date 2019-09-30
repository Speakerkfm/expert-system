using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.service;

namespace ExpertSystem
{
    internal partial class ExpertSystemCreator : Form
    {
        private ExpertSystemService expertSystemService;

        public ExpertSystemCreator(ExpertSystemService expertSystemService)
        {
            this.expertSystemService = expertSystemService;

            InitializeComponent();
        }

        private void btESCreate_Click(object sender, EventArgs e)
        {
            expertSystemService.CreateExpertSystem(tbESName.Text);

            this.Close();
        }
    }
}
