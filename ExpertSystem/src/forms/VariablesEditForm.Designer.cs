namespace ExpertSystem.src.forms
{
    partial class VariablesEditForm
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
            this.btVariableDelete = new System.Windows.Forms.Button();
            this.btVariableAdd = new System.Windows.Forms.Button();
            this.btVariableEdit = new System.Windows.Forms.Button();
            this.lvVariables = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VariableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DomainName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(771, 489);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(168, 75);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Close";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btVariableDelete
            // 
            this.btVariableDelete.Location = new System.Drawing.Point(148, 12);
            this.btVariableDelete.Name = "btVariableDelete";
            this.btVariableDelete.Size = new System.Drawing.Size(57, 61);
            this.btVariableDelete.TabIndex = 7;
            this.btVariableDelete.Text = "-";
            this.btVariableDelete.UseVisualStyleBackColor = true;
            this.btVariableDelete.Click += new System.EventHandler(this.btVariableDelete_Click);
            // 
            // btVariableAdd
            // 
            this.btVariableAdd.Location = new System.Drawing.Point(21, 12);
            this.btVariableAdd.Name = "btVariableAdd";
            this.btVariableAdd.Size = new System.Drawing.Size(57, 61);
            this.btVariableAdd.TabIndex = 6;
            this.btVariableAdd.Text = "+";
            this.btVariableAdd.UseVisualStyleBackColor = true;
            this.btVariableAdd.Click += new System.EventHandler(this.btVariableAdd_Click);
            // 
            // btVariableEdit
            // 
            this.btVariableEdit.Location = new System.Drawing.Point(84, 12);
            this.btVariableEdit.Name = "btVariableEdit";
            this.btVariableEdit.Size = new System.Drawing.Size(58, 61);
            this.btVariableEdit.TabIndex = 8;
            this.btVariableEdit.Text = "edit";
            this.btVariableEdit.UseVisualStyleBackColor = true;
            this.btVariableEdit.Click += new System.EventHandler(this.btVariableEdit_Click);
            // 
            // lvVariables
            // 
            this.lvVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.VariableName,
            this.Type,
            this.DomainName});
            this.lvVariables.FullRowSelect = true;
            this.lvVariables.Location = new System.Drawing.Point(21, 79);
            this.lvVariables.Name = "lvVariables";
            this.lvVariables.Size = new System.Drawing.Size(918, 404);
            this.lvVariables.TabIndex = 30;
            this.lvVariables.UseCompatibleStateImageBehavior = false;
            this.lvVariables.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "№";
            this.Number.Width = 83;
            // 
            // VariableName
            // 
            this.VariableName.Text = "Name";
            this.VariableName.Width = 262;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 255;
            // 
            // DomainName
            // 
            this.DomainName.Text = "DomainName";
            this.DomainName.Width = 313;
            // 
            // VariablesEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 590);
            this.Controls.Add(this.lvVariables);
            this.Controls.Add(this.btVariableEdit);
            this.Controls.Add(this.btVariableDelete);
            this.Controls.Add(this.btVariableAdd);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VariablesEditForm";
            this.Text = "VariablesEditForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btVariableDelete;
        private System.Windows.Forms.Button btVariableAdd;
        private System.Windows.Forms.Button btVariableEdit;
        private System.Windows.Forms.ListView lvVariables;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader VariableName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader DomainName;
    }
}