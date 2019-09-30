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
using ExpertSystem.store;

namespace ExpertSystem
{
    internal partial class MainForm : Form
    {
        private DataContainer _dataContainer;

        private ExpertSystemCreator _expertSystemCreator;

        public MainForm(DataContainer dataContainer, ExpertSystemCreator expertSystemCreator)
        {
            this._dataContainer = dataContainer;
            this._expertSystemCreator = expertSystemCreator;

            InitializeComponent();
        }

        private void expertSystemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Variable> variables = _dataContainer.Store.GetVariables(4);
            _expertSystemCreator.Show();
        }
    }
}
