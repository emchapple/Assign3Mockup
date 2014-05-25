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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).BeginInit();
            this.splitContainerHorizontal.Panel1.SuspendLayout();
            this.splitContainerHorizontal.Panel2.SuspendLayout();
            this.splitContainerHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).BeginInit();
            this.splitContainerVertical.Panel1.SuspendLayout();
            this.splitContainerVertical.Panel2.SuspendLayout();
            this.splitContainerVertical.SuspendLayout();
            this.menuStripMain.SuspendLayout();
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
            this.textBoxServerURL.Size = new System.Drawing.Size(881, 20);
            this.textBoxServerURL.TabIndex = 1;
            // 
            // splitContainerHorizontal
            // 
            this.splitContainerHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerHorizontal.Location = new System.Drawing.Point(36, 137);
            this.splitContainerHorizontal.Name = "splitContainerHorizontal";
            // 
            // splitContainerHorizontal.Panel1
            // 
            this.splitContainerHorizontal.Panel1.Controls.Add(this.splitContainerVertical);
            // 
            // splitContainerHorizontal.Panel2
            // 
            this.splitContainerHorizontal.Panel2.Controls.Add(this.textBoxArticleText);
            this.splitContainerHorizontal.Size = new System.Drawing.Size(925, 325);
            this.splitContainerHorizontal.SplitterDistance = 308;
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
            this.splitContainerVertical.Size = new System.Drawing.Size(308, 325);
            this.splitContainerVertical.SplitterDistance = 102;
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
            this.listBoxNewsgroups.Size = new System.Drawing.Size(308, 102);
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
            this.listBoxArticleHeaders.Size = new System.Drawing.Size(308, 219);
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
            this.textBoxArticleText.Size = new System.Drawing.Size(613, 325);
            this.textBoxArticleText.TabIndex = 0;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.onlineToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(990, 24);
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
            // NewsReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 498);
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
    }
}

