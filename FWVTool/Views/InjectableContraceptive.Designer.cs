namespace FWVTool.Views
{
	partial class InjectableContraceptive
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InjectableContraceptive));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExisting = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.injectableExisting1 = new FWVTool.Views.InjectableExisting();
			this.injectableNew1 = new FWVTool.Views.InjectableNew();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.btnExisting);
			this.panel1.Controls.Add(this.btnNew);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(130, 475);
			this.panel1.TabIndex = 0;
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = global::FWVTool.Properties.Resources.Go_back_icon1;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnBack.Location = new System.Drawing.Point(85, 3);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(42, 40);
			this.btnBack.TabIndex = 2;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExisting
			// 
			this.btnExisting.Location = new System.Drawing.Point(29, 316);
			this.btnExisting.Name = "btnExisting";
			this.btnExisting.Size = new System.Drawing.Size(75, 89);
			this.btnExisting.TabIndex = 1;
			this.btnExisting.Text = "Existing";
			this.btnExisting.UseVisualStyleBackColor = true;
			this.btnExisting.Click += new System.EventHandler(this.btnExisting_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(29, 90);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 89);
			this.btnNew.TabIndex = 0;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.injectableExisting1);
			this.panel2.Controls.Add(this.injectableNew1);
			this.panel2.Location = new System.Drawing.Point(137, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(581, 475);
			this.panel2.TabIndex = 1;
			// 
			// injectableExisting1
			// 
			this.injectableExisting1.Location = new System.Drawing.Point(3, 3);
			this.injectableExisting1.Name = "injectableExisting1";
			this.injectableExisting1.Size = new System.Drawing.Size(571, 467);
			this.injectableExisting1.TabIndex = 1;
			this.injectableExisting1.Load += new System.EventHandler(this.injectableExisting1_Load);
			// 
			// injectableNew1
			// 
			this.injectableNew1.BackColor = System.Drawing.Color.Bisque;
			this.injectableNew1.Location = new System.Drawing.Point(3, 5);
			this.injectableNew1.Name = "injectableNew1";
			this.injectableNew1.Size = new System.Drawing.Size(571, 467);
			this.injectableNew1.TabIndex = 0;
			// 
			// InjectableContraceptive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 476);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "InjectableContraceptive";
			this.Text = "InjectableContraceptive";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InjectableContraceptive_FormClosing);
			this.Load += new System.EventHandler(this.InjectableContraceptive_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnExisting;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Panel panel2;
		private InjectableExisting injectableExisting1;
		private InjectableNew injectableNew1;
		private System.Windows.Forms.Button btnBack;
	}
}