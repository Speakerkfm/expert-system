namespace ExpertSystem.src.forms
{
    partial class ConsultForm
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
            this.TextAsk = new System.Windows.Forms.RichTextBox();
            this.lvValues = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAsk
            // 
            this.TextAsk.Enabled = false;
            this.TextAsk.Location = new System.Drawing.Point(38, 84);
            this.TextAsk.Name = "TextAsk";
            this.TextAsk.Size = new System.Drawing.Size(516, 212);
            this.TextAsk.TabIndex = 0;
            this.TextAsk.Text = "";
            // 
            // lvValues
            // 
            this.lvValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Value});
            this.lvValues.FullRowSelect = true;
            this.lvValues.GridLines = true;
            this.lvValues.Location = new System.Drawing.Point(38, 302);
            this.lvValues.Name = "lvValues";
            this.lvValues.Size = new System.Drawing.Size(516, 242);
            this.lvValues.TabIndex = 30;
            this.lvValues.UseCompatibleStateImageBehavior = false;
            this.lvValues.View = System.Windows.Forms.View.Details;
            this.lvValues.SelectedIndexChanged += new System.EventHandler(this.lvValues_SelectedIndexChanged);
            this.lvValues.DoubleClick += new System.EventHandler(this.lvValues_DoubleClick);
            // 
            // Number
            // 
            this.Number.Text = "№";
            this.Number.Width = 83;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 262;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(453, 550);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 63);
            this.btCancel.TabIndex = 31;
            this.btCancel.Text = "Exit";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(346, 550);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(101, 63);
            this.btOk.TabIndex = 32;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click_1);
            // 
            // ConsultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 629);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lvValues);
            this.Controls.Add(this.TextAsk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultForm";
            this.Text = "consultForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultForm_FormClosing);
            this.Load += new System.EventHandler(this.ConsultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextAsk;
        private System.Windows.Forms.ListView lvValues;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}