using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.entity;
using ExpertSystem.model;
using ExpertSystem.src.service;

namespace ExpertSystem.src.forms
{
    internal partial class RuleForm : Form
    {
        private RuleService ruleService;
        private VariableService variableService;
        private FactService factService;
        private DomainService domainService;
        public Rule Rule { get; set; }

        private List<Fact> conditions;
        private List<Fact> conclusions;

        private int indexOfItemUnderMouseToDragCond;
        private int indexOfItemUnderMouseToDropCond;

        private Rectangle dragBoxFromMouseDownCond;

        private int indexOfItemUnderMouseToDragConcl;
        private int indexOfItemUnderMouseToDropConcl;

        private Rectangle dragBoxFromMouseDownConcl;

        public RuleForm(string ruleName, RuleService ruleService, VariableService variableService, FactService factService, DomainService domainService)
        {
            this.ruleService = ruleService;
            this.variableService = variableService;
            this.factService = factService;
            this.domainService = domainService;
            this.conditions = new List<Fact>();
            this.conclusions = new List<Fact>();

            InitializeComponent();

            this.tbRuleName.Text = ruleName;
        }

        public RuleForm(Rule rule, RuleService ruleService, VariableService variableService, FactService factService, DomainService domainService)
        {
            this.ruleService = ruleService;
            this.variableService = variableService;
            this.factService = factService;
            this.domainService = domainService;
            this.Rule = rule;
            this.conclusions = new List<Fact>();
            this.conditions = new List<Fact>();
            foreach (Fact conclusion in rule.Conclusions)
            {
                this.conclusions.Add(conclusion);
            }

            foreach (Fact condition in rule.Conditions)
            {
                this.conditions.Add(condition);
            }

            InitializeComponent();

            this.ExplainText.Text = rule.ExplainText;

            FillData();
        }

        private void FillData()
        {
            tbRuleName.Text = this.Rule.Name;

            FillConditionsLv();
            FillConclusionsLv();
        }

        private void FillConditionsLv()
        {
            lvConditions.Items.Clear();
            foreach (Fact condition in this.conditions)
            {
                lvConditions.Items.Add(new ListViewItem(new[] { condition.Variable.Name, condition.Value.Val }));
            }
        }

        private void FillConclusionsLv()
        {
            lvConclusions.Items.Clear();
            foreach (Fact conclusion in this.conclusions)
            {
                lvConclusions.Items.Add(new ListViewItem(new[] { conclusion.Variable.Name, conclusion.Value.Val }));
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (this.Rule == null)
            {
                this.Rule = new Rule();
            }

            this.Rule.Name = tbRuleName.Text;
            this.Rule.Conditions = this.conditions;
            this.Rule.Conclusions = this.conclusions;
            this.Rule.ExplainText = this.ExplainText.Text;
            foreach (Fact condition in this.Rule.Conditions)
            {
                factService.AddFact(condition);
                condition.UsedRules.Add(this.Rule);
            }
            foreach (Fact conclusion in this.Rule.Conclusions)
            {
                factService.AddFact(conclusion);
                conclusion.UsedRules.Add(this.Rule);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btConditionDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvConditions.SelectedIndices)
            {
                this.conditions.RemoveAt(index);
                lvConditions.Items.RemoveAt(index);
            }
        }

        private void btConditionAdd_Click(object sender, EventArgs e)
        {
            FactForm factEditor = new FactForm(this.variableService, this.factService, this.domainService, FactType.Condition);
            if (factEditor.ShowDialog(this) == DialogResult.OK)
            {
                this.conditions.Add(factEditor.Fact);
                lvConditions.Items.Add(new ListViewItem(new[] { factEditor.Fact.Variable.Name, factEditor.Fact.Value.Val }));
            }

            factEditor.Dispose();
        }

        private void btConditionEdit_Click(object sender, EventArgs e)
        {
            if (lvConditions.SelectedIndices.Count == 1)
            {
                Fact selectedCondition = this.conditions[lvConditions.SelectedIndices[0]];
                FactForm factEditor = new FactForm(selectedCondition, this.variableService, this.factService, this.domainService, FactType.Condition);
                if (factEditor.ShowDialog(this) == DialogResult.OK)
                {
                    this.conditions[lvConditions.SelectedIndices[0]] = factEditor.Fact;
                }

                factEditor.Dispose();
                
                FillConditionsLv();
            }
        }

        private void btConclusionDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvConclusions.SelectedIndices)
            {
                this.conclusions.RemoveAt(index);
                lvConclusions.Items.RemoveAt(index);
            }
        }

