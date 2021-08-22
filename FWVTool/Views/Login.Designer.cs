namespace FWVTool.Views
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblForgot = new System.Windows.Forms.Label();
			this.txtUserName = new MetroFramework.Controls.MetroTextBox();
			this.txtPassword = new MetroFramework.Controls.MetroTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblSignUp = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnLogin);
			this.groupBox1.Controls.Add(this.lblForgot);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(364, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(483, 240);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(137, 120);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(200, 27);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Log In";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblForgot
			// 
			this.lblForgot.AutoSize = true;
			this.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblForgot.Location = new System.Drawing.Point(189, 171);
			this.lblForgot.Name = "lblForgot";
			this.lblForgot.Size = new System.Drawing.Size(106, 15);
			this.lblForgot.TabIndex = 3;
			this.lblForgot.Text = "Forgot Password?";
			this.lblForgot.Click += new System.EventHandler(this.lblForgot_Click);
			// 
			// txtUserName
			// 
			// 
			// 
			// 
			this.txtUserName.CustomButton.Image = null;
			this.txtUserName.CustomButton.Location = new System.Drawing.Point(172, 1);
			this.txtUserName.CustomButton.Name = "";
			this.txtUserName.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUserName.CustomButton.TabIndex = 1;
			this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUserName.CustomButton.UseSelectable = true;
			this.txtUserName.CustomButton.Visible = false;
			this.txtUserName.Lines = new string[0];
			this.txtUserName.Location = new System.Drawing.Point(137, 28);
			this.txtUserName.MaxLength = 32767;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.PasswordChar = '\0';
			this.txtUserName.PromptText = "User Name";
			this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUserName.SelectedText = "";
			this.txtUserName.SelectionLength = 0;
			this.txtUserName.SelectionStart = 0;
			this.txtUserName.ShortcutsEnabled = true;
			this.txtUserName.Size = new System.Drawing.Size(200, 29);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.UseSelectable = true;
			this.txtUserName.WaterMark = "User Name";
			this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// txtPassword
			// 
			// 
			// 
			// 
			this.txtPassword.CustomButton.Image = null;
			this.txtPassword.CustomButton.Location = new System.Drawing.Point(172, 1);
			this.txtPassword.CustomButton.Name = "";
			this.txtPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPassword.CustomButton.TabIndex = 1;
			this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPassword.CustomButton.UseSelectable = true;
			this.txtPassword.CustomButton.Visible = false;
			this.txtPassword.Lines = new string[0];
			this.txtPassword.Location = new System.Drawing.Point(137, 75);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '●';
			this.txtPassword.PromptText = "Password";
			this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.ShortcutsEnabled = true;
			this.txtPassword.Size = new System.Drawing.Size(200, 29);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSelectable = true;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.WaterMark = "Password";
			this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Bisque;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(424, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(336, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "FAMILY WELFARE VISITOR TOOL";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.lblSignUp);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(365, 309);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 151);
			this.panel1.TabIndex = 3;
			// 
			// lblSignUp
			// 
			this.lblSignUp.AutoSize = true;
			this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
			this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSignUp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblSignUp.Location = new System.Drawing.Point(269, 48);
			this.lblSignUp.Name = "lblSignUp";
			this.lblSignUp.Size = new System.Drawing.Size(63, 16);
			this.lblSignUp.TabIndex = 4;
			this.lblSignUp.Text = "Sign Up";
			this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label3.Location = new System.Drawing.Point(123, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Don\'t have an account?";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(359, 453);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 464);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.Style = MetroFramework.MetroColorStyle.Default;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private MetroFramework.Controls.MetroTextBox txtUserName;
		private MetroFramework.Controls.MetroTextBox txtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblForgot;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSignUp;
		private System.Windows.Forms.Label label3;
	}
}