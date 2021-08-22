namespace FWVTool.Views

{
	partial class NormalPR
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormalPR));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBack = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label18 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.btnNPRSave = new System.Windows.Forms.Button();
			this.txtMedSearch = new System.Windows.Forms.TextBox();
			this.txtMedQua = new System.Windows.Forms.TextBox();
			this.txtMedName = new System.Windows.Forms.TextBox();
			this.dgvMedicine = new System.Windows.Forms.DataGridView();
			this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label14 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.pnlNPREdema = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.rbNPREdemaYes = new System.Windows.Forms.RadioButton();
			this.rbNPREdemaNo = new System.Windows.Forms.RadioButton();
			this.pnlNPRJaun = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.rbNPRJaunYes = new System.Windows.Forms.RadioButton();
			this.rbNPRJaunNo = new System.Windows.Forms.RadioButton();
			this.txtNPRBodyTemp = new System.Windows.Forms.TextBox();
			this.txtNPRPulstation = new System.Windows.Forms.TextBox();
			this.pnlNPRBlood = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.rbNPRBloodDYes = new System.Windows.Forms.RadioButton();
			this.rbNPRBloodDNo = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNPRName = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.rtbNPRProblem = new System.Windows.Forms.RichTextBox();
			this.txtNPRRegNo = new System.Windows.Forms.TextBox();
			this.dtpNPS = new System.Windows.Forms.DateTimePicker();
			this.txtNPRAddress = new System.Windows.Forms.TextBox();
			this.txtNPRAge = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
			this.panel3.SuspendLayout();
			this.pnlNPREdema.SuspendLayout();
			this.pnlNPRJaun.SuspendLayout();
			this.pnlNPRBlood.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(3, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(948, 526);
			this.panel1.TabIndex = 0;
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = global::FWVTool.Properties.Resources.Go_back_icon1;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnBack.Location = new System.Drawing.Point(897, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(45, 46);
			this.btnBack.TabIndex = 14;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.btnNPRSave);
			this.panel4.Controls.Add(this.txtMedSearch);
			this.panel4.Controls.Add(this.txtMedQua);
			this.panel4.Controls.Add(this.txtMedName);
			this.panel4.Controls.Add(this.dgvMedicine);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Location = new System.Drawing.Point(671, 57);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(271, 466);
			this.panel4.TabIndex = 5;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(13, 161);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(47, 13);
			this.label18.TabIndex = 4;
			this.label18.Text = "Search";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(13, 118);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(54, 13);
			this.label16.TabIndex = 4;
			this.label16.Text = "Quantity";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(13, 75);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(87, 16);
			this.label15.TabIndex = 4;
			this.label15.Text = "Med. Name";
			// 
			// btnNPRSave
			// 
			this.btnNPRSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNPRSave.Location = new System.Drawing.Point(100, 429);
			this.btnNPRSave.Name = "btnNPRSave";
			this.btnNPRSave.Size = new System.Drawing.Size(75, 34);
			this.btnNPRSave.TabIndex = 4;
			this.btnNPRSave.Text = "Save";
			this.btnNPRSave.UseVisualStyleBackColor = true;
			this.btnNPRSave.Click += new System.EventHandler(this.btnNPRSave_Click);
			// 
			// txtMedSearch
			// 
			this.txtMedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMedSearch.Location = new System.Drawing.Point(100, 156);
			this.txtMedSearch.Name = "txtMedSearch";
			this.txtMedSearch.Size = new System.Drawing.Size(149, 22);
			this.txtMedSearch.TabIndex = 13;
			this.txtMedSearch.TextChanged += new System.EventHandler(this.txtMedSearch_TextChanged);
			// 
			// txtMedQua
			// 
			this.txtMedQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMedQua.Location = new System.Drawing.Point(100, 117);
			this.txtMedQua.Name = "txtMedQua";
			this.txtMedQua.Size = new System.Drawing.Size(149, 22);
			this.txtMedQua.TabIndex = 12;
			// 
			// txtMedName
			// 
			this.txtMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMedName.Location = new System.Drawing.Point(100, 74);
			this.txtMedName.Name = "txtMedName";
			this.txtMedName.Size = new System.Drawing.Size(149, 22);
			this.txtMedName.TabIndex = 11;
			// 
			// dgvMedicine
			// 
			this.dgvMedicine.AllowUserToAddRows = false;
			this.dgvMedicine.AllowUserToDeleteRows = false;
			this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medName,
            this.Quantity});
			this.dgvMedicine.Location = new System.Drawing.Point(13, 184);
			this.dgvMedicine.Name = "dgvMedicine";
			this.dgvMedicine.ReadOnly = true;
			this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMedicine.Size = new System.Drawing.Size(240, 227);
			this.dgvMedicine.TabIndex = 1;
			this.dgvMedicine.DoubleClick += new System.EventHandler(this.dgvMedicine_DoubleClick);
			// 
			// medName
			// 
			this.medName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.medName.DataPropertyName = "medName";
			this.medName.FillWeight = 120F;
			this.medName.HeaderText = "Name";
			this.medName.Name = "medName";
			this.medName.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Quantity.DataPropertyName = "quantity";
			this.Quantity.FillWeight = 55F;
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Bisque;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(9, 23);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(129, 20);
			this.label14.TabIndex = 0;
			this.label14.Text = "Apply Medicine";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.pnlNPREdema);
			this.panel3.Controls.Add(this.pnlNPRJaun);
			this.panel3.Controls.Add(this.txtNPRBodyTemp);
			this.panel3.Controls.Add(this.txtNPRPulstation);
			this.panel3.Controls.Add(this.pnlNPRBlood);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(300, 57);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(365, 466);
			this.panel3.TabIndex = 4;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(7, 124);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(137, 16);
			this.label13.TabIndex = 3;
			this.label13.Text = "Body Temperature";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(7, 83);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(76, 16);
			this.label12.TabIndex = 3;
			this.label12.Text = "Pulstation";
			// 
			// pnlNPREdema
			// 
			this.pnlNPREdema.BackColor = System.Drawing.Color.Bisque;
			this.pnlNPREdema.Controls.Add(this.label11);
			this.pnlNPREdema.Controls.Add(this.rbNPREdemaYes);
			this.pnlNPREdema.Controls.Add(this.rbNPREdemaNo);
			this.pnlNPREdema.Location = new System.Drawing.Point(9, 337);
			this.pnlNPREdema.Name = "pnlNPREdema";
			this.pnlNPREdema.Size = new System.Drawing.Size(197, 70);
			this.pnlNPREdema.TabIndex = 10;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(3, 13);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(57, 16);
			this.label11.TabIndex = 3;
			this.label11.Text = "Edema";
			// 
			// rbNPREdemaYes
			// 
			this.rbNPREdemaYes.AutoSize = true;
			this.rbNPREdemaYes.Location = new System.Drawing.Point(147, 12);
			this.rbNPREdemaYes.Name = "rbNPREdemaYes";
			this.rbNPREdemaYes.Size = new System.Drawing.Size(43, 17);
			this.rbNPREdemaYes.TabIndex = 1;
			this.rbNPREdemaYes.TabStop = true;
			this.rbNPREdemaYes.Text = "Yes";
			this.rbNPREdemaYes.UseVisualStyleBackColor = true;
			this.rbNPREdemaYes.CheckedChanged += new System.EventHandler(this.rbNPREdemaYes_CheckedChanged);
			// 
			// rbNPREdemaNo
			// 
			this.rbNPREdemaNo.AutoSize = true;
			this.rbNPREdemaNo.Location = new System.Drawing.Point(147, 39);
			this.rbNPREdemaNo.Name = "rbNPREdemaNo";
			this.rbNPREdemaNo.Size = new System.Drawing.Size(39, 17);
			this.rbNPREdemaNo.TabIndex = 2;
			this.rbNPREdemaNo.TabStop = true;
			this.rbNPREdemaNo.Text = "No";
			this.rbNPREdemaNo.UseVisualStyleBackColor = true;
			this.rbNPREdemaNo.CheckedChanged += new System.EventHandler(this.rbNPREdemaNo_CheckedChanged);
			// 
			// pnlNPRJaun
			// 
			this.pnlNPRJaun.BackColor = System.Drawing.Color.Linen;
			this.pnlNPRJaun.Controls.Add(this.label10);
			this.pnlNPRJaun.Controls.Add(this.rbNPRJaunYes);
			this.pnlNPRJaun.Controls.Add(this.rbNPRJaunNo);
			this.pnlNPRJaun.Location = new System.Drawing.Point(10, 259);
			this.pnlNPRJaun.Name = "pnlNPRJaun";
			this.pnlNPRJaun.Size = new System.Drawing.Size(196, 70);
			this.pnlNPRJaun.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 16);
			this.label10.TabIndex = 3;
			this.label10.Text = "Jaundice";
			// 
			// rbNPRJaunYes
			// 
			this.rbNPRJaunYes.AutoSize = true;
			this.rbNPRJaunYes.Location = new System.Drawing.Point(146, 12);
			this.rbNPRJaunYes.Name = "rbNPRJaunYes";
			this.rbNPRJaunYes.Size = new System.Drawing.Size(43, 17);
			this.rbNPRJaunYes.TabIndex = 1;
			this.rbNPRJaunYes.TabStop = true;
			this.rbNPRJaunYes.Text = "Yes";
			this.rbNPRJaunYes.UseVisualStyleBackColor = true;
			this.rbNPRJaunYes.CheckedChanged += new System.EventHandler(this.rbNPRJaunYes_CheckedChanged);
			// 
			// rbNPRJaunNo
			// 
			this.rbNPRJaunNo.AutoSize = true;
			this.rbNPRJaunNo.Location = new System.Drawing.Point(146, 35);
			this.rbNPRJaunNo.Name = "rbNPRJaunNo";
			this.rbNPRJaunNo.Size = new System.Drawing.Size(39, 17);
			this.rbNPRJaunNo.TabIndex = 2;
			this.rbNPRJaunNo.TabStop = true;
			this.rbNPRJaunNo.Text = "No";
			this.rbNPRJaunNo.UseVisualStyleBackColor = true;
			this.rbNPRJaunNo.CheckedChanged += new System.EventHandler(this.rbNPRJaunNo_CheckedChanged);
			// 
			// txtNPRBodyTemp
			// 
			this.txtNPRBodyTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNPRBodyTemp.Location = new System.Drawing.Point(149, 117);
			this.txtNPRBodyTemp.Name = "txtNPRBodyTemp";
			this.txtNPRBodyTemp.Size = new System.Drawing.Size(200, 26);
			this.txtNPRBodyTemp.TabIndex = 7;
			// 
			// txtNPRPulstation
			// 
			this.txtNPRPulstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNPRPulstation.Location = new System.Drawing.Point(149, 73);
			this.txtNPRPulstation.Name = "txtNPRPulstation";
			this.txtNPRPulstation.Size = new System.Drawing.Size(200, 26);
			this.txtNPRPulstation.TabIndex = 6;
			// 
			// pnlNPRBlood
			// 
			this.pnlNPRBlood.BackColor = System.Drawing.Color.Bisque;
			this.pnlNPRBlood.Controls.Add(this.label9);
			this.pnlNPRBlood.Controls.Add(this.rbNPRBloodDYes);
			this.pnlNPRBlood.Controls.Add(this.rbNPRBloodDNo);
			this.pnlNPRBlood.Location = new System.Drawing.Point(10, 183);
			this.pnlNPRBlood.Name = "pnlNPRBlood";
			this.pnlNPRBlood.Size = new System.Drawing.Size(196, 70);
			this.pnlNPRBlood.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(2, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(126, 16);
			this.label9.TabIndex = 3;
			this.label9.Text = "Blood Deficiency";
			// 
			// rbNPRBloodDYes
			// 
			this.rbNPRBloodDYes.AutoSize = true;
			this.rbNPRBloodDYes.Location = new System.Drawing.Point(146, 11);
			this.rbNPRBloodDYes.Name = "rbNPRBloodDYes";
			this.rbNPRBloodDYes.Size = new System.Drawing.Size(43, 17);
			this.rbNPRBloodDYes.TabIndex = 1;
			this.rbNPRBloodDYes.TabStop = true;
			this.rbNPRBloodDYes.Text = "Yes";
			this.rbNPRBloodDYes.UseVisualStyleBackColor = true;
			this.rbNPRBloodDYes.CheckedChanged += new System.EventHandler(this.rbNPRBloodDYes_CheckedChanged);
			// 
			// rbNPRBloodDNo
			// 
			this.rbNPRBloodDNo.AutoSize = true;
			this.rbNPRBloodDNo.Location = new System.Drawing.Point(146, 34);
			this.rbNPRBloodDNo.Name = "rbNPRBloodDNo";
			this.rbNPRBloodDNo.Size = new System.Drawing.Size(39, 17);
			this.rbNPRBloodDNo.TabIndex = 2;
			this.rbNPRBloodDNo.TabStop = true;
			this.rbNPRBloodDNo.Text = "No";
			this.rbNPRBloodDNo.UseVisualStyleBackColor = true;
			this.rbNPRBloodDNo.CheckedChanged += new System.EventHandler(this.rbNPRBloodDNo_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Bisque;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Physical Test";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtNPRName);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.rtbNPRProblem);
			this.panel2.Controls.Add(this.txtNPRRegNo);
			this.panel2.Controls.Add(this.dtpNPS);
			this.panel2.Controls.Add(this.txtNPRAddress);
			this.panel2.Controls.Add(this.txtNPRAge);
			this.panel2.Location = new System.Drawing.Point(0, 57);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(294, 466);
			this.panel2.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(9, 338);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 16);
			this.label8.TabIndex = 5;
			this.label8.Text = "Problem";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(9, 265);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Age";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(9, 213);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Address";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Reg. No";
			// 
			// txtNPRName
			// 
			this.txtNPRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNPRName.Location = new System.Drawing.Point(81, 163);
			this.txtNPRName.Name = "txtNPRName";
			this.txtNPRName.Size = new System.Drawing.Size(193, 26);
			this.txtNPRName.TabIndex = 2;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Bisque;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Red;
			this.label17.Location = new System.Drawing.Point(8, 23);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(150, 20);
			this.label17.TabIndex = 0;
			this.label17.Text = "Basic Information";
			// 
			// rtbNPRProblem
			// 
			this.rtbNPRProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbNPRProblem.Location = new System.Drawing.Point(81, 309);
			this.rtbNPRProblem.Name = "rtbNPRProblem";
			this.rtbNPRProblem.Size = new System.Drawing.Size(193, 96);
			this.rtbNPRProblem.TabIndex = 5;
			this.rtbNPRProblem.Text = "";
			// 
			// txtNPRRegNo
			// 
			this.txtNPRRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNPRRegNo.Location = new System.Drawing.Point(81, 75);
			this.txtNPRRegNo.Name = "txtNPRRegNo";
			this.txtNPRRegNo.ReadOnly = true;
			this.txtNPRRegNo.Size = new System.Drawing.Size(193, 26);
			this.txtNPRRegNo.TabIndex = 0;
			// 
			// dtpNPS
			// 
			this.dtpNPS.CustomFormat = "yyyy-MM-dd";
			this.dtpNPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNPS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNPS.Location = new System.Drawing.Point(81, 122);
			this.dtpNPS.Name = "dtpNPS";
			this.dtpNPS.Size = new System.Drawing.Size(193, 26);
			this.dtpNPS.TabIndex = 1;
			// 
			// txtNPRAddress
			// 
			this.txtNPRAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNPRAddress.Location = new System.Drawing.Point(81, 207);
			this.txtNPRAddress.Name = "txtNPRAddress";
			this.txtNPRAddress.Size = new System.Drawing.Size(193, 26);
			this.txtNPRAddress.TabIndex = 3;
			// 
			// txtNPRAge
			// 
			this.txtNPRAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNPRAge.Location = new System.Drawing.Point(81, 259);
			this.txtNPRAge.Name = "txtNPRAge";
			this.txtNPRAge.Size = new System.Drawing.Size(193, 26);
			this.txtNPRAge.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Bisque;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(375, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Normal Patient Register";
			// 
			// NormalPR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 528);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NormalPR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NormalPR";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NormalPR_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.pnlNPREdema.ResumeLayout(false);
			this.pnlNPREdema.PerformLayout();
			this.pnlNPRJaun.ResumeLayout(false);
			this.pnlNPRJaun.PerformLayout();
			this.pnlNPRBlood.ResumeLayout(false);
			this.pnlNPRBlood.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rbNPRBloodDNo;
		private System.Windows.Forms.RadioButton rbNPRBloodDYes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtNPRName;
		private System.Windows.Forms.RichTextBox rtbNPRProblem;
		private System.Windows.Forms.TextBox txtNPRRegNo;
		private System.Windows.Forms.DateTimePicker dtpNPS;
		private System.Windows.Forms.TextBox txtNPRAddress;
		private System.Windows.Forms.TextBox txtNPRAge;
		private System.Windows.Forms.Panel pnlNPREdema;
		private System.Windows.Forms.RadioButton rbNPREdemaYes;
		private System.Windows.Forms.RadioButton rbNPREdemaNo;
		private System.Windows.Forms.Panel pnlNPRJaun;
		private System.Windows.Forms.RadioButton rbNPRJaunYes;
		private System.Windows.Forms.RadioButton rbNPRJaunNo;
		private System.Windows.Forms.TextBox txtNPRBodyTemp;
		private System.Windows.Forms.TextBox txtNPRPulstation;
		private System.Windows.Forms.Panel pnlNPRBlood;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnNPRSave;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtMedQua;
		private System.Windows.Forms.TextBox txtMedName;
		private System.Windows.Forms.DataGridView dgvMedicine;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtMedSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn medName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.Button btnBack;
	}
}