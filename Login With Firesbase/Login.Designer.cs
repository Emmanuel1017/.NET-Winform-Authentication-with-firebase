namespace Login_Sample
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterButton = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.password = new ns1.BunifuMaterialTextbox();
            this.username = new ns1.BunifuMaterialTextbox();
            this.loginbtn = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.AutoLoginCheckbox = new ns1.BunifuCheckbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "şifre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 437);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterButton
            // 
            this.RegisterButton.ActiveBorderThickness = 1;
            this.RegisterButton.ActiveCornerRadius = 20;
            this.RegisterButton.ActiveFillColor = System.Drawing.Color.White;
            this.RegisterButton.ActiveForecolor = System.Drawing.Color.Black;
            this.RegisterButton.ActiveLineColor = System.Drawing.Color.White;
            this.RegisterButton.BackColor = System.Drawing.Color.Black;
            this.RegisterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.BackgroundImage")));
            this.RegisterButton.ButtonText = "REGISTER";
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.IdleBorderThickness = 1;
            this.RegisterButton.IdleCornerRadius = 20;
            this.RegisterButton.IdleFillColor = System.Drawing.Color.Black;
            this.RegisterButton.IdleForecolor = System.Drawing.Color.White;
            this.RegisterButton.IdleLineColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(37, 217);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(5);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(152, 50);
            this.RegisterButton.TabIndex = 26;
            this.RegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 169);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(147, 16);
            this.bunifuCustomLabel2.TabIndex = 27;
            this.bunifuCustomLabel2.Text = "Don\'t have an account?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.ForeColor = System.Drawing.Color.White;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.linkLabel2.Location = new System.Drawing.Point(622, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(26, 25);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "X";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(270, 67);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 23);
            this.bunifuCustomLabel1.TabIndex = 28;
            this.bunifuCustomLabel1.Text = "Login";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.DarkGray;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "Password";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.Black;
            this.password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.password.LineMouseHoverColor = System.Drawing.Color.Black;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(268, 166);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(358, 34);
            this.password.TabIndex = 27;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.username.HintForeColor = System.Drawing.Color.Gray;
            this.username.HintText = "Username";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.Black;
            this.username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.username.LineMouseHoverColor = System.Drawing.Color.Black;
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(268, 122);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(358, 34);
            this.username.TabIndex = 26;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginbtn
            // 
            this.loginbtn.ActiveBorderThickness = 1;
            this.loginbtn.ActiveCornerRadius = 20;
            this.loginbtn.ActiveFillColor = System.Drawing.Color.Black;
            this.loginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.loginbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.loginbtn.BackColor = System.Drawing.Color.White;
            this.loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbtn.BackgroundImage")));
            this.loginbtn.ButtonText = "SIGN IN";
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.loginbtn.IdleBorderThickness = 1;
            this.loginbtn.IdleCornerRadius = 20;
            this.loginbtn.IdleFillColor = System.Drawing.Color.White;
            this.loginbtn.IdleForecolor = System.Drawing.Color.Black;
            this.loginbtn.IdleLineColor = System.Drawing.Color.Black;
            this.loginbtn.Location = new System.Drawing.Point(268, 280);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(358, 50);
            this.loginbtn.TabIndex = 29;
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(300, 235);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(75, 13);
            this.bunifuCustomLabel3.TabIndex = 31;
            this.bunifuCustomLabel3.Text = "Remember me";
            // 
            // AutoLoginCheckbox
            // 
            this.AutoLoginCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.AutoLoginCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.AutoLoginCheckbox.Checked = false;
            this.AutoLoginCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.AutoLoginCheckbox.ForeColor = System.Drawing.Color.White;
            this.AutoLoginCheckbox.Location = new System.Drawing.Point(274, 233);
            this.AutoLoginCheckbox.Name = "AutoLoginCheckbox";
            this.AutoLoginCheckbox.Size = new System.Drawing.Size(20, 20);
            this.AutoLoginCheckbox.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 437);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.AutoLoginCheckbox);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(660, 437);
            this.MinimumSize = new System.Drawing.Size(660, 437);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private ns1.BunifuThinButton2 RegisterButton;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMaterialTextbox password;
        private ns1.BunifuMaterialTextbox username;
        private ns1.BunifuThinButton2 loginbtn;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCheckbox AutoLoginCheckbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}