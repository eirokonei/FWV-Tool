namespace FWVTool.Views
{
	partial class OCP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCP));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cmbPillName = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOCPName = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtOCPRegNo = new System.Windows.Forms.TextBox();
			this.dtpOCP = new System.Windows.Forms.DateTimePicker();
			this.txtOCPAddress = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtOCPChild = new System.Windows.Forms.TextBox();
			this.txtOCPAge = new System.Windows.Forms.TextBox();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel2.Controls.Add(this.btnBack);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.cmbPillName);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtOCPName);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.txtOCPRegNo);
			this.panel2.Controls.Add(this.dtpOCP);
			this.panel2.Controls.Add(this.txtOCPAddress);
			this.panel2.Controls.Add(this.txtQuantity);
			this.panel2.Controls.Add(this.txtOCPChild);
			this.panel2.Controls.Add(this.txtOCPAge);
			this.panel2.Location = new System.Drawing.Point(2, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(796, 450);
			this.panel2.TabIndex = 6;
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
			this.btnBack.Location = new System.Drawing.Point(739, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(54, 52);
			this.btnBack.TabIndex = 9;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(396, 408);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 39);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cmbPillName
			// 
			this.cmbPillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPillName.FormattingEnabled = true;
			this.cmbPillName.Items.AddRange(new object[] {
            "Shukhi",
            "i-Pill",
            "Peuli",
            "Norix",
            "Norpill"});
			this.cmbPillName.Location = new System.Drawing.Point(331, 326);
			this.cmbPillName.Name = "cmbPillName";
			this.cmbPillName.Size = new System.Drawing.Size(193, 24);
			this.cmbPillName.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(240, 384);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Quantity";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(240, 335);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "Pill Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(240, 292);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Child";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(240, 248);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Age";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(240, 196);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Address";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(240, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(240, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(240, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Reg. No";
			// 
			// txtOCPName
			// 
			this.txtOCPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOCPName.Location = new System.Drawing.Point(331, 146);
			this.txtOCPName.Name = "txtOCPName";
			this.txtOCPName.Size = new System.Drawing.Size(193, 26);
			this.txtOCPName.TabIndex = 2;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Bisque;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Red;
			this.label17.Location = new System.Drawing.Point(329, 17);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(195, 20);
			this.label17.TabIndex = 0;
			this.label17.Text = "Oral Contraceptive Pills";
			// 
			// txtOCPRegNo
			// 
			this.txtOCPRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOCPRegNo.Location = new System.Drawing.Point(331, 58);
			this.txtOCPRegNo.Name = "txtOCPRegNo";
			this.txtOCPRegNo.ReadOnly = true;
			this.txtOCPRegNo.Size = new System.Drawing.Size(193, 26);
			this.txtOCPRegNo.TabIndex = 0;
			// 
			// dtpOCP
			// 
			this.dtpOCP.CustomFormat = "yyyy-MM-dd";
			this.dtpOCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpOCP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpOCP.Location = new System.Drawing.Point(331, 105);
			this.dtpOCP.Name = "dtpOCP";
			this.dtpOCP.Size = new System.Drawing.Size(193, 26);
			this.dtpOCP.TabIndex = 1;
			// 
			// txtOCPAddress
			// 
			this.txtOCPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOCPAddress.Location = new System.Drawing.Point(331, 190);
			this.txtOCPAddress.Name = "txtOCPAddress";
			this.txtOCPAddress.Size = new System.Drawing.Size(193, 26);
			this.txtOCPAddress.TabIndex = 3;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantity.Location = new System.Drawing.Point(331, 376);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(193, 26);
			this.txtQuantity.TabIndex = 7;
			// 
			// txtOCPChild
			// 
			this.txtOCPChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOCPChild.Location = new System.Drawing.Point(331, 284);
			this.txtOCPChild.Name = "txtOCPChild";
			this.txtOCPChild.Size = new System.Drawing.Size(193, 26);
			this.txtOCPChild.TabIndex = 5;
			// 
			// txtOCPAge
			// 
			this.txtOCPAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOCPAge.Location = new System.Drawing.Point(331, 242);
			this.txtOCPAge.Name = "txtOCPAge";
			this.txtOCPAge.Size = new System.Drawing.Size(193, 26);
			this.txtOCPAge.TabIndex = 4;
			// 
			// OCP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OCP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OCP";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OCP_FormClosing);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOCPName;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtOCPRegNo;
		private System.Windows.Forms.DateTimePicker dtpOCP;
		private System.Windows.Forms.TextBox txtOCPAddress;
		private System.Windows.Forms.TextBox txtOCPChild;
		private System.Windows.Forms.TextBox txtOCPAge;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cmbPillName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtQuantity;
	}
}