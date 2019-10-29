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
            this.btVariableEdit = new System.Windows.Forms.Button();
            this.btVariableDelete = new System.Windows.Forms.Button();
            this.btVariableAdd = new System.Windows.Forms.Button();
            this.lvDomains = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DomainName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(622, 485);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(168, 75);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Close";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btVariableEdit
            // 
            this.btVariableEdit.Location = new System.Drawing.Point(158, 12);
            this.btVariableEdit.Name = "btVariableEdit";
            this.btVariableEdit.Size = new System.Drawing.Size(140, 60);
            this.btVariableEdit.TabIndex = 11;
            this.btVariableEdit.Text = "Edit";
            this.btVariableEdit.UseVisualStyleBackColor = true;
            this.btVariableEdit.Click += new System.EventHandler(this.btVariableEdit_Click);
            // 
            // btVariableDelete
            // 
            this.btVariableDelete.Location = new System.Drawing.Point(304, 12);
            this.btVariableDelete.Name = "btVariableDelete";
            this.btVariableDelete.Size = new System.Drawing.Size(140, 60);
            this.btVariableDelete.TabIndex = 10;
            this.btVariableDelete.Text = "Delete";
            this.btVariableDelete.UseVisualStyleBackColor = true;
            this.btVariableDelete.Click += new System.EventHandler(this.btVariableDelete_Click);
            // 
            // btVariableAdd
            // 
            this.btVariableAdd.Location = new System.Drawing.Point(12, 12);
            this.btVariableAdd.Name = "btVariableAdd";
            this.btVariableAdd.Size = new System.Drawing.Size(140, 60);
            this.btVariableAdd.TabIndex = 9;
            this.btVariableAdd.Text = "Add";
            this.btVariableAdd.UseVisualStyleBackColor = true;
            this.btVariableAdd.Click += new System.EventHandler(this.btVariableAdd_Click);
            // 
            // lvDomains
            // 
            this.lvDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.DomainName,
            this.Type});
            this.lvDomains.FullRowSelect = true;
            this.lvDomains.GridLines = true;
            this.lvDomains.Location = new System.Drawing.Point(13, 78);
            this.lvDomains.Name = "lvDomains";
            this.lvDomains.Size = new System.Drawing.Size(777, 401);
            this.lvDomains.TabIndex = 29;
            this.lvDomains.UseCompatibleStateImageBehavior = false;
            this.lvDomains.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "№";
            this.Number.Width = 83;
            // 
            // DomainName
            // 
            this.DomainName.Text = "Name";
            this.DomainName.Width = 262;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // DomainsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 572);
            this.Controls.Add(this.lvDomains);
            this.Controls.Add(this.btVariableEdit);
            this.Controls.Add(this.btVariableDelete);
            this.Controls.Add(this.btVariableAdd);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DomainsEditForm";
            this.Text = "DomainsEditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btVariableEdit;
        private System.Windows.Forms.Button btVariableDelete;
        private System.Windows.Forms.Button btVariableAdd;
        private System.Windows.Forms.ListView lvDomains;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader DomainName;
        private System.Windows.Forms.ColumnHeader Type;
    }
}