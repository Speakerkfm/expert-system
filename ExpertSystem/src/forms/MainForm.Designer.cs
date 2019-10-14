namespace ExpertSystem
{
    partial class MainForm
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
            this.headerMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertSystemToolStripCreateES = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvRules = new System.Windows.Forms.ListView();
            this.RuleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRuleEdit = new System.Windows.Forms.Button();
            this.btRuleDelete = new System.Windows.Forms.Button();
            this.btRuleAdd = new System.Windows.Forms.Button();
            this.headerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerMenu
            // 
            this.headerMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.headerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.headerMenu.Location = new System.Drawing.Point(0, 0);
            this.headerMenu.Name = "headerMenu";
            this.headerMenu.Size = new System.Drawing.Size(1246, 40);
            this.headerMenu.TabIndex = 0;
            this.headerMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expertSystemToolStripCreateES});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // expertSystemToolStripCreateES
            // 
            this.expertSystemToolStripCreateES.Name = "expertSystemToolStripCreateES";
            this.expertSystemToolStripCreateES.Size = new System.Drawing.Size(261, 38);
            this.expertSystemToolStripCreateES.Text = "Expert system";
            this.expertSystemToolStripCreateES.Click += new System.EventHandler(this.expertSystemToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expertSystemToolStripMenuItem,
            this.fromFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // expertSystemToolStripMenuItem
            // 
            this.expertSystemToolStripMenuItem.Name = "expertSystemToolStripMenuItem";
            this.expertSystemToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.expertSystemToolStripMenuItem.Text = "from database";
            this.expertSystemToolStripMenuItem.Click += new System.EventHandler(this.expertSystemToolStripMenuItem_Click);
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.fromFileToolStripMenuItem.Text = "from file";
            this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.fromFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(147, 38);
            this.fileToolStripMenuItem1.Text = "file";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variablesToolStripMenuItem,
            this.domainsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.variablesToolStripMenuItem.Text = "Variables";
            this.variablesToolStripMenuItem.Click += new System.EventHandler(this.variablesToolStripMenuItem_Click);
            // 
            // domainsToolStripMenuItem
            // 
            this.domainsToolStripMenuItem.Name = "domainsToolStripMenuItem";
            this.domainsToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.domainsToolStripMenuItem.Text = "Domains";
            this.domainsToolStripMenuItem.Click += new System.EventHandler(this.domainsToolStripMenuItem_Click);
            // 
            // lvRules
            // 
            this.lvRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RuleName,
            this.Rule});
            this.lvRules.FullRowSelect = true;
            this.lvRules.Location = new System.Drawing.Point(12, 127);
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(1046, 404);
            this.lvRules.TabIndex = 31;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.View = System.Windows.Forms.View.Details;
            // 
            // RuleName
            // 
            this.RuleName.Text = "Name";
            this.RuleName.Width = 50;
            // 
            // Rule
            // 
            this.Rule.Text = "Rule";
            this.Rule.Width = 400;
            // 
            // btRuleEdit
            // 
            this.btRuleEdit.Location = new System.Drawing.Point(937, 60);
            this.btRuleEdit.Name = "btRuleEdit";
            this.btRuleEdit.Size = new System.Drawing.Size(58, 61);
            this.btRuleEdit.TabIndex = 34;
            this.btRuleEdit.Text = "edit";
            this.btRuleEdit.UseVisualStyleBackColor = true;
            this.btRuleEdit.Click += new System.EventHandler(this.btRuleEdit_Click);
            // 
            // btRuleDelete
            // 
            this.btRuleDelete.Location = new System.Drawing.Point(1001, 60);
            this.btRuleDelete.Name = "btRuleDelete";
            this.btRuleDelete.Size = new System.Drawing.Size(57, 61);
            this.btRuleDelete.TabIndex = 33;
            this.btRuleDelete.Text = "-";
            this.btRuleDelete.UseVisualStyleBackColor = true;
            this.btRuleDelete.Click += new System.EventHandler(this.btRuleDelete_Click);
            // 
            // btRuleAdd
            // 
            this.btRuleAdd.Location = new System.Drawing.Point(874, 60);
            this.btRuleAdd.Name = "btRuleAdd";
            this.btRuleAdd.Size = new System.Drawing.Size(57, 61);
            this.btRuleAdd.TabIndex = 32;
            this.btRuleAdd.Text = "+";
            this.btRuleAdd.UseVisualStyleBackColor = true;
            this.btRuleAdd.Click += new System.EventHandler(this.btRuleAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 819);
            this.Controls.Add(this.btRuleEdit);
            this.Controls.Add(this.btRuleDelete);
            this.Controls.Add(this.btRuleAdd);
            this.Controls.Add(this.lvRules);
            this.Controls.Add(this.headerMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.headerMenu;
            this.Name = "MainForm";
            this.Text = "Expert system";
            this.headerMenu.ResumeLayout(false);
            this.headerMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip headerMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertSystemToolStripCreateES;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domainsToolStripMenuItem;
        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.ColumnHeader RuleName;
        private System.Windows.Forms.ColumnHeader Rule;
        private System.Windows.Forms.Button btRuleEdit;
        private System.Windows.Forms.Button btRuleDelete;
        private System.Windows.Forms.Button btRuleAdd;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    }
}

