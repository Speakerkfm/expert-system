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
            this.SuspendLayout();
            // 
            // btConditionEdit
            // 
            this.btConditionEdit.Location = new System.Drawing.Point(419, 132);
            this.btConditionEdit.Name = "btConditionEdit";
            this.btConditionEdit.Size = new System.Drawing.Size(58, 61);
            this.btConditionEdit.TabIndex = 38;
            this.btConditionEdit.Text = "edit";
            this.btConditionEdit.UseVisualStyleBackColor = true;
            // 
            // btConditionDelete
            // 
            this.btConditionDelete.Location = new System.Drawing.Point(483, 132);
            this.btConditionDelete.Name = "btConditionDelete";
            this.btConditionDelete.Size = new System.Drawing.Size(57, 61);
            this.btConditionDelete.TabIndex = 37;
            this.btConditionDelete.Text = "-";
            this.btConditionDelete.UseVisualStyleBackColor = true;
            // 
            // btConditionAdd
            // 
            this.btConditionAdd.Location = new System.Drawing.Point(356, 132);
            this.btConditionAdd.Name = "btConditionAdd";
            this.btConditionAdd.Size = new System.Drawing.Size(57, 61);
            this.btConditionAdd.TabIndex = 36;
            this.btConditionAdd.Text = "+";
            this.btConditionAdd.UseVisualStyleBackColor = true;
            // 
            // lvConditions
            // 
            this.lvConditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Variable,
            this.Value});
            this.lvConditions.FullRowSelect = true;
            this.lvConditions.Location = new System.Drawing.Point(12, 200);
            this.lvConditions.Name = "lvConditions";
            this.lvConditions.Size = new System.Drawing.Size(528, 404);
            this.lvConditions.TabIndex = 35;
            this.lvConditions.UseCompatibleStateImageBehavior = false;
            this.lvConditions.View = System.Windows.Forms.View.Details;
            // 
            // Variable
            // 
            this.Variable.Text = "Variable";
            this.Variable.Width = 250;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 260;
            // 
            // btConclusionEdit
            // 
            this.btConclusionEdit.Location = new System.Drawing.Point(980, 133);
            this.btConclusionEdit.Name = "btConclusionEdit";
            this.btConclusionEdit.Size = new System.Drawing.Size(58, 61);
            this.btConclusionEdit.TabIndex = 42;
            this.btConclusionEdit.Text = "edit";
            this.btConclusionEdit.UseVisualStyleBackColor = true;
            // 
            // btConclusionDelete
            // 
            this.btConclusionDelete.Location = new System.Drawing.Point(1044, 133);
            this.btConclusionDelete.Name = "btConclusionDelete";
            this.btConclusionDelete.Size = new System.Drawing.Size(57, 61);
            this.btConclusionDelete.TabIndex = 41;
            this.btConclusionDelete.Text = "-";
            this.btConclusionDelete.UseVisualStyleBackColor = true;
            // 
            // btConclusionAdd
            // 
            this.btConclusionAdd.Location = new System.Drawing.Point(917, 133);
            this.btConclusionAdd.Name = "btConclusionAdd";
            this.btConclusionAdd.Size = new System.Drawing.Size(57, 61);
            this.btConclusionAdd.TabIndex = 40;
            this.btConclusionAdd.Text = "+";
            this.btConclusionAdd.UseVisualStyleBackColor = true;
            // 
            // lvConclusions
            // 
            this.lvConclusions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConclusionVariable,
            this.ConclusionValue});
            this.lvConclusions.FullRowSelect = true;
            this.lvConclusions.Location = new System.Drawing.Point(577, 200);
            this.lvConclusions.Name = "lvConclusions";
            this.lvConclusions.Size = new System.Drawing.Size(524, 404);
            this.lvConclusions.TabIndex = 39;
            this.lvConclusions.UseCompatibleStateImageBehavior = false;
            this.lvConclusions.View = System.Windows.Forms.View.Details;
            // 
            // ConclusionVariable
            // 
            this.ConclusionVariable.Text = "Variable";
            this.ConclusionVariable.Width = 262;
            // 
            // ConclusionValue
            // 
            this.ConclusionValue.Text = "Value";
            this.ConclusionValue.Width = 255;
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
            this.btCancel.Location = new System.Drawing.Point(933, 620);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(168, 75);
            this.btCancel.TabIndex = 47;
            this.btCancel.Text = "Close";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 737);
            this.Controls.Add(this.btCancel);
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
    }
}