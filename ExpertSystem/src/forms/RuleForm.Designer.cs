namespace ExpertSystem.src.forms
{
    partial class RuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConditionEdit = new System.Windows.Forms.Button();
            this.btConditionDelete = new System.Windows.Forms.Button();
            this.btConditionAdd = new System.Windows.Forms.Button();
            this.lvConditions = new System.Windows.Forms.ListView();
            this.Variable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btConclusionEdit = new System.Windows.Forms.Button();
            this.btConclusionDelete = new System.Windows.Forms.Button();
            this.btConclusionAdd = new System.Windows.Forms.Button();
            this.lvConclusions = new System.Windows.Forms.ListView();
            this.ConclusionVariable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConclusionValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRuleName = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.ExplainText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConditionEdit
            // 
            this.btConditionEdit.Location = new System.Drawing.Point(350, 133);
            this.btConditionEdit.Name = "btConditionEdit";
            this.btConditionEdit.Size = new System.Drawing.Size(92, 61);
            this.btConditionEdit.TabIndex = 38;
            this.btConditionEdit.Text = "Edit";
            this.btConditionEdit.UseVisualStyleBackColor = true;
            this.btConditionEdit.Click += new System.EventHandler(this.btConditionEdit_Click);
            // 
            // btConditionDelete
            // 
            this.btConditionDelete.Location = new System.Drawing.Point(448, 133);
            this.btConditionDelete.Name = "btConditionDelete";
            this.btConditionDelete.Size = new System.Drawing.Size(92, 61);
            this.btConditionDelete.TabIndex = 37;
            this.btConditionDelete.Text = "Delete";
            this.btConditionDelete.UseVisualStyleBackColor = true;
            this.btConditionDelete.Click += new System.EventHandler(this.btConditionDelete_Click);
            // 
            // btConditionAdd
            // 
            this.btConditionAdd.Location = new System.Drawing.Point(252, 132);
            this.btConditionAdd.Name = "btConditionAdd";
            this.btConditionAdd.Size = new System.Drawing.Size(92, 61);
            this.btConditionAdd.TabIndex = 36;
            this.btConditionAdd.Text = "Add";
            this.btConditionAdd.UseVisualStyleBackColor = true;
            this.btConditionAdd.Click += new System.EventHandler(this.btConditionAdd_Click);
            // 
            // lvConditions
            // 
            this.lvConditions.AllowDrop = true;
            this.lvConditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Variable,
            this.Value});
            this.lvConditions.FullRowSelect = true;
            this.lvConditions.GridLines = true;
            this.lvConditions.Location = new System.Drawing.Point(12, 200);
            this.lvConditions.Name = "lvConditions";
            this.lvConditions.Size = new System.Drawing.Size(528, 357);
            this.lvConditions.TabIndex = 35;
            this.lvConditions.UseCompatibleStateImageBehavior = false;
            this.lvConditions.View = System.Windows.Forms.View.Details;
            this.lvConditions.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvConditions_DragDrop);
            this.lvConditions.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvConditions_DragEnter);
            this.lvConditions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvConditions_MouseDown);
            this.lvConditions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvConditions_MouseMove);
            this.lvConditions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvConditions_MouseUp);
            // 
            // Variable
            // 
            this.Variable.Text = "Variable";
            this.Variable.Width = 100;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 100;
            // 
            // btConclusionEdit
            // 
            this.btConclusionEdit.Location = new System.Drawing.Point(911, 132);
            this.btConclusionEdit.Name = "btConclusionEdit";
            this.btConclusionEdit.Size = new System.Drawing.Size(92, 61);
            this.btConclusionEdit.TabIndex = 42;
            this.btConclusionEdit.Text = "Edit";
            this.btConclusionEdit.UseVisualStyleBackColor = true;
            this.btConclusionEdit.Click += new System.EventHandler(this.btConclusionEdit_Click);
            // 
            // btConclusionDelete
            // 
            this.btConclusionDelete.Location = new System.Drawing.Point(1009, 133);
            this.btConclusionDelete.Name = "btConclusionDelete";
            this.btConclusionDelete.Size = new System.Drawing.Size(92, 61);
            this.btConclusionDelete.TabIndex = 41;
            this.btConclusionDelete.Text = "Delete";
            this.btConclusionDelete.UseVisualStyleBackColor = true;
            this.btConclusionDelete.Click += new System.EventHandler(this.btConclusionDelete_Click);
            // 
            // btConclusionAdd
            // 
            this.btConclusionAdd.Location = new System.Drawing.Point(813, 133);
            this.btConclusionAdd.Name = "btConclusionAdd";
            this.btConclusionAdd.Size = new System.Drawing.Size(92, 61);
            this.btConclusionAdd.TabIndex = 40;
            this.btConclusionAdd.Text = "Add";
            this.btConclusionAdd.UseVisualStyleBackColor = true;
            this.btConclusionAdd.Click += new System.EventHandler(this.btConclusionAdd_Click);
            // 
            // lvConclusions
            // 
            this.lvConclusions.AllowDrop = true;
            this.lvConclusions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConclusionVariable,
            this.ConclusionValue});
            this.lvConclusions.FullRowSelect = true;
            this.lvConclusions.GridLines = true;
            this.lvConclusions.Location = new System.Drawing.Point(577, 200);
            this.lvConclusions.Name = "lvConclusions";
            this.lvConclusions.Size = new System.Drawing.Size(524, 357);
            this.lvConclusions.TabIndex = 39;
            this.lvConclusions.UseCompatibleStateImageBehavior = false;
            this.lvConclusions.View = System.Windows.Forms.View.Details;
            this.lvConclusions.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvConclusions_DragDrop);
            this.lvConclusions.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvConclusions_DragEnter);
            this.lvConclusions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvConclusions_MouseDown);
            this.lvConclusions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvConclusions_MouseMove);
            this.lvConclusions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvConclusions_MouseUp);
            // 
            // ConclusionVariable
            // 
            this.ConclusionVariable.Text = "Variable";
            this.ConclusionVariable.Width = 100;
            // 
            // ConclusionValue
            // 
            this.ConclusionValue.Text = "Value";
            this.ConclusionValue.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "If";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Then";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Name";
            // 
            // tbRuleName
            // 
            this.tbRuleName.Location = new System.Drawing.Point(127, 60);
            this.tbRuleName.Name = "tbRuleName";
            this.tbRuleName.Size = new System.Drawing.Size(258, 31);
            this.tbRuleName.TabIndex = 46;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(1000, 630);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 63);
            this.btCancel.TabIndex = 48;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(893, 630);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(101, 63);
            this.btOk.TabIndex = 47;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // ExplainText
            // 
            this.ExplainText.Location = new System.Drawing.Point(12, 588);
            this.ExplainText.Name = "ExplainText";
            this.ExplainText.Size = new System.Drawing.Size(875, 105);
            this.ExplainText.TabIndex = 49;
            this.ExplainText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Because";
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 737);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExplainText);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbRuleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConclusionEdit);
            this.Controls.Add(this.btConclusionDelete);
            this.Controls.Add(this.btConclusionAdd);
            this.Controls.Add(this.lvConclusions);
            this.Controls.Add(this.btConditionEdit);
            this.Controls.Add(this.btConditionDelete);
            this.Controls.Add(this.btConditionAdd);
            this.Controls.Add(this.lvConditions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RuleForm";
            this.Text = "RuleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConditionEdit;
        private System.Windows.Forms.Button btConditionDelete;
        private System.Windows.Forms.Button btConditionAdd;
        private System.Windows.Forms.ListView lvConditions;
        private System.Windows.Forms.ColumnHeader Variable;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Button btConclusionEdit;
        private System.Windows.Forms.Button btConclusionDelete;
        private System.Windows.Forms.Button btConclusionAdd;
        private System.Windows.Forms.ListView lvConclusions;
        private System.Windows.Forms.ColumnHeader ConclusionVariable;
        private System.Windows.Forms.ColumnHeader ConclusionValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRuleName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.RichTextBox ExplainText;
        private System.Windows.Forms.Label label4;
    }
}