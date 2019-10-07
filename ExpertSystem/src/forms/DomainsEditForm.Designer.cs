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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(1126, 434);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(168, 75);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btDomainsSave
            // 
            this.btDomainsSave.Location = new System.Drawing.Point(935, 434);
            this.btDomainsSave.Name = "btDomainsSave";
            this.btDomainsSave.Size = new System.Drawing.Size(185, 75);
            this.btDomainsSave.TabIndex = 4;
            this.btDomainsSave.Text = "Save";
            this.btDomainsSave.UseVisualStyleBackColor = true;
            // 
            // dgvDomains
            // 
            this.dgvDomains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomains.Location = new System.Drawing.Point(12, 40);
            this.dgvDomains.Name = "dgvDomains";
            this.dgvDomains.RowTemplate.Height = 33;
            this.dgvDomains.Size = new System.Drawing.Size(1282, 379);
            this.dgvDomains.TabIndex = 3;
            // 
            // DomainsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 688);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDomainsSave);
            this.Controls.Add(this.dgvDomains);
            this.Name = "DomainsEditForm";
            this.Text = "DomainsEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDomainsSave;
        private System.Windows.Forms.DataGridView dgvDomains;
    }
}