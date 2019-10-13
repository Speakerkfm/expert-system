namespace ExpertSystem.src.forms
{
    partial class VariableForm
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
            this.tbVariableName = new System.Windows.Forms.TextBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbTypeConcludedRequested = new System.Windows.Forms.RadioButton();
            this.rbTypeConcluded = new System.Windows.Forms.RadioButton();
            this.rbTypeRequested = new System.Windows.Forms.RadioButton();
            this.cbDomains = new System.Windows.Forms.ComboBox();
            this.btDomainEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lvValues = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btDomainAdd = new System.Windows.Forms.Button();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVariableName
            // 
            this.tbVariableName.Location = new System.Drawing.Point(155, 78);
            this.tbVariableName.Name = "tbVariableName";
            this.tbVariableName.Size = new System.Drawing.Size(352, 31);
            this.tbVariableName.TabIndex = 0;
            this.tbVariableName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbTypeConcludedRequested);
            this.gbType.Controls.Add(this.rbTypeConcluded);
            this.gbType.Controls.Add(this.rbTypeRequested);
            this.gbType.Location = new System.Drawing.Point(155, 115);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(352, 189);
            this.gbType.TabIndex = 1;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            this.gbType.Enter += new System.EventHandler(this.gbType_Enter);
            // 
            // rbTypeConcludedRequested
            // 
            this.rbTypeConcludedRequested.AutoSize = true;
            this.rbTypeConcludedRequested.Location = new System.Drawing.Point(30, 138);
            this.rbTypeConcludedRequested.Name = "rbTypeConcludedRequested";
            this.rbTypeConcludedRequested.Size = new System.Drawing.Size(314, 29);
            this.rbTypeConcludedRequested.TabIndex = 2;
            this.rbTypeConcludedRequested.TabStop = true;
            this.rbTypeConcludedRequested.Text = "Выводимо-запрашиваемая";
            this.rbTypeConcludedRequested.UseVisualStyleBackColor = true;
            // 
            // rbTypeConcluded
            // 
            this.rbTypeConcluded.AutoSize = true;
            this.rbTypeConcluded.Location = new System.Drawing.Point(30, 90);
            this.rbTypeConcluded.Name = "rbTypeConcluded";
            this.rbTypeConcluded.Size = new System.Drawing.Size(157, 29);
            this.rbTypeConcluded.TabIndex = 1;
            this.rbTypeConcluded.TabStop = true;
            this.rbTypeConcluded.Text = "Выводимая";
            this.rbTypeConcluded.UseVisualStyleBackColor = true;
            // 
            // rbTypeRequested
            // 
            this.rbTypeRequested.AutoSize = true;
            this.rbTypeRequested.Location = new System.Drawing.Point(30, 44);
            this.rbTypeRequested.Name = "rbTypeRequested";
            this.rbTypeRequested.Size = new System.Drawing.Size(206, 29);
            this.rbTypeRequested.TabIndex = 0;
            this.rbTypeRequested.TabStop = true;
            this.rbTypeRequested.Text = "Запрашиваемая";
            this.rbTypeRequested.UseVisualStyleBackColor = true;
            // 
            // cbDomains
            // 
            this.cbDomains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDomains.FormattingEnabled = true;
            this.cbDomains.Location = new System.Drawing.Point(155, 310);
            this.cbDomains.Name = "cbDomains";
            this.cbDomains.Size = new System.Drawing.Size(352, 33);
            this.cbDomains.TabIndex = 2;
            this.cbDomains.SelectedIndexChanged += new System.EventHandler(this.cbDomains_SelectedIndexChanged);
            // 
            // btDomainEdit
            // 
            this.btDomainEdit.Location = new System.Drawing.Point(432, 349);
            this.btDomainEdit.Name = "btDomainEdit";
            this.btDomainEdit.Size = new System.Drawing.Size(75, 52);
            this.btDomainEdit.TabIndex = 3;
            this.btDomainEdit.Text = "edit";
            this.btDomainEdit.UseVisualStyleBackColor = true;
            this.btDomainEdit.Click += new System.EventHandler(this.btDomainEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Домен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Значения";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(299, 597);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(101, 63);
            this.btOk.TabIndex = 12;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(406, 597);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 63);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lvValues
            // 
            this.lvValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Value});
            this.lvValues.FullRowSelect = true;
            this.lvValues.Location = new System.Drawing.Point(155, 408);
            this.lvValues.Name = "lvValues";
            this.lvValues.Size = new System.Drawing.Size(352, 183);
            this.lvValues.TabIndex = 29;
            this.lvValues.UseCompatibleStateImageBehavior = false;
            this.lvValues.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "№";
            this.Number.Width = 83;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 262;
            // 
            // btDomainAdd
            // 
            this.btDomainAdd.Location = new System.Drawing.Point(351, 349);
            this.btDomainAdd.Name = "btDomainAdd";
            this.btDomainAdd.Size = new System.Drawing.Size(75, 52);
            this.btDomainAdd.TabIndex = 30;
            this.btDomainAdd.Text = "+";
            this.btDomainAdd.UseVisualStyleBackColor = true;
            this.btDomainAdd.Click += new System.EventHandler(this.btDomainAdd_Click);
            // 
            // VariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 685);
            this.Controls.Add(this.btDomainAdd);
            this.Controls.Add(this.lvValues);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDomainEdit);
            this.Controls.Add(this.cbDomains);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.tbVariableName);
            this.Name = "VariableForm";
            this.Text = "VariableForm";
            this.Load += new System.EventHandler(this.VariableForm_Load);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVariableName;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbTypeConcludedRequested;
        private System.Windows.Forms.RadioButton rbTypeConcluded;
        private System.Windows.Forms.RadioButton rbTypeRequested;
        private System.Windows.Forms.ComboBox cbDomains;
        private System.Windows.Forms.Button btDomainEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ListView lvValues;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Button btDomainAdd;
    }
}