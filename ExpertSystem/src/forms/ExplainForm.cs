using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.entity;
using ExpertSystem.src.entity;

namespace ExpertSystem.src.forms
{
    internal partial class ExplainForm : Form
    {
        private WorkingMemory workingMemory;

        public ExplainForm(WorkingMemory workingMemory)
        {
            this.workingMemory = workingMemory;

            InitializeComponent();

            FillData();
        }

        public void FillData()
        {
            lvRules.Items.Clear();
            foreach (Fact fact in this.workingMemory.KnownFacts)
            {
                lvRules.Items.Add(new ListViewItem(new[] { "", fact.Variable.Name, fact.Value.Val }));
            }
        }
    }
}
