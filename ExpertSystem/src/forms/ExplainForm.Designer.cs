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
            this.lvRules = new System.Windows.Forms.ListView();
            this.Variable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.ExplainText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvRules
            // 
            this.lvRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ExplainText,
            this.Variable,
            this.Value});
            this.lvRules.FullRowSelect = true;
            this.lvRules.GridLines = true;
            this.lvRules.Location = new System.Drawing.Point(12, 12);
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(608, 486);
            this.lvRules.TabIndex = 36;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.View = System.Windows.Forms.View.Details;
            // 
            // Variable
            // 
            this.Variable.DisplayIndex = 0;
            this.Variable.Text = "Variable";
            this.Variable.Width = 100;
            // 
            // Value
            // 
            this.Value.DisplayIndex = 1;
            this.Value.Text = "Value";
            this.Value.Width = 100;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(519, 504);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 63);
            this.btCancel.TabIndex = 50;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(412, 504);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(101, 63);
            this.btOk.TabIndex = 49;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // ExplainText
            // 
            this.ExplainText.DisplayIndex = 2;
            this.ExplainText.Text = "Text";
            this.ExplainText.Width = 300;
            // 
            // ExplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 579);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lvRules);
            this.Name = "ExplainForm";
            this.Text = "ExplainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.ColumnHeader Variable;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader ExplainText;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}