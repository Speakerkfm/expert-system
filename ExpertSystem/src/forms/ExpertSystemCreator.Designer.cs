namespace ExpertSystem
{
    partial class ExpertSystemCreator
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
            this.tbESName = new System.Windows.Forms.TextBox();
            this.btESCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbESName
            // 
            this.tbESName.Location = new System.Drawing.Point(85, 61);
            this.tbESName.Name = "tbESName";
            this.tbESName.Size = new System.Drawing.Size(293, 31);
            this.tbESName.TabIndex = 0;
            // 
            // btESCreate
            // 
            this.btESCreate.Location = new System.Drawing.Point(85, 114);
            this.btESCreate.Name = "btESCreate";
            this.btESCreate.Size = new System.Drawing.Size(293, 45);
            this.btESCreate.TabIndex = 1;
            this.btESCreate.Text = "Create";
            this.btESCreate.UseVisualStyleBackColor = true;
            this.btESCreate.Click += new System.EventHandler(this.btESCreate_Click);
            // 
            // ExpertSystemCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 241);
            this.Controls.Add(this.btESCreate);
            this.Controls.Add(this.tbESName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ExpertSystemCreator";
            this.Text = "ExpertSystemCreator";
            this.Deactivate += new System.EventHandler(this.ExpertSystemCreator_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbESName;
        private System.Windows.Forms.Button btESCreate;
    }
}