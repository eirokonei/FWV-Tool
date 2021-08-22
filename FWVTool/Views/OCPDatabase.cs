using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using FWVTool.Data_Layer;

namespace FWVTool.Views
{
	public partial class OCPDatabase : MetroForm
	{
		string query { get; set; }
		public OCPDatabase()
		{
			InitializeComponent();
			this.PopulateGridView();
			this.txtTotal.Text = this.TotalQua().ToString();
		}

		private void OCPDatabase_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminHome hm = new AdminHome();
			hm.Show();
		}

		private void dgvOCPDatabase_DoubleClick(object sender, EventArgs e)
		{
			this.txtregNo.Text = this.dgvOCPDatabase.CurrentRow.Cells["regNo"].Value.ToString();
			this.dtpDate.Text= this.dgvOCPDatabase.CurrentRow.Cells["date"].Value.ToString();
			this.txtAddress.Text = this.dgvOCPDatabase.CurrentRow.Cells["address"].Value.ToString();
			this.txtAge.Text = this.dgvOCPDatabase.CurrentRow.Cells["age"].Value.ToString();
			this.txtChild.Text = this.dgvOCPDatabase.CurrentRow.Cells["child"].Value.ToString();
			this.txtConName.Text = this.dgvOCPDatabase.CurrentRow.Cells["conName"].Value.ToString();
			this.txtName.Text = this.dgvOCPDatabase.CurrentRow.Cells["OCPname"].Value.ToString();
			this.txtQuantity.Text = this.dgvOCPDatabase.CurrentRow.Cells["quantity"].Value.ToString();
			
		}
		private void PopulateGridView(string sql = @"select * from OCP;")
		{

			//var dt = DataAccess.GetDataTable(sql);
			this.dgvOCPDatabase.AutoGenerateColumns = false;
			this.dgvOCPDatabase.DataSource = DataAccess.GetDataTable(sql); ;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvOCPDatabase.SelectedRows.Count != 1)
				{
					MessageBox.Show("Please Select A Row First");
					return;
				}

				if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				string regNo = this.dgvOCPDatabase.CurrentRow.Cells["regNo"].Value.ToString();
				this.query = "select * from OCP where regNo = '" + regNo + "'";
				var dt = DataAccess.GetDataTable(this.query);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("Invalid.");
				}
				else
				{
					this.query = "ALTER TABLE OCP NOCHECK CONSTRAINT FK_OCP_Contraceptive";
					DataAccess.ExecuteQuery(this.query);
					this.query = "Delete from OCP where regNo = '" + regNo + "'; ";
					int count = DataAccess.ExecuteQuery(this.query);
					this.query = "ALTER TABLE OCP CHECK CONSTRAINT FK_OCP_Contraceptive";
					DataAccess.ExecuteQuery(this.query);
					if (count == 1)
					{
						MessageBox.Show("Delete Confirmed.");
						this.PopulateGridView();
						this.txtTotal.Text = this.TotalQua().ToString(); 
					}
					else
					{
						MessageBox.Show("Invalid Deletion.");
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.query = @"Update OCP set date='"+this.dtpDate.Text+"'," +
				" OCPname='"+this.txtName.Text+ "', address='"+this.txtAddress.Text+ "', age="+this.txtAge.Text+"," +
				" child="+this.txtChild.Text+ ", conName='"+this.txtConName.Text+ "', quantity="+this.txtQuantity.Text+"" +
				" where regNo='"+this.txtregNo.Text+"' ";
			int c = DataAccess.ExecuteQuery(this.query);
			if(c==1)
			{
				MessageBox.Show("Updated");
				this.PopulateGridView();
			}
			else
			{
				MessageBox.Show("Invalid");
			}
		}
		private int TotalQua()
		{
			this.query = "Select quantity from OCP";
			var dt = DataAccess.GetDataTable(this.query);
			int row = dt.Rows.Count;
			int c = 0;
			int total = 0;
			while (c<row)
			{
				total =total + int.Parse(dt.Rows[c][0].ToString());
				c++;
			}
			return total;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			this.query = @"select * from OCP where OCPname like '" + this.txtSearch.Text + "%';";
			this.PopulateGridView(this.query);
		}
	}
}
