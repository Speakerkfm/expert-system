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
    internal partial class DomainForm : Form
    {
        public Domain Domain { get; set; }

        private List<Value> values;
        private List<Value> deletedValues;
        private List<Value> addedValues;

        private DomainService domainService;

        private int indexOfItemUnderMouseToDrag;
        private int indexOfItemUnderMouseToDrop;

        private Rectangle dragBoxFromMouseDown;

        public DomainForm(DomainService domainService)
        {
            InitializeComponent();

            this.Domain = new Domain();
            this.domainService = domainService;
            this.values = new List<Value>();
            this.deletedValues = new List<Value>();
            this.addedValues = new List<Value>();
        }

        public DomainForm(Domain domain, DomainService domainService)
        {
            InitializeComponent();

            this.Domain = domain;
            this.domainService = domainService;
            this.values = new List<Value>();
            this.deletedValues = new List<Value>();
            this.addedValues = new List<Value>();

            foreach (Value value in domain.Values)
            {
                this.values.Add(value);
            }

            FillData();
        }

        private void FillData()
        {
            tbDomainName.Text = Domain.Name;
            cbDomainType.Text = Domain.Type;

            FillValuesLv();
        }

        private void FillValuesLv()
        {
            lvValues.Items.Clear();

            foreach (Value value in this.values)
            {
                lvValues.Items.Add(new ListViewItem(new[] { (lvValues.Items.Count + 1).ToString(), value.Val }));
            }
        }
        
        private void btOk_Click(object sender, EventArgs e)
        {
            this.Domain.Name = tbDomainName.Text;
            this.Domain.Type = cbDomainType.Text;
            foreach (Value value in this.deletedValues)
            {
                this.Domain.Values.Remove(value);
                this.domainService.DeleteValue(value);
            }
            foreach (Value value in this.addedValues)
            {
                this.Domain.Values.Add(value);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btValueAdd_Click(object sender, EventArgs e)
        {
            Value existValue = domainService.GetValue(this.values, tbNewValue.Text);
            if (existValue != null)
            {
                MessageBox.Show("Value already exist");
                return;
            }

            Value newValue = domainService.GetOrCreateDomainValue(this.Domain.Values, tbNewValue.Text);
            newValue.Number = this.values.Count + 1;
            this.values.Add(newValue);
            this.addedValues.Add(newValue);
            this.deletedValues.Remove(newValue);

            FillValuesLv();
            tbNewValue.Text = "";
        }

        private void btValueDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lvValues.SelectedIndices)
            {
                this.deletedValues.Add(this.values[index]);
                this.addedValues.Remove(this.values[index]);
                this.values.RemoveAt(index);

                for (int i = index; i < this.values.Count; i++)
                {
                    this.values[i].Number = i + 1;
                }

                FillData();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lvValues_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(System.Windows.Forms.ListViewItem));

            var p = this.PointToClient(Cursor.Position);
            int targetIndex = lvValues.GetItemAt(p.X - lvValues.Bounds.X, p.Y - lvValues.Bounds.Y).Index;
            Value movingRule = values[item.Index];
            values.RemoveAt(item.Index);
            values.Insert(targetIndex, movingRule);

            Value movingVal = Domain.Values[item.Index];
            Domain.Values.RemoveAt(item.Index);
            Domain.Values.Insert(targetIndex, movingVal);

            FillValuesLv();
        }

        private void lvValues_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DomainForm_Load(object sender, EventArgs e)
        {

        }

        private void lvValues_MouseDown(object sender, MouseEventArgs e)
        {
            indexOfItemUnderMouseToDrag = lvValues.Items.IndexOf(lvValues.GetItemAt(e.X, e.Y));

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

        private void lvValues_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    lvValues.DoDragDrop(lvValues.Items[indexOfItemUnderMouseToDrag],
                        DragDropEffects.All);
                }
            }
        }

        private void lvValues_MouseUp(object sender, MouseEventArgs e)
        {
            // Сбросить прямоугольник если кнопка отпущена
            dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void lvValues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
