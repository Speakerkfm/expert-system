namespace ExpertSystem.src.forms
{
    partial class FactForm
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
            this.cbVariable = new System.Windows.Forms.ComboBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.btVariableEdit = new System.Windows.Forms.Button();
            this.btVariableAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVariable
            // 
            this.cbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVariable.FormattingEnabled = true;
            this.cbVariable.Location = new System.Drawing.Point(12, 110);
            this.cbVariable.Name = "cbVariable";
            this.cbVariable.Size = new System.Drawing.Size(291, 33);
            this.cbVariable.TabIndex = 0;
            this.cbVariable.SelectedIndexChanged += new System.EventHandler(this.cbVariable_SelectedIndexChanged);
            // 
            // cbOperation
            // 
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(309, 110);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(140, 33);
            this.cbOperation.TabIndex = 1;
            // 
            // cbValue
            // 
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.Enabled = false;
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(455, 110);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(265, 33);
            this.cbValue.TabIndex = 2;
            this.cbValue.SelectedIndexChanged += new System.EventHandler(this.cbValue_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(619, 199);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 63);
            this.btCancel.TabIndex = 27;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(512, 199);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(101, 63);
            this.btOk.TabIndex = 26;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btVariableEdit
            // 
            this.btVariableEdit.Enabled = false;
            this.btVariableEdit.Location = new System.Drawing.Point(235, 28);
            this.btVariableEdit.Name = "btVariableEdit";
            this.btVariableEdit.Size = new System.Drawing.Size(58, 61);
            this.btVariableEdit.TabIndex = 30;
            this.btVariableEdit.Text = "edit";
            this.btVariableEdit.UseVisualStyleBackColor = true;
            this.btVariableEdit.Click += new System.EventHandler(this.btVariableEdit_Click);
            // 
            // btVariableAdd
            // 
            this.btVariableAdd.Location = new System.Drawing.Point(172, 28);
            this.btVariableAdd.Name = "btVariableAdd";
            this.btVariableAdd.Size = new System.Drawing.Size(57, 61);
            this.btVariableAdd.TabIndex = 28;
            this.btVariableAdd.Text = "+";
            this.btVariableAdd.UseVisualStyleBackColor = true;
            this.btVariableAdd.Click += new System.EventHandler(this.btVariableAdd_Click);
            // 
            // FactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 311);
            this.Controls.Add(this.btVariableEdit);
            this.Controls.Add(this.btVariableAdd);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.cbVariable);
            this.Name = "FactForm";
            this.Text = "FactForm";
            this.Load += new System.EventHandler(this.FactForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVariable;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btVariableEdit;
        private System.Windows.Forms.Button btVariableAdd;
    }
}