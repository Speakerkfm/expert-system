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
            foreach (WorkingMemoryItem item in this.workingMemory.KnownItems)
            {
                switch (item.Type)
                {
                    case MemoryItemType.Fact:
                        lvRules.Items.Add(new ListViewItem(new[] { item.Fact.Variable.Name, item.Fact.Value.Val }));
                        break;
                    case MemoryItemType.Rule:
                        lvRules.Items.Add(new ListViewItem(new[] { item.Rule.Name, item.Rule?.ExplainText }));
                        break;
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
