namespace FWVTool.Views
{
	partial class MyProfile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
			this.btnEdit = new System.Windows.Forms.Button();
			this.txtPassword = new MetroFramework.Controls.MetroTextBox();
			this.txtEmail = new MetroFramework.Controls.MetroTextBox();
			this.txtMoblie = new MetroFramework.Controls.MetroTextBox();
			this.txtFullName = new MetroFramework.Controls.MetroTextBox();
			this.txtUserName = new MetroFramework.Controls.MetroTextBox();
			this.txtUserId = new MetroFramework.Controls.MetroTextBox();
			this.btnBack = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(264, 379);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(264, 31);
			this.btnEdit.TabIndex = 15;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// txtPassword
			// 
			// 
			// 
			// 
			this.txtPassword.CustomButton.Image = null;
			this.txtPassword.CustomButton.Location = new System.Drawing.Point(242, 1);
			this.txtPassword.CustomButton.Name = "";
			this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPassword.CustomButton.TabIndex = 1;
			this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPassword.CustomButton.UseSelectable = true;
			this.txtPassword.CustomButton.Visible = false;
			this.txtPassword.Lines = new string[0];
			this.txtPassword.Location = new System.Drawing.Point(264, 315);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PromptText = "Password";
			this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.ShortcutsEnabled = true;
			this.txtPassword.Size = new System.Drawing.Size(264, 23);
			this.txtPassword.TabIndex = 13;
			this.txtPassword.UseSelectable = true;
			this.txtPassword.WaterMark = "Password";
			this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtEmail
			// 
			// 
			// 
			// 
			this.txtEmail.CustomButton.Image = null;
			this.txtEmail.CustomButton.Location = new System.Drawing.Point(242, 1);
			this.txtEmail.CustomButton.Name = "";
			this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtEmail.CustomButton.TabIndex = 1;
			this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtEmail.CustomButton.UseSelectable = true;
			this.txtEmail.CustomButton.Visible = false;
			this.txtEmail.Lines = new string[0];
			this.txtEmail.Location = new System.Drawing.Point(264, 273);
			this.txtEmail.MaxLength = 32767;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.PromptText = "Email";
			this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtEmail.SelectedText = "";
			this.txtEmail.SelectionLength = 0;
			this.txtEmail.SelectionStart = 0;
			this.txtEmail.ShortcutsEnabled = true;
			this.txtEmail.Size = new System.Drawing.Size(264, 23);
			this.txtEmail.TabIndex = 12;
			this.txtEmail.UseSelectable = true;
			this.txtEmail.WaterMark = "Email";
			this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtMoblie
			// 
			// 
			// 
			// 
			this.txtMoblie.CustomButton.Image = null;
			this.txtMoblie.CustomButton.Location = new System.Drawing.Point(242, 1);
			this.txtMoblie.CustomButton.Name = "";
			this.txtMoblie.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtMoblie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtMoblie.CustomButton.TabIndex = 1;
			this.txtMoblie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtMoblie.CustomButton.UseSelectable = true;
			this.txtMoblie.CustomButton.Visible = false;
			this.txtMoblie.Lines = new string[0];
			this.txtMoblie.Location = new System.Drawing.Point(264, 232);
			this.txtMoblie.MaxLength = 32767;
			this.txtMoblie.Name = "txtMoblie";
			this.txtMoblie.PasswordChar = '\0';
			this.txtMoblie.PromptText = "Mobile No.";
			this.txtMoblie.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMoblie.SelectedText = "";
			this.txtMoblie.SelectionLength = 0;
			this.txtMoblie.SelectionStart = 0;
			this.txtMoblie.ShortcutsEnabled = true;
			this.txtMoblie.Size = new System.Drawing.Size(264, 23);
			this.txtMoblie.TabIndex = 11;
			this.txtMoblie.UseSelectable = true;
			this.txtMoblie.WaterMark = "Mobile No.";
			this.txtMoblie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtMoblie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtFullName
			// 
			// 
			// 
			// 
			this.txtFullName.CustomButton.Image = null;
			this.txtFullName.CustomButton.Location = new System.Drawing.Point(242, 1);
			this.txtFullName.CustomButton.Name = "";
			this.txtFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtFullName.CustomButton.TabIndex = 1;
			this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtFullName.CustomButton.UseSelectable = true;
			this.txtFullName.CustomButton.Visible = false;
			this.txtFullName.Lines = new string[0];
			this.txtFullName.Location = new System.Drawing.Point(264, 192);
			this.txtFullName.MaxLength = 32767;
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.PasswordChar = '\0';
			this.txtFullName.PromptText = "FullName";
			this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtFullName.SelectedText = "";
			this.txtFullName.SelectionLength = 0;
			this.txtFullName.SelectionStart = 0;
			this.txtFullName.ShortcutsEnabled = true;
			this.txtFullName.Size = new System.Drawing.Size(264, 23);
			this.txtFullName.TabIndex = 10;
			this.txtFullName.UseSelectable = true;
			this.txtFullName.WaterMark = "FullName";
			this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtUserName
			// 
			// 
			// 
			// 
			this.txtUserName.CustomButton.Image = null;
			this.txtUserName.CustomButton.Location = new System.Drawing.Point(242, 1);
			this.txtUserName.CustomButton.Name = "";
			this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUserName.CustomButton.TabIndex = 1;
			this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUserName.CustomButton.UseSelectable = true;
			this.txtUserName.CustomButton.Visible = false;
			this.txtUserName.Lines = new string[0];
			this.txtUserName.Location = new System.Drawing.Point(264, 153);
			this.txtUserName.MaxLength = 32767;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.PasswordChar = '\0';
			this.txtUserName.PromptText = "UserName";
			this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUserName.SelectedText = "";
			this.txtUserName.SelectionLength = 0;
			this.txtUserName.SelectionStart = 0;
			this.txtUserName.ShortcutsEnabled = true;
			this.txtUserName.Size = new System.Drawing.Size(264, 23);
			this.txtUserName.TabIndex = 9;
			this.txtUserName.UseSelectable = true;
			this.txtUserName.WaterMark = "UserName";
			this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtUserId
			// 
			// 
			// 
			// 
			this.txtUserId.CustomButton.Image = null;
			this.txtUserId.CustomButton.Location = new System.Drawing.Point(242, 1);
			this.txtUserId.CustomButton.Name = "";
			this.txtUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUserId.CustomButton.TabIndex = 1;
			this.txtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUserId.CustomButton.UseSelectable = true;
			this.txtUserId.CustomButton.Visible = false;
			this.txtUserId.Lines = new string[0];
			this.txtUserId.Location = new System.Drawing.Point(264, 112);
			this.txtUserId.MaxLength = 32767;
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.PasswordChar = '\0';
			this.txtUserId.PromptText = "User Id";
			this.txtUserId.ReadOnly = true;
			this.txtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUserId.SelectedText = "";
			this.txtUserId.SelectionLength = 0;
			this.txtUserId.SelectionStart = 0;
			this.txtUserId.ShortcutsEnabled = true;
			this.txtUserId.Size = new System.Drawing.Size(264, 23);
			this.txtUserId.TabIndex = 8;
			this.txtUserId.UseSelectable = true;
			this.txtUserId.WaterMark = "User Id";
			this.txtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = global::FWVTool.Properties.Resources.Go_back_icon1;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnBack.Location = new System.Drawing.Point(757, 49);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(41, 39);
			this.btnBack.TabIndex = 16;
			this.btnBack.UseSelectable = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// MyProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtMoblie);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.txtUserId);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MyProfile";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyProfile_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEdit;
		private MetroFramework.Controls.MetroTextBox txtPassword;
		private MetroFramework.Controls.MetroTextBox txtEmail;
		private MetroFramework.Controls.MetroTextBox txtMoblie;
		private MetroFramework.Controls.MetroTextBox txtFullName;
		private MetroFramework.Controls.MetroTextBox txtUserName;
		private MetroFramework.Controls.MetroTextBox txtUserId;
		private MetroFramework.Controls.MetroButton btnBack;
	}
}