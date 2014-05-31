namespace Assign3Mockup
{
    partial class NewsReaderForm
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
            this.labelServerPrompt = new System.Windows.Forms.Label();
            this.textBoxServerURL = new System.Windows.Forms.TextBox();
            this.splitContainerHorizontal = new System.Windows.Forms.SplitContainer();
            this.splitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.listBoxNewsgroups = new System.Windows.Forms.ListBox();
            this.listBoxArticleHeaders = new System.Windows.Forms.ListBox();
            this.textBoxArticleText = new System.Windows.Forms.TextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getGroupsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFilterGroups = new System.Windows.Forms.GroupBox();
            this.comboBoxSearchTerms = new System.Windows.Forms.ComboBox();
            this.labelSearchPrompt = new System.Windows.Forms.Label();
            this.radioButtonExclude = new System.Windows.Forms.RadioButton();
            this.radioButtonInclude = new System.Windows.Forms.RadioButton();
            this.checkBoxFilterGroups = new System.Windows.Forms.CheckBox();
            this.groupBoxFilterArticles = new System.Windows.Forms.GroupBox();
            this.labelArticles = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNumArticles = new System.Windows.Forms.Label();
            this.checkBoxFilterArticles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).BeginInit();
            this.splitContainerHorizontal.Panel1.SuspendLayout();
            this.splitContainerHorizontal.Panel2.SuspendLayout();
            this.splitContainerHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).BeginInit();
            this.splitContainerVertical.Panel1.SuspendLayout();
            this.splitContainerVertical.Panel2.SuspendLayout();
            this.splitContainerVertical.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.groupBoxFilterGroups.SuspendLayout();
            this.groupBoxFilterArticles.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelServerPrompt
            // 
            this.labelServerPrompt.AutoSize = true;
            this.labelServerPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerPrompt.Location = new System.Drawing.Point(33, 24);
            this.labelServerPrompt.Name = "labelServerPrompt";
            this.labelServerPrompt.Size = new System.Drawing.Size(41, 13);
            this.labelServerPrompt.TabIndex = 0;
            this.labelServerPrompt.Text = "Server:";
            // 
            // textBoxServerURL
            // 
            this.textBoxServerURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerURL.Location = new System.Drawing.Point(80, 21);
            this.textBoxServerURL.Name = "textBoxServerURL";
            this.textBoxServerURL.Size = new System.Drawing.Size(613, 20);
            this.textBoxServerURL.TabIndex = 1;
            // 
            // splitContainerHorizontal
            // 
            this.splitContainerHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerHorizontal.Location = new System.Drawing.Point(36, 157);
            this.splitContainerHorizontal.Name = "splitContainerHorizontal";
            // 
            // splitContainerHorizontal.Panel1
            // 
            this.splitContainerHorizontal.Panel1.Controls.Add(this.splitContainerVertical);
            // 
            // splitContainerHorizontal.Panel2
            // 
            this.splitContainerHorizontal.Panel2.Controls.Add(this.textBoxArticleText);
            this.splitContainerHorizontal.Size = new System.Drawing.Size(657, 263);
            this.splitContainerHorizontal.SplitterDistance = 250;
            this.splitContainerHorizontal.TabIndex = 2;
            // 
            // splitContainerVertical
            // 
            this.splitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVertical.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerVertical.IsSplitterFixed = true;
            this.splitContainerVertical.Location = new System.Drawing.Point(0, 0);
            this.splitContainerVertical.Name = "splitContainerVertical";
            this.splitContainerVertical.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerVertical.Panel1
            // 
            this.splitContainerVertical.Panel1.Controls.Add(this.listBoxNewsgroups);
            // 
            // splitContainerVertical.Panel2
            // 
            this.splitContainerVertical.Panel2.Controls.Add(this.listBoxArticleHeaders);
            this.splitContainerVertical.Size = new System.Drawing.Size(250, 263);
            this.splitContainerVertical.SplitterDistance = 95;
            this.splitContainerVertical.TabIndex = 0;
            // 
            // listBoxNewsgroups
            // 
            this.listBoxNewsgroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNewsgroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNewsgroups.FormattingEnabled = true;
            this.listBoxNewsgroups.IntegralHeight = false;
            this.listBoxNewsgroups.Location = new System.Drawing.Point(0, 0);
            this.listBoxNewsgroups.Name = "listBoxNewsgroups";
            this.listBoxNewsgroups.Size = new System.Drawing.Size(250, 95);
            this.listBoxNewsgroups.TabIndex = 0;
            this.listBoxNewsgroups.SelectedIndexChanged += new System.EventHandler(this.listBoxNewsgroups_SelectedIndexChanged);
            this.listBoxNewsgroups.DoubleClick += new System.EventHandler(this.listBoxNewsgroups_DoubleClick);
            // 
            // listBoxArticleHeaders
            // 
            this.listBoxArticleHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxArticleHeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArticleHeaders.FormattingEnabled = true;
            this.listBoxArticleHeaders.IntegralHeight = false;
            this.listBoxArticleHeaders.Location = new System.Drawing.Point(0, 0);
            this.listBoxArticleHeaders.Name = "listBoxArticleHeaders";
            this.listBoxArticleHeaders.Size = new System.Drawing.Size(250, 164);
            this.listBoxArticleHeaders.TabIndex = 0;
            this.listBoxArticleHeaders.SelectedIndexChanged += new System.EventHandler(this.listBoxArticleHeaders_SelectedIndexChanged);
            this.listBoxArticleHeaders.DoubleClick += new System.EventHandler(this.listBoxArticleHeaders_DoubleClick);
            // 
            // textBoxArticleText
            // 
            this.textBoxArticleText.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxArticleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxArticleText.Location = new System.Drawing.Point(0, 0);
            this.textBoxArticleText.Multiline = true;
            this.textBoxArticleText.Name = "textBoxArticleText";
            this.textBoxArticleText.ReadOnly = true;
            this.textBoxArticleText.Size = new System.Drawing.Size(403, 263);
            this.textBoxArticleText.TabIndex = 0;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.onlineToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(722, 24);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getGroupsListToolStripMenuItem});
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // getGroupsListToolStripMenuItem
            // 
            this.getGroupsListToolStripMenuItem.Name = "getGroupsListToolStripMenuItem";
            this.getGroupsListToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.getGroupsListToolStripMenuItem.Text = "Get Groups List";
            this.getGroupsListToolStripMenuItem.Click += new System.EventHandler(this.getGroupsListToolStripMenuItem_Click);
            // 
            // groupBoxFilterGroups
            // 
            this.groupBoxFilterGroups.Controls.Add(this.comboBoxSearchTerms);
            this.groupBoxFilterGroups.Controls.Add(this.labelSearchPrompt);
            this.groupBoxFilterGroups.Controls.Add(this.radioButtonExclude);
            this.groupBoxFilterGroups.Controls.Add(this.radioButtonInclude);
            this.groupBoxFilterGroups.Controls.Add(this.checkBoxFilterGroups);
            this.groupBoxFilterGroups.Location = new System.Drawing.Point(39, 47);
            this.groupBoxFilterGroups.Name = "groupBoxFilterGroups";
            this.groupBoxFilterGroups.Size = new System.Drawing.Size(428, 104);
            this.groupBoxFilterGroups.TabIndex = 4;
            this.groupBoxFilterGroups.TabStop = false;
            // 
            // comboBoxSearchTerms
            // 
            this.comboBoxSearchTerms.FormattingEnabled = true;
            this.comboBoxSearchTerms.Location = new System.Drawing.Point(28, 77);
            this.comboBoxSearchTerms.Name = "comboBoxSearchTerms";
            this.comboBoxSearchTerms.Size = new System.Drawing.Size(363, 21);
            this.comboBoxSearchTerms.TabIndex = 4;
            // 
            // labelSearchPrompt
            // 
            this.labelSearchPrompt.AutoSize = true;
            this.labelSearchPrompt.Location = new System.Drawing.Point(25, 62);
            this.labelSearchPrompt.Name = "labelSearchPrompt";
            this.labelSearchPrompt.Size = new System.Drawing.Size(202, 13);
            this.labelSearchPrompt.TabIndex = 3;
            this.labelSearchPrompt.Text = "Enter search words separated by spaces:";
            // 
            // radioButtonExclude
            // 
            this.radioButtonExclude.AutoSize = true;
            this.radioButtonExclude.Location = new System.Drawing.Point(110, 42);
            this.radioButtonExclude.Name = "radioButtonExclude";
            this.radioButtonExclude.Size = new System.Drawing.Size(63, 17);
            this.radioButtonExclude.TabIndex = 2;
            this.radioButtonExclude.TabStop = true;
            this.radioButtonExclude.Text = "Exclude";
            this.radioButtonExclude.UseVisualStyleBackColor = true;
            // 
            // radioButtonInclude
            // 
            this.radioButtonInclude.AutoSize = true;
            this.radioButtonInclude.Location = new System.Drawing.Point(28, 42);
            this.radioButtonInclude.Name = "radioButtonInclude";
            this.radioButtonInclude.Size = new System.Drawing.Size(60, 17);
            this.radioButtonInclude.TabIndex = 1;
            this.radioButtonInclude.TabStop = true;
            this.radioButtonInclude.Text = "Include";
            this.radioButtonInclude.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterGroups
            // 
            this.checkBoxFilterGroups.AutoSize = true;
            this.checkBoxFilterGroups.Location = new System.Drawing.Point(28, 10);
            this.checkBoxFilterGroups.Name = "checkBoxFilterGroups";
            this.checkBoxFilterGroups.Size = new System.Drawing.Size(83, 17);
            this.checkBoxFilterGroups.TabIndex = 0;
            this.checkBoxFilterGroups.Text = "Filter groups";
            this.checkBoxFilterGroups.UseVisualStyleBackColor = true;
            this.checkBoxFilterGroups.CheckedChanged += new System.EventHandler(this.checkBoxFilterGroups_CheckedChanged);
            // 
            // groupBoxFilterArticles
            // 
            this.groupBoxFilterArticles.Controls.Add(this.labelArticles);
            this.groupBoxFilterArticles.Controls.Add(this.textBox1);
            this.groupBoxFilterArticles.Controls.Add(this.labelNumArticles);
            this.groupBoxFilterArticles.Controls.Add(this.checkBoxFilterArticles);
            this.groupBoxFilterArticles.Location = new System.Drawing.Point(473, 47);
            this.groupBoxFilterArticles.Name = "groupBoxFilterArticles";
            this.groupBoxFilterArticles.Size = new System.Drawing.Size(220, 104);
            this.groupBoxFilterArticles.TabIndex = 5;
            this.groupBoxFilterArticles.TabStop = false;
            // 
            // labelArticles
            // 
            this.labelArticles.AutoSize = true;
            this.labelArticles.Location = new System.Drawing.Point(166, 34);
            this.labelArticles.Name = "labelArticles";
            this.labelArticles.Size = new System.Drawing.Size(40, 13);
            this.labelArticles.TabIndex = 3;
            this.labelArticles.Text = "articles";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 2;
            // 
            // labelNumArticles
            // 
            this.labelNumArticles.AutoSize = true;
            this.labelNumArticles.Location = new System.Drawing.Point(17, 34);
            this.labelNumArticles.Name = "labelNumArticles";
            this.labelNumArticles.Size = new System.Drawing.Size(95, 13);
            this.labelNumArticles.TabIndex = 1;
            this.labelNumArticles.Text = "Get only the latest:";
            // 
            // checkBoxFilterArticles
            // 
            this.checkBoxFilterArticles.AutoSize = true;
            this.checkBoxFilterArticles.Location = new System.Drawing.Point(17, 10);
            this.checkBoxFilterArticles.Name = "checkBoxFilterArticles";
            this.checkBoxFilterArticles.Size = new System.Drawing.Size(85, 17);
            this.checkBoxFilterArticles.TabIndex = 0;
            this.checkBoxFilterArticles.Text = "Filter Articles";
            this.checkBoxFilterArticles.UseVisualStyleBackColor = true;
            // 
            // NewsReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 432);
            this.Controls.Add(this.groupBoxFilterArticles);
            this.Controls.Add(this.groupBoxFilterGroups);
            this.Controls.Add(this.splitContainerHorizontal);
            this.Controls.Add(this.textBoxServerURL);
            this.Controls.Add(this.labelServerPrompt);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewsReaderForm";
            this.Text = "News Reader";
            this.Load += new System.EventHandler(this.NewsReaderForm_Load);
            this.splitContainerHorizontal.Panel1.ResumeLayout(false);
            this.splitContainerHorizontal.Panel2.ResumeLayout(false);
            this.splitContainerHorizontal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).EndInit();
            this.splitContainerHorizontal.ResumeLayout(false);
            this.splitContainerVertical.Panel1.ResumeLayout(false);
            this.splitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).EndInit();
            this.splitContainerVertical.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxFilterGroups.ResumeLayout(false);
            this.groupBoxFilterGroups.PerformLayout();
            this.groupBoxFilterArticles.ResumeLayout(false);
            this.groupBoxFilterArticles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServerPrompt;
        private System.Windows.Forms.TextBox textBoxServerURL;
        private System.Windows.Forms.SplitContainer splitContainerHorizontal;
        private System.Windows.Forms.SplitContainer splitContainerVertical;
        private System.Windows.Forms.ListBox listBoxNewsgroups;
        private System.Windows.Forms.ListBox listBoxArticleHeaders;
        private System.Windows.Forms.TextBox textBoxArticleText;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getGroupsListToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFilterGroups;
        private System.Windows.Forms.GroupBox groupBoxFilterArticles;
        private System.Windows.Forms.RadioButton radioButtonExclude;
        private System.Windows.Forms.RadioButton radioButtonInclude;
        private System.Windows.Forms.CheckBox checkBoxFilterGroups;
        private System.Windows.Forms.ComboBox comboBoxSearchTerms;
        private System.Windows.Forms.Label labelSearchPrompt;
        private System.Windows.Forms.Label labelArticles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNumArticles;
        private System.Windows.Forms.CheckBox checkBoxFilterArticles;
    }
}