        private void btConclusionAdd_Click(object sender, EventArgs e)
        {
            FactForm factEditor = new FactForm(this.variableService, this.factService, this.domainService, FactType.Condition);
            if (factEditor.ShowDialog(this) == DialogResult.OK)
            {
                this.conclusions.Add(factEditor.Fact);
                lvConclusions.Items.Add(new ListViewItem(new[] { factEditor.Fact.Variable.Name, factEditor.Fact.Value.Val }));
            }

            factEditor.Dispose();
        }

        private void btConclusionEdit_Click(object sender, EventArgs e)
        {
            if (lvConclusions.SelectedIndices.Count == 1)
            {
                Fact selectedConclusion = this.conclusions[lvConclusions.SelectedIndices[0]];
                FactForm factEditor = new FactForm(selectedConclusion, this.variableService, this.factService, this.domainService, FactType.Condition);
                if (factEditor.ShowDialog(this) == DialogResult.OK)
                {
                    this.conclusions[lvConclusions.SelectedIndices[0]] = factEditor.Fact;
                }

                factEditor.Dispose();

                FillConclusionsLv();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lvConditions_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(System.Windows.Forms.ListViewItem));

            var p = this.PointToClient(Cursor.Position);
            int targetIndex = lvConditions.GetItemAt(p.X - lvConditions.Bounds.X, p.Y - lvConditions.Bounds.Y).Index;
            Fact movingRule = conditions[item.Index];
            conditions.RemoveAt(item.Index);
            conditions.Insert(targetIndex, movingRule);

            FillConditionsLv();
        }

        private void lvConditions_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvConditions_MouseDown(object sender, MouseEventArgs e)
        {
            indexOfItemUnderMouseToDragCond = lvConditions.Items.IndexOf(lvConditions.GetItemAt(e.X, e.Y));

            if (indexOfItemUnderMouseToDragCond != ListBox.NoMatches)
            {
                // DragSize  показывает на сколько можно сместить мышку, чтоб произошло событие
                Size dragSize = SystemInformation.DragSize;

                // Создаем прямоугольник в центре которого расположен курсор
                dragBoxFromMouseDownCond = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                    e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                // Сбрасываем наш прямоугольник если мышка не на каком-либо элементе в ListView.
                dragBoxFromMouseDownCond = Rectangle.Empty;
        }

        private void lvConditions_MouseUp(object sender, MouseEventArgs e)
        {
            // Сбросить прямоугольник если кнопка отпущена
            dragBoxFromMouseDownCond = Rectangle.Empty;
        }

        private void lvConditions_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDownCond != Rectangle.Empty &&
                    !dragBoxFromMouseDownCond.Contains(e.X, e.Y))
                {
                    lvConditions.DoDragDrop(lvConditions.Items[indexOfItemUnderMouseToDragCond],
                        DragDropEffects.All);
                }
            }
        }

        private void lvConclusions_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(System.Windows.Forms.ListViewItem));

            var p = this.PointToClient(Cursor.Position);
            int targetIndex = lvConclusions.GetItemAt(p.X - lvConclusions.Bounds.X, p.Y - lvConclusions.Bounds.Y).Index;
            Fact movingRule = conclusions[item.Index];
            conclusions.RemoveAt(item.Index);
            conclusions.Insert(targetIndex, movingRule);

            FillConclusionsLv();
        }

        private void lvConclusions_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvConclusions_MouseDown(object sender, MouseEventArgs e)
        {
            indexOfItemUnderMouseToDragConcl = lvConclusions.Items.IndexOf(lvConclusions.GetItemAt(e.X, e.Y));

            if (indexOfItemUnderMouseToDragConcl != ListBox.NoMatches)
            {
                // DragSize  показывает на сколько можно сместить мышку, чтоб произошло событие
                Size dragSize = SystemInformation.DragSize;

                // Создаем прямоугольник в центре которого расположен курсор
                dragBoxFromMouseDownConcl = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                    e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                // Сбрасываем наш прямоугольник если мышка не на каком-либо элементе в ListView.
                dragBoxFromMouseDownConcl = Rectangle.Empty;
        }

        private void lvConclusions_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDownConcl != Rectangle.Empty &&
                    !dragBoxFromMouseDownConcl.Contains(e.X, e.Y))
                {
                    lvConclusions.DoDragDrop(lvConclusions.Items[indexOfItemUnderMouseToDragConcl],
                        DragDropEffects.All);
                }
            }
        }

        private void lvConclusions_MouseUp(object sender, MouseEventArgs e)
        {
            // Сбросить прямоугольник если кнопка отпущена
            dragBoxFromMouseDownConcl = Rectangle.Empty;
        }
    }
}
