namespace FWVTool.Views
{
	partial class IUDRegister
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUDRegister));
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlDetach = new System.Windows.Forms.Panel();
			this.dtpIUDDetach = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIUDName = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtIUDRegNo = new System.Windows.Forms.TextBox();
			this.dtpIUD = new System.Windows.Forms.DateTimePicker();
			this.txtIUDAddress = new System.Windows.Forms.TextBox();
			this.txtIUDConName = new System.Windows.Forms.TextBox();
			this.txtIUDAllow = new System.Windows.Forms.TextBox();
			this.txtIUDAge = new System.Windows.Forms.TextBox();
			this.pnlDGV = new System.Windows.Forms.Panel();
			this.dgvIUD = new System.Windows.Forms.DataGridView();
			this.regNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IUDname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DetachDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.txtAutoSearch = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.pnlDetach.SuspendLayout();
			this.pnlDGV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvIUD)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel2.Controls.Add(this.pnlDetach);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtIUDName);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.txtIUDRegNo);
			this.panel2.Controls.Add(this.dtpIUD);
			this.panel2.Controls.Add(this.txtIUDAddress);
			this.panel2.Controls.Add(this.txtIUDConName);
			this.panel2.Controls.Add(this.txtIUDAllow);
			this.panel2.Controls.Add(this.txtIUDAge);
			this.panel2.Location = new System.Drawing.Point(0, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(294, 422);
			this.panel2.TabIndex = 5;
			// 
			// pnlDetach
			// 
			this.pnlDetach.BackColor = System.Drawing.Color.Bisque;
			this.pnlDetach.Controls.Add(this.dtpIUDDetach);
			this.pnlDetach.Controls.Add(this.label2);
			this.pnlDetach.Location = new System.Drawing.Point(3, 376);
			this.pnlDetach.Name = "pnlDetach";
			this.pnlDetach.Size = new System.Drawing.Size(288, 40);
			this.pnlDetach.TabIndex = 6;
			this.pnlDetach.Visible = false;
			// 
			// dtpIUDDetach
			// 
			this.dtpIUDDetach.CustomFormat = "yyyy-MM-dd";
			this.dtpIUDDetach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpIUDDetach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpIUDDetach.Location = new System.Drawing.Point(91, 11);
			this.dtpIUDDetach.Name = "dtpIUDDetach";
			this.dtpIUDDetach.Size = new System.Drawing.Size(193, 26);
			this.dtpIUDDetach.TabIndex = 7;
			this.dtpIUDDetach.Value = new System.DateTime(2019, 12, 16, 1, 43, 44, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Detach Date";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(3, 352);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "Contraceptive";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 309);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Allowance";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 265);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Age";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 213);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Address";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Reg. No";
			// 
			// txtIUDName
			// 
			this.txtIUDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIUDName.Location = new System.Drawing.Point(94, 163);
			this.txtIUDName.Name = "txtIUDName";
			this.txtIUDName.Size = new System.Drawing.Size(193, 26);
			this.txtIUDName.TabIndex = 2;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Bisque;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Red;
			this.label17.Location = new System.Drawing.Point(8, 11);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(150, 20);
			this.label17.TabIndex = 0;
			this.label17.Text = "Basic Information";
			// 
			// txtIUDRegNo
			// 
			this.txtIUDRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIUDRegNo.Location = new System.Drawing.Point(94, 75);
			this.txtIUDRegNo.Name = "txtIUDRegNo";
			this.txtIUDRegNo.ReadOnly = true;
			this.txtIUDRegNo.Size = new System.Drawing.Size(193, 26);
			this.txtIUDRegNo.TabIndex = 0;
			// 
			// dtpIUD
			// 
			this.dtpIUD.CustomFormat = "yyyy-MM-dd";
			this.dtpIUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpIUD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpIUD.Location = new System.Drawing.Point(94, 122);
			this.dtpIUD.Name = "dtpIUD";
			this.dtpIUD.Size = new System.Drawing.Size(193, 26);
			this.dtpIUD.TabIndex = 1;
			// 
			// txtIUDAddress
			// 
			this.txtIUDAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIUDAddress.Location = new System.Drawing.Point(94, 207);
			this.txtIUDAddress.Name = "txtIUDAddress";
			this.txtIUDAddress.Size = new System.Drawing.Size(193, 26);
			this.txtIUDAddress.TabIndex = 3;
			// 
			// txtIUDConName
			// 
			this.txtIUDConName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIUDConName.Location = new System.Drawing.Point(94, 344);
			this.txtIUDConName.Name = "txtIUDConName";
			this.txtIUDConName.ReadOnly = true;
			this.txtIUDConName.Size = new System.Drawing.Size(193, 26);
			this.txtIUDConName.TabIndex = 6;
			this.txtIUDConName.Text = "IUD";
			// 
			// txtIUDAllow
			// 
			this.txtIUDAllow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIUDAllow.Location = new System.Drawing.Point(94, 301);
			this.txtIUDAllow.Name = "txtIUDAllow";
			this.txtIUDAllow.ReadOnly = true;
			this.txtIUDAllow.Size = new System.Drawing.Size(193, 26);
			this.txtIUDAllow.TabIndex = 5;
			this.txtIUDAllow.Text = "250";
			// 
			// txtIUDAge
			// 
			this.txtIUDAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIUDAge.Location = new System.Drawing.Point(94, 259);
			this.txtIUDAge.Name = "txtIUDAge";
			this.txtIUDAge.Size = new System.Drawing.Size(193, 26);
			this.txtIUDAge.TabIndex = 4;
			// 
			// pnlDGV
			// 
			this.pnlDGV.BackColor = System.Drawing.Color.Thistle;
			this.pnlDGV.Controls.Add(this.dgvIUD);
			this.pnlDGV.Controls.Add(this.btnSave);
			this.pnlDGV.Controls.Add(this.btnBack);
			this.pnlDGV.Controls.Add(this.txtAutoSearch);
			this.pnlDGV.Controls.Add(this.label8);
			this.pnlDGV.Location = new System.Drawing.Point(300, 1);
			this.pnlDGV.Name = "pnlDGV";
			this.pnlDGV.Size = new System.Drawing.Size(493, 422);
			this.pnlDGV.TabIndex = 6;
			// 
			// dgvIUD
			// 
			this.dgvIUD.AllowUserToAddRows = false;
			this.dgvIUD.AllowUserToDeleteRows = false;
			this.dgvIUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIUD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNo,
            this.date,
            this.IUDname,
            this.DetachDate});
			this.dgvIUD.Location = new System.Drawing.Point(6, 119);
			this.dgvIUD.Name = "dgvIUD";
			this.dgvIUD.ReadOnly = true;
			this.dgvIUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvIUD.Size = new System.Drawing.Size(482, 300);
			this.dgvIUD.TabIndex = 6;
			this.dgvIUD.DoubleClick += new System.EventHandler(this.dgvIUD_DoubleClick);
			// 
			// regNo
			// 
			this.regNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.regNo.DataPropertyName = "regNo";
			this.regNo.HeaderText = "Rag. No";
			this.regNo.Name = "regNo";
			this.regNo.ReadOnly = true;
			// 
			// date
			// 
			this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.date.DataPropertyName = "date";
			this.date.HeaderText = "Date";
			this.date.Name = "date";
			this.date.ReadOnly = true;
			// 
			// IUDname
			// 
			this.IUDname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.IUDname.DataPropertyName = "IUDname";
			this.IUDname.HeaderText = "Name";
			this.IUDname.Name = "IUDname";
			this.IUDname.ReadOnly = true;
			// 
			// DetachDate
			// 
			this.DetachDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DetachDate.DataPropertyName = "DetachDate";
			this.DetachDate.HeaderText = "Detach Date";
			this.DetachDate.Name = "DetachDate";
			this.DetachDate.ReadOnly = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(383, 62);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(81, 46);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = global::FWVTool.Properties.Resources.Go_back_icon1;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnBack.Location = new System.Drawing.Point(444, 8);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(44, 37);
			this.btnBack.TabIndex = 10;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// txtAutoSearch
			// 
			this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAutoSearch.Location = new System.Drawing.Point(88, 71);
			this.txtAutoSearch.Name = "txtAutoSearch";
			this.txtAutoSearch.Size = new System.Drawing.Size(193, 26);
			this.txtAutoSearch.TabIndex = 8;
			this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "Search";
			// 
			// IUDRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(793, 422);
			this.Controls.Add(this.pnlDGV);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "IUDRegister";
			this.Text = "IUDRegister";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IUDRegister_FormClosing);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnlDetach.ResumeLayout(false);
			this.pnlDetach.PerformLayout();
			this.pnlDGV.ResumeLayout(false);
			this.pnlDGV.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvIUD)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIUDName;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtIUDRegNo;
		private System.Windows.Forms.DateTimePicker dtpIUD;
		private System.Windows.Forms.TextBox txtIUDAddress;
		private System.Windows.Forms.TextBox txtIUDAge;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIUDAllow;
		private System.Windows.Forms.Panel pnlDetach;
		private System.Windows.Forms.DateTimePicker dtpIUDDetach;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnlDGV;
		private System.Windows.Forms.DataGridView dgvIUD;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.TextBox txtAutoSearch;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtIUDConName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridViewTextBoxColumn regNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn date;
		private System.Windows.Forms.DataGridViewTextBoxColumn IUDname;
		private System.Windows.Forms.DataGridViewTextBoxColumn DetachDate;
	}
}