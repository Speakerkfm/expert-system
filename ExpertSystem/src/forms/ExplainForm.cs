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
using ExpertSystem.model;
using ExpertSystem.src.entity;
using Rule = ExpertSystem.model.Rule;

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
            FillLvMemory();
        }

        public void FillData()
        {
            if (workingMemory != null && workingMemory.KnownItems.Count != 0)
            {
                tvExplain.Nodes.Add(FillFactNode(workingMemory.KnownItems[workingMemory.KnownItems.Count - 1]));
            }
        }

        public void FillLvMemory()
        {
            lvWorkingMemory.Items.Clear();
            foreach (WorkingMemoryItem item in workingMemory.KnownItems)
            {
                lvWorkingMemory.Items.Add(new ListViewItem(new[] { item.Fact.Variable.Name, item.Fact.Value.Val }));
            }
        }

        public TreeNode FillFactNode(WorkingMemoryItem item)
        {
            Fact fact = item.Fact;

            TreeNode newNode = new TreeNode("Variable: " + fact.Variable.Name);
            TreeNode textNode = new TreeNode("Text ask: " + fact.Variable.TextAsk);
            TreeNode valueNode = new TreeNode("Value: " +fact.Value.Val);

            if (fact.Variable.TextAsk != "")
            {
                newNode.Nodes.Add(textNode);
            }
            newNode.Nodes.Add(valueNode);

            if (item.KnownFrom != null)
            {
                Rule rule = item.KnownFrom;
                newNode.Nodes.Add(FillRuleNode(rule));
            }

            return newNode;
        }

        public TreeNode FillRuleNode(Rule rule)
        {
            TreeNode newNode = new TreeNode("Rule name: " + rule.Name);
            TreeNode ruleNode = new TreeNode("Rule: " + rule.ToString());
            newNode.Nodes.Add(ruleNode);
            foreach (Fact ruleCondition in rule.Conditions)
            {
                WorkingMemoryItem item = workingMemory.GetFactItem(ruleCondition.Variable);
                newNode.Nodes.Add(FillFactNode(item));
            }

            return newNode;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void tvExplain_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvExplain_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void tvExplain_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.IsExpanded)
            {
                e.Node.Collapse();
            }
            else
            {
                e.Node.ExpandAll();
            }
        }
    }
}
