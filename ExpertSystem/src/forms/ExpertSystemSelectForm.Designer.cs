namespace ExpertSystem.src.forms
{
    partial class ExpertSystemSelectForm
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
            this.cbExpertSystem = new System.Windows.Forms.ComboBox();
            this.btSelectExpertSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbExpertSystem
            // 
            this.cbExpertSystem.Location = new System.Drawing.Point(13, 35);
            this.cbExpertSystem.Name = "cbExpertSystem";
            this.cbExpertSystem.Size = new System.Drawing.Size(514, 33);
            this.cbExpertSystem.TabIndex = 0;
            this.cbExpertSystem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btSelectExpertSystem
            // 
            this.btSelectExpertSystem.Enabled = false;
            this.btSelectExpertSystem.Location = new System.Drawing.Point(95, 99);
            this.btSelectExpertSystem.Name = "btSelectExpertSystem";
            this.btSelectExpertSystem.Size = new System.Drawing.Size(342, 161);
            this.btSelectExpertSystem.TabIndex = 1;
            this.btSelectExpertSystem.Text = "Select";
            this.btSelectExpertSystem.UseVisualStyleBackColor = true;
            this.btSelectExpertSystem.Click += new System.EventHandler(this.btSelectExpertSystem_Click);
            // 
            // ExpertSystemSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 317);
            this.Controls.Add(this.btSelectExpertSystem);
            this.Controls.Add(this.cbExpertSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExpertSystemSelectForm";
            this.Text = "ExpertSystemSelectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbExpertSystem;
        private System.Windows.Forms.Button btSelectExpertSystem;
    }
}