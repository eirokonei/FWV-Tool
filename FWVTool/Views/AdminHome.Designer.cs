namespace FWVTool.Views
{
	partial class AdminHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
			this.mtOCPDatabase = new MetroFramework.Controls.MetroTile();
			this.mtMedicine = new MetroFramework.Controls.MetroTile();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.mtIUDData = new MetroFramework.Controls.MetroTile();
			this.mtConData = new MetroFramework.Controls.MetroTile();
			this.mtICData = new MetroFramework.Controls.MetroTile();
			this.mtNPData = new MetroFramework.Controls.MetroTile();
			this.mtUser = new MetroFramework.Controls.MetroTile();
			this.btnLogOut = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// mtOCPDatabase
			// 
			this.mtOCPDatabase.ActiveControl = null;
			this.mtOCPDatabase.Location = new System.Drawing.Point(23, 171);
			this.mtOCPDatabase.Name = "mtOCPDatabase";
			this.mtOCPDatabase.Size = new System.Drawing.Size(153, 104);
			this.mtOCPDatabase.TabIndex = 10;
			this.mtOCPDatabase.Text = "OCP Database";
			this.mtOCPDatabase.UseSelectable = true;
			this.mtOCPDatabase.Click += new System.EventHandler(this.mtOCPDatabase_Click);
			// 
			// mtMedicine
			// 
			this.mtMedicine.ActiveControl = null;
			this.mtMedicine.Location = new System.Drawing.Point(23, 45);
			this.mtMedicine.Name = "mtMedicine";
			this.mtMedicine.Size = new System.Drawing.Size(82, 104);
			this.mtMedicine.TabIndex = 11;
			this.mtMedicine.Text = "Medicines";
			this.mtMedicine.UseSelectable = true;
			this.mtMedicine.Click += new System.EventHandler(this.mtMedicine_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.BackColor = System.Drawing.Color.Bisque;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(361, 21);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(51, 16);
			this.lblUser.TabIndex = 12;
			this.lblUser.Text = "Admin";
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.BackColor = System.Drawing.Color.Bisque;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(291, 21);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(73, 16);
			this.lblWelcome.TabIndex = 13;
			this.lblWelcome.Text = "Welcome";
			// 
			// mtIUDData
			// 
			this.mtIUDData.ActiveControl = null;
			this.mtIUDData.Location = new System.Drawing.Point(184, 295);
			this.mtIUDData.Name = "mtIUDData";
			this.mtIUDData.Size = new System.Drawing.Size(169, 103);
			this.mtIUDData.TabIndex = 14;
			this.mtIUDData.Text = "IUD Database";
			this.mtIUDData.UseSelectable = true;
			this.mtIUDData.Click += new System.EventHandler(this.mtIUDData_Click);
			// 
			// mtConData
			// 
			this.mtConData.ActiveControl = null;
			this.mtConData.Location = new System.Drawing.Point(184, 171);
			this.mtConData.Name = "mtConData";
			this.mtConData.Size = new System.Drawing.Size(169, 104);
			this.mtConData.TabIndex = 16;
			this.mtConData.Text = "Contraceptive Database";
			this.mtConData.UseSelectable = true;
			this.mtConData.Click += new System.EventHandler(this.mtConData_Click);
			// 
			// mtICData
			// 
			this.mtICData.ActiveControl = null;
			this.mtICData.Location = new System.Drawing.Point(378, 171);
			this.mtICData.Name = "mtICData";
			this.mtICData.Size = new System.Drawing.Size(179, 104);
			this.mtICData.TabIndex = 17;
			this.mtICData.Text = "Injectable Con. Database";
			this.mtICData.UseSelectable = true;
			this.mtICData.Click += new System.EventHandler(this.mtICData_Click);
			// 
			// mtNPData
			// 
			this.mtNPData.ActiveControl = null;
			this.mtNPData.Location = new System.Drawing.Point(558, 295);
			this.mtNPData.Name = "mtNPData";
			this.mtNPData.Size = new System.Drawing.Size(160, 103);
			this.mtNPData.TabIndex = 18;
			this.mtNPData.Text = "Normal Patient Data";
			this.mtNPData.UseSelectable = true;
			this.mtNPData.Click += new System.EventHandler(this.mtNPData_Click);
			// 
			// mtUser
			// 
			this.mtUser.ActiveControl = null;
			this.mtUser.Location = new System.Drawing.Point(596, 171);
			this.mtUser.Name = "mtUser";
			this.mtUser.Size = new System.Drawing.Size(122, 104);
			this.mtUser.TabIndex = 19;
			this.mtUser.Text = "User Database";
			this.mtUser.UseSelectable = true;
			this.mtUser.Click += new System.EventHandler(this.mtUser_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
			this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnLogOut.Location = new System.Drawing.Point(756, 45);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(35, 37);
			this.btnLogOut.TabIndex = 15;
			this.btnLogOut.UseSelectable = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// AdminHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mtUser);
			this.Controls.Add(this.mtNPData);
			this.Controls.Add(this.mtICData);
			this.Controls.Add(this.mtConData);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.mtIUDData);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.mtMedicine);
			this.Controls.Add(this.mtOCPDatabase);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AdminHome";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTile mtOCPDatabase;
		private MetroFramework.Controls.MetroTile mtMedicine;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblWelcome;
		private MetroFramework.Controls.MetroTile mtIUDData;
		private MetroFramework.Controls.MetroButton btnLogOut;
		private MetroFramework.Controls.MetroTile mtConData;
		private MetroFramework.Controls.MetroTile mtICData;
		private MetroFramework.Controls.MetroTile mtNPData;
		private MetroFramework.Controls.MetroTile mtUser;
	}
}