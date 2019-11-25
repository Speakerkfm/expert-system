namespace ExpertSystem.src.forms
{
    partial class ExplainForm
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
            this.tvExplain = new System.Windows.Forms.TreeView();
            this.lvWorkingMemory = new System.Windows.Forms.ListView();
            this.VariableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(1150, 504);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 63);
            this.btCancel.TabIndex = 50;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tvExplain
            // 
            this.tvExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvExplain.Location = new System.Drawing.Point(13, 13);
            this.tvExplain.Name = "tvExplain";
            this.tvExplain.Size = new System.Drawing.Size(848, 485);
            this.tvExplain.TabIndex = 51;
            this.tvExplain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvExplain_AfterSelect);
            this.tvExplain.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvExplain_NodeMouseDoubleClick);
            this.tvExplain.DoubleClick += new System.EventHandler(this.tvExplain_DoubleClick);
            // 
            // lvWorkingMemory
            // 
            this.lvWorkingMemory.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvWorkingMemory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWorkingMemory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VariableName,
            this.Value});
            this.lvWorkingMemory.FullRowSelect = true;
            this.lvWorkingMemory.GridLines = true;
            this.lvWorkingMemory.Location = new System.Drawing.Point(867, 13);
            this.lvWorkingMemory.Name = "lvWorkingMemory";
            this.lvWorkingMemory.Size = new System.Drawing.Size(384, 485);
            this.lvWorkingMemory.TabIndex = 52;
            this.lvWorkingMemory.UseCompatibleStateImageBehavior = false;
            this.lvWorkingMemory.View = System.Windows.Forms.View.Details;
            // 
            // VariableName
            // 
            this.VariableName.Text = "Name";
            this.VariableName.Width = 80;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 150;
            // 
            // ExplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 579);
            this.Controls.Add(this.lvWorkingMemory);
            this.Controls.Add(this.tvExplain);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExplainForm";
            this.Text = "ExplainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TreeView tvExplain;
        private System.Windows.Forms.ListView lvWorkingMemory;
        private System.Windows.Forms.ColumnHeader VariableName;
        private System.Windows.Forms.ColumnHeader Value;
    }
}