namespace FWVTool.Views
{
	partial class InjectableExisting
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvConPatn = new System.Windows.Forms.DataGridView();
			this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VisitingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSave = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAutoSearch = new System.Windows.Forms.TextBox();
			this.txtICEName = new System.Windows.Forms.TextBox();
			this.txtICERegNo = new System.Windows.Forms.TextBox();
			this.dtpICENextDate = new System.Windows.Forms.DateTimePicker();
			this.dtpICEPreviousS = new System.Windows.Forms.DateTimePicker();
			this.dtpICES = new System.Windows.Forms.DateTimePicker();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConPatn)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel2.Controls.Add(this.dgvConPatn);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtAutoSearch);
			this.panel2.Controls.Add(this.txtICEName);
			this.panel2.Controls.Add(this.txtICERegNo);
			this.panel2.Controls.Add(this.dtpICENextDate);
			this.panel2.Controls.Add(this.dtpICEPreviousS);
			this.panel2.Controls.Add(this.dtpICES);
			this.panel2.Location = new System.Drawing.Point(1, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(570, 464);
			this.panel2.TabIndex = 6;
			// 
			// dgvConPatn
			// 
			this.dgvConPatn.AllowUserToAddRows = false;
			this.dgvConPatn.AllowUserToDeleteRows = false;
			this.dgvConPatn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConPatn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegNo,
            this.name,
            this.Date,
            this.VisitingDate});
			this.dgvConPatn.Location = new System.Drawing.Point(0, 264);
			this.dgvConPatn.Name = "dgvConPatn";
			this.dgvConPatn.ReadOnly = true;
			this.dgvConPatn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvConPatn.Size = new System.Drawing.Size(570, 200);
			this.dgvConPatn.TabIndex = 9;
			this.dgvConPatn.DoubleClick += new System.EventHandler(this.dgvConPatn_DoubleClick);
			// 
			// RegNo
			// 
			this.RegNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.RegNo.DataPropertyName = "regNo";
			this.RegNo.HeaderText = "Reg. No";
			this.RegNo.Name = "RegNo";
			this.RegNo.ReadOnly = true;
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.DataPropertyName = "name";
			this.name.HeaderText = "Name";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Date.DataPropertyName = "date";
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			// 
			// VisitingDate
			// 
			this.VisitingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.VisitingDate.DataPropertyName = "visitingDate";
			this.VisitingDate.HeaderText = "Visiting Date";
			this.VisitingDate.Name = "VisitingDate";
			this.VisitingDate.ReadOnly = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(375, 46);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(73, 70);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Linen;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(235, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "Existing Patient";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Previous Visiting Date";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 231);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Next Visiting Date";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(436, 202);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Search";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(4, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Reg. No";
			// 
			// txtAutoSearch
			// 
			this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAutoSearch.Location = new System.Drawing.Point(364, 221);
			this.txtAutoSearch.Name = "txtAutoSearch";
			this.txtAutoSearch.Size = new System.Drawing.Size(193, 26);
			this.txtAutoSearch.TabIndex = 5;
			this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
			// 
			// txtICEName
			// 
			this.txtICEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtICEName.Location = new System.Drawing.Point(147, 90);
			this.txtICEName.Name = "txtICEName";
			this.txtICEName.Size = new System.Drawing.Size(193, 26);
			this.txtICEName.TabIndex = 1;
			// 
			// txtICERegNo
			// 
			this.txtICERegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtICERegNo.Location = new System.Drawing.Point(147, 47);
			this.txtICERegNo.Name = "txtICERegNo";
			this.txtICERegNo.ReadOnly = true;
			this.txtICERegNo.Size = new System.Drawing.Size(193, 26);
			this.txtICERegNo.TabIndex = 0;
			// 
			// dtpICENextDate
			// 
			this.dtpICENextDate.CustomFormat = "yyyy-MM-dd";
			this.dtpICENextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpICENextDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpICENextDate.Location = new System.Drawing.Point(147, 223);
			this.dtpICENextDate.Name = "dtpICENextDate";
			this.dtpICENextDate.Size = new System.Drawing.Size(193, 26);
			this.dtpICENextDate.TabIndex = 4;
			// 
			// dtpICEPreviousS
			// 
			this.dtpICEPreviousS.CustomFormat = "yyyy-MM-dd";
			this.dtpICEPreviousS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpICEPreviousS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpICEPreviousS.Location = new System.Drawing.Point(147, 178);
			this.dtpICEPreviousS.Name = "dtpICEPreviousS";
			this.dtpICEPreviousS.Size = new System.Drawing.Size(193, 26);
			this.dtpICEPreviousS.TabIndex = 3;
			// 
			// dtpICES
			// 
			this.dtpICES.CustomFormat = "yyyy-MM-dd";
			this.dtpICES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpICES.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpICES.Location = new System.Drawing.Point(147, 134);
			this.dtpICES.Name = "dtpICES";
			this.dtpICES.Size = new System.Drawing.Size(193, 26);
			this.dtpICES.TabIndex = 2;
			// 
			// InjectableExisting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Name = "InjectableExisting";
			this.Size = new System.Drawing.Size(571, 467);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConPatn)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtICEName;
		private System.Windows.Forms.TextBox txtICERegNo;
		private System.Windows.Forms.DateTimePicker dtpICENextDate;
		private System.Windows.Forms.DateTimePicker dtpICEPreviousS;
		private System.Windows.Forms.DateTimePicker dtpICES;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView dgvConPatn;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAutoSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn VisitingDate;
	}
}
