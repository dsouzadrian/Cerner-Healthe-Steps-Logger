namespace Cerner_Healthe_Steps_Logger
{
    partial class healtheLogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(healtheLogger));
            this.ApiLabName = new System.Windows.Forms.Label();
            this.fileSelect = new System.Windows.Forms.Button();
            this.fileNameText = new System.Windows.Forms.TextBox();
            this.apiLogSteps = new System.Windows.Forms.Button();
            this.processMsgPanel = new System.Windows.Forms.Panel();
            this.processMsgLab = new System.Windows.Forms.Label();
            this.processProgBar = new System.Windows.Forms.ProgressBar();
            this.apkPic = new System.Windows.Forms.PictureBox();
            this.totalPoints = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pointsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bufferStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bufferLab = new System.Windows.Forms.Label();
            this.apiSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.apiTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loggedGrpBox = new System.Windows.Forms.GroupBox();
            this.matchedDataBox = new System.Windows.Forms.DataGridView();
            this.unLoggedGrpBox = new System.Windows.Forms.GroupBox();
            this.unMatchedDataBox = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showChromeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugModeOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processMsgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apkPic)).BeginInit();
            this.pointsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bufferStepsNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.loggedGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchedDataBox)).BeginInit();
            this.unLoggedGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unMatchedDataBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApiLabName
            // 
            this.ApiLabName.AutoSize = true;
            this.ApiLabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApiLabName.Location = new System.Drawing.Point(3, 61);
            this.ApiLabName.Name = "ApiLabName";
            this.ApiLabName.Size = new System.Drawing.Size(141, 20);
            this.ApiLabName.TabIndex = 0;
            this.ApiLabName.Text = "Upload your Data :";
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(194, 84);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(75, 23);
            this.fileSelect.TabIndex = 3;
            this.fileSelect.Text = "Select File";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileNameText
            // 
            this.fileNameText.Enabled = false;
            this.fileNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameText.Location = new System.Drawing.Point(7, 86);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(181, 20);
            this.fileNameText.TabIndex = 2;
            // 
            // apiLogSteps
            // 
            this.apiLogSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiLogSteps.Location = new System.Drawing.Point(7, 142);
            this.apiLogSteps.Name = "apiLogSteps";
            this.apiLogSteps.Size = new System.Drawing.Size(293, 33);
            this.apiLogSteps.TabIndex = 5;
            this.apiLogSteps.Text = "Fetch Data";
            this.apiLogSteps.UseVisualStyleBackColor = true;
            this.apiLogSteps.Click += new System.EventHandler(this.apiLogSteps_Click);
            // 
            // processMsgPanel
            // 
            this.processMsgPanel.Controls.Add(this.processMsgLab);
            this.processMsgPanel.Controls.Add(this.processProgBar);
            this.processMsgPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.processMsgPanel.Location = new System.Drawing.Point(0, 662);
            this.processMsgPanel.Name = "processMsgPanel";
            this.processMsgPanel.Size = new System.Drawing.Size(539, 38);
            this.processMsgPanel.TabIndex = 5;
            // 
            // processMsgLab
            // 
            this.processMsgLab.AutoSize = true;
            this.processMsgLab.Location = new System.Drawing.Point(4, 5);
            this.processMsgLab.Name = "processMsgLab";
            this.processMsgLab.Size = new System.Drawing.Size(0, 13);
            this.processMsgLab.TabIndex = 1;
            // 
            // processProgBar
            // 
            this.processProgBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.processProgBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.processProgBar.Location = new System.Drawing.Point(0, 26);
            this.processProgBar.Name = "processProgBar";
            this.processProgBar.Size = new System.Drawing.Size(539, 12);
            this.processProgBar.TabIndex = 0;
            // 
            // apkPic
            // 
            this.apkPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apkPic.Image = ((System.Drawing.Image)(resources.GetObject("apkPic.Image")));
            this.apkPic.Location = new System.Drawing.Point(338, 3);
            this.apkPic.Name = "apkPic";
            this.apkPic.Size = new System.Drawing.Size(198, 137);
            this.apkPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apkPic.TabIndex = 7;
            this.apkPic.TabStop = false;
            // 
            // totalPoints
            // 
            this.totalPoints.AutoSize = true;
            this.totalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPoints.ForeColor = System.Drawing.SystemColors.Highlight;
            this.totalPoints.Location = new System.Drawing.Point(3, 3);
            this.totalPoints.Name = "totalPoints";
            this.totalPoints.Size = new System.Drawing.Size(171, 20);
            this.totalPoints.TabIndex = 11;
            this.totalPoints.Text = "Total Available Points : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(539, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Log Steps";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pointsPanel
            // 
            this.pointsPanel.Controls.Add(this.button1);
            this.pointsPanel.Controls.Add(this.totalPoints);
            this.pointsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pointsPanel.Location = new System.Drawing.Point(0, 586);
            this.pointsPanel.Name = "pointsPanel";
            this.pointsPanel.Size = new System.Drawing.Size(539, 76);
            this.pointsPanel.TabIndex = 13;
            this.pointsPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bufferStepsNumericUpDown);
            this.panel1.Controls.Add(this.bufferLab);
            this.panel1.Controls.Add(this.apiSelect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.apiTitle);
            this.panel1.Controls.Add(this.ApiLabName);
            this.panel1.Controls.Add(this.fileSelect);
            this.panel1.Controls.Add(this.apkPic);
            this.panel1.Controls.Add(this.fileNameText);
            this.panel1.Controls.Add(this.apiLogSteps);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 180);
            this.panel1.TabIndex = 7;
            // 
            // bufferStepsNumericUpDown
            // 
            this.bufferStepsNumericUpDown.Location = new System.Drawing.Point(117, 114);
            this.bufferStepsNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bufferStepsNumericUpDown.Name = "bufferStepsNumericUpDown";
            this.bufferStepsNumericUpDown.Size = new System.Drawing.Size(152, 20);
            this.bufferStepsNumericUpDown.TabIndex = 4;
            this.bufferStepsNumericUpDown.ValueChanged += new System.EventHandler(this.bufferStepsNumericUpDown_ValueChanged);
            this.bufferStepsNumericUpDown.Enter += new System.EventHandler(this.bufferStepsNumericUpDown_Enter);
            // 
            // bufferLab
            // 
            this.bufferLab.AutoSize = true;
            this.bufferLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bufferLab.Location = new System.Drawing.Point(3, 115);
            this.bufferLab.Name = "bufferLab";
            this.bufferLab.Size = new System.Drawing.Size(107, 20);
            this.bufferLab.TabIndex = 19;
            this.bufferLab.Text = "Buffer Steps :";
            // 
            // apiSelect
            // 
            this.apiSelect.FormattingEnabled = true;
            this.apiSelect.Items.AddRange(new object[] {
            "Google Fit",
            "Apple Health Kit"});
            this.apiSelect.Location = new System.Drawing.Point(7, 32);
            this.apiSelect.Name = "apiSelect";
            this.apiSelect.Size = new System.Drawing.Size(215, 21);
            this.apiSelect.TabIndex = 1;
            this.apiSelect.SelectedIndexChanged += new System.EventHandler(this.apiSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choose your Fitness Tracker :";
            // 
            // apiTitle
            // 
            this.apiTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apiTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiTitle.Location = new System.Drawing.Point(335, 143);
            this.apiTitle.Name = "apiTitle";
            this.apiTitle.Size = new System.Drawing.Size(201, 29);
            this.apiTitle.TabIndex = 16;
            this.apiTitle.Text = "Google Fit";
            this.apiTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.loggedGrpBox);
            this.panel2.Controls.Add(this.unLoggedGrpBox);
            this.panel2.Location = new System.Drawing.Point(0, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 375);
            this.panel2.TabIndex = 14;
            // 
            // loggedGrpBox
            // 
            this.loggedGrpBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loggedGrpBox.Controls.Add(this.matchedDataBox);
            this.loggedGrpBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loggedGrpBox.Location = new System.Drawing.Point(0, 185);
            this.loggedGrpBox.Name = "loggedGrpBox";
            this.loggedGrpBox.Size = new System.Drawing.Size(539, 190);
            this.loggedGrpBox.TabIndex = 12;
            this.loggedGrpBox.TabStop = false;
            this.loggedGrpBox.Text = "Steps already logged:";
            // 
            // matchedDataBox
            // 
            this.matchedDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchedDataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchedDataBox.Location = new System.Drawing.Point(6, 19);
            this.matchedDataBox.Name = "matchedDataBox";
            this.matchedDataBox.ReadOnly = true;
            this.matchedDataBox.Size = new System.Drawing.Size(527, 165);
            this.matchedDataBox.TabIndex = 6;
            // 
            // unLoggedGrpBox
            // 
            this.unLoggedGrpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unLoggedGrpBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unLoggedGrpBox.Controls.Add(this.unMatchedDataBox);
            this.unLoggedGrpBox.Location = new System.Drawing.Point(-1, 3);
            this.unLoggedGrpBox.Name = "unLoggedGrpBox";
            this.unLoggedGrpBox.Size = new System.Drawing.Size(539, 179);
            this.unLoggedGrpBox.TabIndex = 11;
            this.unLoggedGrpBox.TabStop = false;
            this.unLoggedGrpBox.Text = "Steps not yet logged :";
            // 
            // unMatchedDataBox
            // 
            this.unMatchedDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unMatchedDataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unMatchedDataBox.Location = new System.Drawing.Point(6, 19);
            this.unMatchedDataBox.Name = "unMatchedDataBox";
            this.unMatchedDataBox.ReadOnly = true;
            this.unMatchedDataBox.Size = new System.Drawing.Size(527, 154);
            this.unMatchedDataBox.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showChromeWindowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showChromeWindowToolStripMenuItem
            // 
            this.showChromeWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugModeOnToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.showChromeWindowToolStripMenuItem.Name = "showChromeWindowToolStripMenuItem";
            this.showChromeWindowToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.showChromeWindowToolStripMenuItem.Text = "File";
            // 
            // debugModeOnToolStripMenuItem
            // 
            this.debugModeOnToolStripMenuItem.Name = "debugModeOnToolStripMenuItem";
            this.debugModeOnToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.debugModeOnToolStripMenuItem.Text = "Toggle Debug Mode";
            this.debugModeOnToolStripMenuItem.Click += new System.EventHandler(this.debugModeOnToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // healtheLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pointsPanel);
            this.Controls.Add(this.processMsgPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(552, 657);
            this.Name = "healtheLogger";
            this.Text = "Cerner Healthe Steps Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.healtheLogger_FormClosing);
            this.processMsgPanel.ResumeLayout(false);
            this.processMsgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apkPic)).EndInit();
            this.pointsPanel.ResumeLayout(false);
            this.pointsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bufferStepsNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.loggedGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchedDataBox)).EndInit();
            this.unLoggedGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unMatchedDataBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApiLabName;
        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.TextBox fileNameText;
        private System.Windows.Forms.Button apiLogSteps;
        private System.Windows.Forms.Panel processMsgPanel;
        private System.Windows.Forms.Label processMsgLab;
        private System.Windows.Forms.ProgressBar processProgBar;
        private System.Windows.Forms.PictureBox apkPic;
        private System.Windows.Forms.Label totalPoints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pointsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox loggedGrpBox;
        private System.Windows.Forms.DataGridView matchedDataBox;
        private System.Windows.Forms.GroupBox unLoggedGrpBox;
        private System.Windows.Forms.DataGridView unMatchedDataBox;
        private System.Windows.Forms.ComboBox apiSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label apiTitle;
        private System.Windows.Forms.Label bufferLab;
        private System.Windows.Forms.NumericUpDown bufferStepsNumericUpDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showChromeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugModeOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

