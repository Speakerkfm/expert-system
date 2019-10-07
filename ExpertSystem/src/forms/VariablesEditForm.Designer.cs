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
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.btVariableSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVariables
            // 
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Location = new System.Drawing.Point(21, 80);
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.RowTemplate.Height = 33;
            this.dgvVariables.Size = new System.Drawing.Size(1282, 379);
            this.dgvVariables.TabIndex = 0;
            // 
            // btVariableSave
            // 
            this.btVariableSave.Location = new System.Drawing.Point(927, 489);
            this.btVariableSave.Name = "btVariableSave";
            this.btVariableSave.Size = new System.Drawing.Size(185, 75);
            this.btVariableSave.TabIndex = 1;
            this.btVariableSave.Text = "Save";
            this.btVariableSave.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(1135, 489);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(168, 75);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // VariablesEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 635);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btVariableSave);
            this.Controls.Add(this.dgvVariables);
            this.Name = "VariablesEditForm";
            this.Text = "VariablesEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVariables;
        private System.Windows.Forms.Button btVariableSave;
        private System.Windows.Forms.Button btCancel;
    }
}