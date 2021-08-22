namespace FWVTool.Views
{
	partial class Home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.mtNPR = new MetroFramework.Controls.MetroTile();
			this.mtProfile = new MetroFramework.Controls.MetroTile();
			this.mtIUD = new MetroFramework.Controls.MetroTile();
			this.mtOCP = new MetroFramework.Controls.MetroTile();
			this.mtICP = new MetroFramework.Controls.MetroTile();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.btnBack = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// mtNPR
			// 
			this.mtNPR.ActiveControl = null;
			this.mtNPR.Location = new System.Drawing.Point(400, 132);
			this.mtNPR.Name = "mtNPR";
			this.mtNPR.Size = new System.Drawing.Size(169, 103);
			this.mtNPR.TabIndex = 2;
			this.mtNPR.Text = "Normal Patient Register";
			this.mtNPR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtNPR.UseSelectable = true;
			this.mtNPR.Click += new System.EventHandler(this.mtNPR_Click);
			// 
			// mtProfile
			// 
			this.mtProfile.ActiveControl = null;
			this.mtProfile.Location = new System.Drawing.Point(3, 18);
			this.mtProfile.Name = "mtProfile";
			this.mtProfile.Size = new System.Drawing.Size(97, 77);
			this.mtProfile.TabIndex = 3;
			this.mtProfile.Text = "My Profile";
			this.mtProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mtProfile.UseSelectable = true;
			this.mtProfile.Click += new System.EventHandler(this.mtProfile_Click);
			// 
			// mtIUD
			// 
			this.mtIUD.ActiveControl = null;
			this.mtIUD.Location = new System.Drawing.Point(269, 131);
			this.mtIUD.Name = "mtIUD";
			this.mtIUD.Size = new System.Drawing.Size(125, 104);
			this.mtIUD.TabIndex = 4;
			this.mtIUD.Text = "IUD Register";
			this.mtIUD.UseSelectable = true;
			this.mtIUD.Click += new System.EventHandler(this.mtIUD_Click);
			// 
			// mtOCP
			// 
			this.mtOCP.ActiveControl = null;
			this.mtOCP.Location = new System.Drawing.Point(269, 241);
			this.mtOCP.Name = "mtOCP";
			this.mtOCP.Size = new System.Drawing.Size(125, 104);
			this.mtOCP.TabIndex = 5;
			this.mtOCP.Text = "OCP Register";
			this.mtOCP.UseSelectable = true;
			this.mtOCP.Click += new System.EventHandler(this.mtOCP_Click);
			// 
			// mtICP
			// 
			this.mtICP.ActiveControl = null;
			this.mtICP.Location = new System.Drawing.Point(269, 352);
			this.mtICP.Name = "mtICP";
			this.mtICP.Size = new System.Drawing.Size(211, 104);
			this.mtICP.TabIndex = 6;
			this.mtICP.Text = "Injectable Contraceptive Register";
			this.mtICP.UseSelectable = true;
			this.mtICP.Click += new System.EventHandler(this.mtICP_Click);
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.BackColor = System.Drawing.Color.Bisque;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(335, 37);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(73, 16);
			this.lblWelcome.TabIndex = 8;
			this.lblWelcome.Text = "Welcome";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.BackColor = System.Drawing.Color.Bisque;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(405, 37);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(41, 16);
			this.lblUser.TabIndex = 8;
			this.lblUser.Text = "User";
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnBack.Location = new System.Drawing.Point(793, 64);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(35, 36);
			this.btnBack.TabIndex = 9;
			this.btnBack.UseSelectable = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 464);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.mtICP);
			this.Controls.Add(this.mtOCP);
			this.Controls.Add(this.mtIUD);
			this.Controls.Add(this.mtProfile);
			this.Controls.Add(this.mtNPR);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Home";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroTile mtNPR;
		private MetroFramework.Controls.MetroTile mtProfile;
		private MetroFramework.Controls.MetroTile mtIUD;
		private MetroFramework.Controls.MetroTile mtOCP;
		private MetroFramework.Controls.MetroTile mtICP;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label lblUser;
		private MetroFramework.Controls.MetroButton btnBack;
	}
}