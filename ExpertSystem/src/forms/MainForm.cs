using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.model;
using ExpertSystem.service;
using ExpertSystem.src.forms;
using ExpertSystem.src.service;
using ExpertSystem.store;
using Rule = ExpertSystem.model.Rule;

namespace ExpertSystem
{
    internal partial class MainForm : Form
    {
        private CurrentExpertSystem expertSystem;

        private ExpertSystemService _expertSystemService;

        private VariableService _variableService;

        private DomainService _domainService;

        private FactService _factService;

        private RuleService _ruleService;

        private ConsultService _consultService;

        private int indexOfItemUnderMouseToDrag;
        private int indexOfItemUnderMouseToDrop;

        private Rectangle dragBoxFromMouseDown;

        public MainForm(CurrentExpertSystem expertSystem,
            ExpertSystemService expertSystemService, 
            VariableService variableService, 
            DomainService domainService, 
            RuleService ruleService, 
            FactService factService,
            ConsultService consultService)
        {
            this.expertSystem = expertSystem;
            this._expertSystemService = expertSystemService;
            this._variableService = variableService;
            this._domainService = domainService;
            this._factService = factService;
            this._ruleService = ruleService;
            this._consultService = consultService;

            InitializeComponent();
        }

        private void FillRulesLv()
        {
            if (this.expertSystem == null)
            {
                return;
            }

            lvRules.Items.Clear();
            foreach (Rule rule in this.expertSystem.Rules)
            {
                lvRules.Items.Add(new ListViewItem(new[] { rule.Name, rule.ToString()}));
            }
        }

        private void expertSystemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpertSystemCreator expertSystemCreator = new ExpertSystemCreator(_expertSystemService);
            expertSystemCreator.Show();
        }

        private void expertSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpertSystemSelectForm expertSystemSelector = new ExpertSystemSelectForm(_expertSystemService);
            if (expertSystemSelector.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem = _expertSystemService.GetCurrentExpertSystem();
            }

            expertSystemSelector.Dispose();

            FillRulesLv();
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesEditForm variablesEditor = new VariablesEditForm(_variableService, _domainService);
            if (variablesEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Variables = variablesEditor.Variables;
            }

            variablesEditor.Dispose();

            FillRulesLv();
        }

        private void domainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainsEditForm domainEditor = new DomainsEditForm(_domainService);
            if (domainEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Domains = domainEditor.Domains;
            }

            domainEditor.Dispose();

            FillRulesLv();
        }

        private void btRuleAdd_Click(object sender, EventArgs e)
        {
            string ruleName = "Rule " + (lvRules.Items.Count + 1);
            RuleForm ruleEditor = new RuleForm(ruleName, _ruleService, _variableService, _factService, _domainService);
            if (ruleEditor.ShowDialog() == DialogResult.OK)
            {
                this._ruleService.AddRule(ruleEditor.Rule);
            }

            ruleEditor.Dispose();

            FillRulesLv();
        }

        private void btRuleEdit_Click(object sender, EventArgs e)
        {
            if (lvRules.SelectedIndices.Count == 1)
            {
                Rule selectedRule = this.expertSystem.Rules[lvRules.SelectedIndices[0]];
                RuleForm ruleEditor = new RuleForm(selectedRule, _ruleService, _variableService, _factService,
                    _domainService);

                if (ruleEditor.ShowDialog() == DialogResult.OK && !this.expertSystem.Rules.Contains(selectedRule))
                {
                    this._ruleService.AddRule(ruleEditor.Rule);
                }

                ruleEditor.Dispose();

                FillRulesLv();
            }
        }
        
        private void btRuleDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvRules.SelectedIndices)
            {
                this._ruleService.DeleteRuleByIdx(index);
                lvRules.Items.RemoveAt(index);
            }
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stream myStream;

            BinaryFormatter formatter = new BinaryFormatter();
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = sfDialog.OpenFile()) != null)
                {
                    formatter.Serialize(myStream, expertSystem);
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;

            BinaryFormatter formatter = new BinaryFormatter();
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = ofDialog.OpenFile()) != null)
                {
                    this.expertSystem = (CurrentExpertSystem)formatter.Deserialize(myStream);
                    this._expertSystemService.SelectExpertSystem(this.expertSystem);
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }

            FillRulesLv();
        }

        private void setGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable goal = this.expertSystem.Goal;
            GoalForm goalEditor = goal == null ? new GoalForm(_variableService) : new GoalForm(goal, _variableService);

            if (goalEditor.ShowDialog() == DialogResult.OK)
            {
                this.expertSystem.Goal = goalEditor.Goal;
            }

            goalEditor.Dispose();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Value result = _consultService.BeginConsult(_expertSystemService.GetCurrentExpertSystem());

            MessageBox.Show(result == null ? "I don't know :c" : result.Val);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExplainForm explain = new ExplainForm(_expertSystemService.GetCurrentExpertSystem().Memory);

            if (explain.ShowDialog() == DialogResult.OK)
            {
            }

            explain.Dispose();
        }

        private void lvRules_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(System.Windows.Forms.ListViewItem));

            var p = this.PointToClient(Cursor.Position);
            int targetIndex = lvRules.GetItemAt(p.X - lvRules.Bounds.X,p.Y - lvRules.Bounds.Y).Index;
            Rule movingRule = expertSystem.Rules[item.Index];
            expertSystem.Rules.RemoveAt(item.Index);
            expertSystem.Rules.Insert(targetIndex, movingRule);

            FillRulesLv();
        }

        private void lvRules_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvRules_MouseDown(object sender, MouseEventArgs e)
        {
            indexOfItemUnderMouseToDrag = lvRules.Items.IndexOf(lvRules.GetItemAt(e.X, e.Y));

            if (indexOfItemUnderMouseToDrag != ListBox.NoMatches)
            {
                // DragSize  показывает на сколько можно сместить мышку, чтоб произошло событие
                Size dragSize = SystemInformation.DragSize;

                // Создаем прямоугольник в центре которого расположен курсор
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                    e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                // Сбрасываем наш прямоугольник если мышка не на каком-либо элементе в ListView.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void lvRules_MouseUp(object sender, MouseEventArgs e)
        {
            // Сбросить прямоугольник если кнопка отпущена
            dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void lvRules_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    lvRules.DoDragDrop(lvRules.Items[indexOfItemUnderMouseToDrag],
                        DragDropEffects.All);
                }
            }
        }

        private void lvRules_DragOver(object sender, DragEventArgs e)
        {
        }

        private void lvRules_DragLeave(object sender, EventArgs e)
        {

        }
    }
}
