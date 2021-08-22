namespace FWVTool.Views
{
	partial class ShowMedicine
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMedicine));
			this.txtType = new System.Windows.Forms.TextBox();
			this.txtMedName = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dgvMedicine = new System.Windows.Forms.DataGridView();
			this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBack = new System.Windows.Forms.Button();
			this.txtSerial = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
			this.SuspendLayout();
			// 
			// txtType
			// 
			this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtType.Location = new System.Drawing.Point(82, 67);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(181, 22);
			this.txtType.TabIndex = 0;
			// 
			// txtMedName
			// 
			this.txtMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMedName.Location = new System.Drawing.Point(82, 110);
			this.txtMedName.Name = "txtMedName";
			this.txtMedName.Size = new System.Drawing.Size(181, 22);
			this.txtMedName.TabIndex = 0;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantity.Location = new System.Drawing.Point(82, 155);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(181, 22);
			this.txtQuantity.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Qunatity";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(369, 154);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(194, 22);
			this.textBox4.TabIndex = 0;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(294, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Search";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(368, 64);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(73, 67);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(490, 64);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(73, 67);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dgvMedicine
			// 
			this.dgvMedicine.AllowUserToAddRows = false;
			this.dgvMedicine.AllowUserToDeleteRows = false;
			this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial,
            this.type,
            this.medName,
            this.quantity});
			this.dgvMedicine.Location = new System.Drawing.Point(5, 186);
			this.dgvMedicine.Name = "dgvMedicine";
			this.dgvMedicine.ReadOnly = true;
			this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMedicine.Size = new System.Drawing.Size(644, 325);
			this.dgvMedicine.TabIndex = 3;
			this.dgvMedicine.DoubleClick += new System.EventHandler(this.dgvMedicine_DoubleClick);
			// 
			// serial
			// 
			this.serial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.serial.DataPropertyName = "serial";
			this.serial.HeaderText = "Serial";
			this.serial.Name = "serial";
			this.serial.ReadOnly = true;
			// 
			// type
			// 
			this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.type.DataPropertyName = "type";
			this.type.HeaderText = "Type";
			this.type.Name = "type";
			this.type.ReadOnly = true;
			// 
			// medName
			// 
			this.medName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.medName.DataPropertyName = "medName";
			this.medName.HeaderText = "Name";
			this.medName.Name = "medName";
			this.medName.ReadOnly = true;
			// 
			// quantity
			// 
			this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.quantity.DataPropertyName = "quantity";
			this.quantity.HeaderText = "Quantity";
			this.quantity.Name = "quantity";
			this.quantity.ReadOnly = true;
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = global::FWVTool.Properties.Resources.Go_back_icon1;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnBack.Location = new System.Drawing.Point(604, 1);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(45, 42);
			this.btnBack.TabIndex = 2;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// txtSerial
			// 
			this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerial.Location = new System.Drawing.Point(82, 24);
			this.txtSerial.Name = "txtSerial";
			this.txtSerial.ReadOnly = true;
			this.txtSerial.Size = new System.Drawing.Size(181, 22);
			this.txtSerial.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Serial";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(366, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Total";
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(437, 27);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(126, 22);
			this.txtTotal.TabIndex = 0;
			// 
			// ShowMedicine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(652, 514);
			this.Controls.Add(this.dgvMedicine);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtMedName);
			this.Controls.Add(this.txtSerial);
			this.Controls.Add(this.txtType);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ShowMedicine";
			this.Text = "ShowMedicine";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowMedicine_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.TextBox txtMedName;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridView dgvMedicine;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.DataGridViewTextBoxColumn serial;
		private System.Windows.Forms.DataGridViewTextBoxColumn type;
		private System.Windows.Forms.DataGridViewTextBoxColumn medName;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
		private System.Windows.Forms.TextBox txtSerial;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTotal;
	}
}