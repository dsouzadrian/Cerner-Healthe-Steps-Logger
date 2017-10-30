namespace Cerner_Healthe_Steps_Logger
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.failLab = new System.Windows.Forms.Label();
            this.loginBt = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passLab = new System.Windows.Forms.Label();
            this.userLab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // failLab
            // 
            this.failLab.AutoSize = true;
            this.failLab.ForeColor = System.Drawing.Color.Red;
            this.failLab.Location = new System.Drawing.Point(12, 123);
            this.failLab.Name = "failLab";
            this.failLab.Size = new System.Drawing.Size(193, 13);
            this.failLab.TabIndex = 13;
            this.failLab.Text = "Authentication Failed, Please try again !";
            this.failLab.Visible = false;
            // 
            // loginBt
            // 
            this.loginBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBt.Location = new System.Drawing.Point(6, 113);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(266, 23);
            this.loginBt.TabIndex = 3;
            this.loginBt.Text = "Login to Cerner Health";
            this.loginBt.UseVisualStyleBackColor = true;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTextBox.Location = new System.Drawing.Point(81, 66);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(191, 20);
            this.passTextBox.TabIndex = 2;
            this.passTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTextBox_KeyDown);
            // 
            // userTextBox
            // 
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTextBox.Location = new System.Drawing.Point(81, 29);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(191, 20);
            this.userTextBox.TabIndex = 1;
            // 
            // passLab
            // 
            this.passLab.AutoSize = true;
            this.passLab.Location = new System.Drawing.Point(6, 68);
            this.passLab.Name = "passLab";
            this.passLab.Size = new System.Drawing.Size(59, 13);
            this.passLab.TabIndex = 10;
            this.passLab.Text = "Password :";
            // 
            // userLab
            // 
            this.userLab.AutoSize = true;
            this.userLab.Location = new System.Drawing.Point(6, 31);
            this.userLab.Name = "userLab";
            this.userLab.Size = new System.Drawing.Size(63, 13);
            this.userLab.TabIndex = 8;
            this.userLab.Text = "UserName :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 94);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cerner Healthe Steps Logger";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userLab);
            this.groupBox1.Controls.Add(this.passLab);
            this.groupBox1.Controls.Add(this.userTextBox);
            this.groupBox1.Controls.Add(this.passTextBox);
            this.groupBox1.Controls.Add(this.loginBt);
            this.groupBox1.Location = new System.Drawing.Point(15, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 142);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login with Cerner Health";
            // 
            // loginLab
            // 
            this.loginLab.AutoSize = true;
            this.loginLab.ForeColor = System.Drawing.Color.Green;
            this.loginLab.Location = new System.Drawing.Point(12, 123);
            this.loginLab.Name = "loginLab";
            this.loginLab.Size = new System.Drawing.Size(85, 13);
            this.loginLab.TabIndex = 17;
            this.loginLab.Text = "Logging you in...";
            this.loginLab.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 293);
            this.Controls.Add(this.loginLab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.failLab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Text = "login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label failLab;
        private System.Windows.Forms.Button loginBt;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label passLab;
        private System.Windows.Forms.Label userLab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label loginLab;
    }
}