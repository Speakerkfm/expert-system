namespace ExpertSystem.src.forms
{
    partial class DomainForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDomainType = new System.Windows.Forms.ComboBox();
            this.btValueAdd = new System.Windows.Forms.Button();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.btValueDelete = new System.Windows.Forms.Button();
            this.lvValues = new System.Windows.Forms.ListView();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(412, 497);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 63);
            this.btCancel.TabIndex = 25;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(305, 497);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(101, 63);
            this.btOk.TabIndex = 24;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Значения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Имя";
            // 
            // cbDomainType
            // 
            this.cbDomainType.Enabled = false;
            this.cbDomainType.FormattingEnabled = true;
            this.cbDomainType.Location = new System.Drawing.Point(161, 75);
            this.cbDomainType.Name = "cbDomainType";
            this.cbDomainType.Size = new System.Drawing.Size(352, 33);
            this.cbDomainType.TabIndex = 18;
            this.cbDomainType.Text = "Строковый";
            // 
            // btValueAdd
            // 
            this.btValueAdd.Location = new System.Drawing.Point(393, 399);
            this.btValueAdd.Name = "btValueAdd";
            this.btValueAdd.Size = new System.Drawing.Size(57, 47);
            this.btValueAdd.TabIndex = 17;
            this.btValueAdd.Text = "+";
            this.btValueAdd.UseVisualStyleBackColor = true;
            this.btValueAdd.Click += new System.EventHandler(this.btValueAdd_Click);
            // 
            // tbDomainName
            // 
            this.tbDomainName.Location = new System.Drawing.Point(161, 27);
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(352, 31);
            this.tbDomainName.TabIndex = 14;
            // 
            // btValueDelete
            // 
            this.btValueDelete.Location = new System.Drawing.Point(456, 399);
            this.btValueDelete.Name = "btValueDelete";
            this.btValueDelete.Size = new System.Drawing.Size(57, 47);
            this.btValueDelete.TabIndex = 27;
            this.btValueDelete.Text = "-";
            this.btValueDelete.UseVisualStyleBackColor = true;
            this.btValueDelete.Click += new System.EventHandler(this.btValueDelete_Click);
            // 
            // lvValues
            // 
            this.lvValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Value});
            this.lvValues.FullRowSelect = true;
            this.lvValues.Location = new System.Drawing.Point(161, 163);
            this.lvValues.Name = "lvValues";
            this.lvValues.Size = new System.Drawing.Size(352, 192);
            this.lvValues.TabIndex = 28;
            this.lvValues.UseCompatibleStateImageBehavior = false;
            this.lvValues.View = System.Windows.Forms.View.Details;
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(161, 362);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(352, 31);
            this.tbNewValue.TabIndex = 29;
            // 
            // Number
            // 
            this.Number.Text = "№";
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // DomainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 598);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.lvValues);
            this.Controls.Add(this.btValueDelete);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDomainType);
            this.Controls.Add(this.btValueAdd);
            this.Controls.Add(this.tbDomainName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DomainForm";
            this.Text = "DomainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDomainType;
        private System.Windows.Forms.Button btValueAdd;
        private System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.Button btValueDelete;
        private System.Windows.Forms.ListView lvValues;
        private System.Windows.Forms.TextBox tbNewValue;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Value;
    }
}