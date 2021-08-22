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
	public partial class IUDDatabase : MetroForm
	{
		private string query { get; set; }
		public IUDDatabase()
		{
			InitializeComponent();
			this.PopulateGridView();
			this.txttotalallow.Text = this.TotalQua().ToString();
			this.txtTtlIUD.Text = this.TotalIUD().ToString();
		}

		private void IUDDatabase_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void mtDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvIUDDatabase.SelectedRows.Count != 1)
				{
					MessageBox.Show("Please Select A Row First");
					return;
				}

				if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				string regNo = this.dgvIUDDatabase.CurrentRow.Cells["regNo"].Value.ToString();
				this.query = "select * from IUDRegister where regNo = '" + regNo + "'";
				var dt = DataAccess.GetDataTable(this.query);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("Invalid.");
				}
				else
				{
					//this.query = "ALTER TABLE OCP NOCHECK CONSTRAINT FK_OCP_Contraceptive";
					//DataAccess.ExecuteQuery(this.query);
					this.query = "Delete from IUDRegister where regNo = '" + regNo + "'; ";
					int count = DataAccess.ExecuteQuery(this.query);
					/*this.query = "ALTER TABLE OCP CHECK CONSTRAINT FK_OCP_Contraceptive";
					DataAccess.ExecuteQuery(this.query);*/

					if (count == 1)
					{
						MessageBox.Show("Delete Confirmed.");
						this.PopulateGridView();
						this.UpdateIUDQuaFromCon();
						this.txttotalallow.Text = this.TotalQua().ToString();
						this.txtTtlIUD.Text = this.TotalIUD().ToString();
					}
					else
					{
						MessageBox.Show("Invalid Deletion.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void PopulateGridView(string sql = @"select * from IUDRegister;")
		{

			this.dgvIUDDatabase.AutoGenerateColumns = false;
			this.dgvIUDDatabase.DataSource = DataAccess.GetDataTable(sql); ;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminHome ad = new AdminHome();
			ad.Show();
		}

		private void mtSave_Click(object sender, EventArgs e)
		{
			this.query= @"Update IUDRegister set " +
								" date='" + this.dtpDate.Text + "', IUDname='" + this.txtName.Text + "', address='" + this.txtAddress.Text + "'," +
								" age=" + this.txtAge.Text + ", allowance=" + this.txtallow.Text + ", conName='" + this.txtCon.Text + "'," +
								" DetachDate='" + this.dtpDetach.Text + "' where regNo='" + this.txtregNo.Text + "';";

			int c = DataAccess.ExecuteQuery(this.query);
			if (c == 1)
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
			this.query = "Select allowance from IUDRegister";
			var dt = DataAccess.GetDataTable(this.query);
			int row = dt.Rows.Count;
			int c = 0;
			int total = 0;
			while (c < row)
			{
				total = total + int.Parse(dt.Rows[c][0].ToString());
				c++;
			}
			return total;
		}

		private int TotalIUD()
		{
			this.query = "Select conName from IUDRegister";
			var dt = DataAccess.GetDataTable(this.query);
			int row = dt.Rows.Count;
			return row;
		}

		private void dgvIUDDatabase_DoubleClick(object sender, EventArgs e)
		{
			this.txtAddress.Text = this.dgvIUDDatabase.CurrentRow.Cells["address"].Value.ToString();
			this.txtAge.Text = this.dgvIUDDatabase.CurrentRow.Cells["age"].Value.ToString();
			this.txtallow.Text = this.dgvIUDDatabase.CurrentRow.Cells["allowance"].Value.ToString();
			this.txtCon.Text = this.dgvIUDDatabase.CurrentRow.Cells["conName"].Value.ToString();
			this.txtName.Text = this.dgvIUDDatabase.CurrentRow.Cells["IUDname"].Value.ToString();
			this.txtregNo.Text = this.dgvIUDDatabase.CurrentRow.Cells["regNo"].Value.ToString();
			this.dtpDate.Text = this.dgvIUDDatabase.CurrentRow.Cells["date"].Value.ToString();
			this.dtpDetach.Text = this.dgvIUDDatabase.CurrentRow.Cells["DetachDate"].Value.ToString();
		}


		private void txtAuto_TextChanged(object sender, EventArgs e)
		{
			this.query = @"select * from IUDRegister where IUDname like '" + this.txtAuto.Text + "%';";
			this.PopulateGridView(this.query);
		}
		private void UpdateIUDQuaFromCon()
		{
			this.query = @"Select quantity from Contraceptive where conName='IUD';";
			var st = DataAccess.GetDataTable(this.query);
			int qua = int.Parse(st.Rows[0][0].ToString());
			qua = qua + 1;
			this.query = @"Update Contraceptive set quantity="+qua+" where conName='IUD'; ";
			DataAccess.ExecuteQuery(this.query);
		}
	}
}
