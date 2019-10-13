namespace ExpertSystem.src.forms
{
    partial class DomainsEditForm
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
            this.btDomainsSave = new System.Windows.Forms.Button();
            this.dgvDomains = new System.Windows.Forms.DataGridView();
            this.btVariableEdit = new System.Windows.Forms.Button();
            this.btVariableDelete = new System.Windows.Forms.Button();
            this.btVariableAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(601, 486);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(168, 75);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btDomainsSave
            // 
            this.btDomainsSave.Location = new System.Drawing.Point(410, 486);
            this.btDomainsSave.Name = "btDomainsSave";
            this.btDomainsSave.Size = new System.Drawing.Size(185, 75);
            this.btDomainsSave.TabIndex = 4;
            this.btDomainsSave.Text = "Save";
            this.btDomainsSave.UseVisualStyleBackColor = true;
            // 
            // dgvDomains
            // 
            this.dgvDomains.AllowDrop = true;
            this.dgvDomains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomains.Location = new System.Drawing.Point(12, 101);
            this.dgvDomains.MultiSelect = false;
            this.dgvDomains.Name = "dgvDomains";
            this.dgvDomains.RowTemplate.Height = 33;
            this.dgvDomains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomains.Size = new System.Drawing.Size(757, 379);
            this.dgvDomains.TabIndex = 3;
            this.dgvDomains.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDomains_UserDeletingRow);
            // 
            // btVariableEdit
            // 
            this.btVariableEdit.Location = new System.Drawing.Point(76, 34);
            this.btVariableEdit.Name = "btVariableEdit";
            this.btVariableEdit.Size = new System.Drawing.Size(58, 61);
            this.btVariableEdit.TabIndex = 11;
            this.btVariableEdit.Text = "edit";
            this.btVariableEdit.UseVisualStyleBackColor = true;
            this.btVariableEdit.Click += new System.EventHandler(this.btVariableEdit_Click);
            // 
            // btVariableDelete
            // 
            this.btVariableDelete.Location = new System.Drawing.Point(140, 34);
            this.btVariableDelete.Name = "btVariableDelete";
            this.btVariableDelete.Size = new System.Drawing.Size(57, 61);
            this.btVariableDelete.TabIndex = 10;
            this.btVariableDelete.Text = "-";
            this.btVariableDelete.UseVisualStyleBackColor = true;
            this.btVariableDelete.Click += new System.EventHandler(this.btVariableDelete_Click);
            // 
            // btVariableAdd
            // 
            this.btVariableAdd.Location = new System.Drawing.Point(13, 34);
            this.btVariableAdd.Name = "btVariableAdd";
            this.btVariableAdd.Size = new System.Drawing.Size(57, 61);
            this.btVariableAdd.TabIndex = 9;
            this.btVariableAdd.Text = "+";
            this.btVariableAdd.UseVisualStyleBackColor = true;
            this.btVariableAdd.Click += new System.EventHandler(this.btVariableAdd_Click);
            // 
            // DomainsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 572);
            this.Controls.Add(this.btVariableEdit);
            this.Controls.Add(this.btVariableDelete);
            this.Controls.Add(this.btVariableAdd);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDomainsSave);
            this.Controls.Add(this.dgvDomains);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DomainsEditForm";
            this.Text = "DomainsEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDomainsSave;
        private System.Windows.Forms.DataGridView dgvDomains;
        private System.Windows.Forms.Button btVariableEdit;
        private System.Windows.Forms.Button btVariableDelete;
        private System.Windows.Forms.Button btVariableAdd;
    }
}