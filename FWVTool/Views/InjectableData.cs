using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FWVTool.Data_Layer;
using MetroFramework.Forms;

namespace FWVTool.Views
{
	public partial class InjectableData : MetroForm
	{
		string query { get; set; }
		public InjectableData()
		{
			InitializeComponent();
			this.PopulateGridView();
			this.txtTotal.Text = this.TotalQua().ToString();
		}

		private void InjectableData_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminHome mhm = new AdminHome();
			mhm.Show();
		}
		private void PopulateGridView(string sql = @"select * from InjectableConPatient;")
		{

			this.dgvConPatn.AutoGenerateColumns = false;
			this.dgvConPatn.DataSource = DataAccess.GetDataTable(sql); ;
		}
		private void ClearBox()
		{
			this.txtRegNo.Clear();
			this.txtName.Clear();
			this.dtpDate.Value = System.DateTime.Now;
			this.dtpVisiting.Value = System.DateTime.Now;
			this.txtConName.Clear();
			this.txtChild.Clear();
			this.txtAge.Clear();
			this.txtAddrss.Clear();
		}

		private void txtAuto_TextChanged(object sender, EventArgs e)
		{
			this.query = @"select * from InjectableConPatient where name like '" + this.txtAuto.Text + "%';";
			this.PopulateGridView(this.query);
		}

		private void dgvConPatn_DoubleClick(object sender, EventArgs e)
		{

			this.txtRegNo.Text = this.dgvConPatn.CurrentRow.Cells["regNo"].Value.ToString();
			this.txtName.Text = this.dgvConPatn.CurrentRow.Cells["name"].Value.ToString();
			this.dtpDate.Text = this.dgvConPatn.CurrentRow.Cells["date"].Value.ToString();
			this.dtpVisiting.Text = this.dgvConPatn.CurrentRow.Cells["visitingDate"].Value.ToString();
			this.txtAddrss.Text = this.dgvConPatn.CurrentRow.Cells["address"].Value.ToString();
			this.txtAge.Text = this.dgvConPatn.CurrentRow.Cells["age"].Value.ToString();
			this.txtChild.Text = this.dgvConPatn.CurrentRow.Cells["child"].Value.ToString();
			this.txtConName.Text = this.dgvConPatn.CurrentRow.Cells["conName"].Value.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				this.query = @"update InjectableConPatient set name='"+this.txtName.Text+"', date='" + this.dtpDate.Text + "', " +
						 " address='"+this.txtAddrss.Text+ "', age="+this.txtAge.Text+ ", child='"+this.txtChild.Text+"',visitingDate='" + this.dtpVisiting.Text + "' where regNo='" + this.txtRegNo.Text + "' ;";
				int cout = DataAccess.ExecuteQuery(this.query);
				if (cout == 1)
				{
					MessageBox.Show("Value Updated");
					this.PopulateGridView();
					this.ClearBox();

				}
				else
				{
					MessageBox.Show("Failed");
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvConPatn.SelectedRows.Count != 1)
				{
					MessageBox.Show("Please Select A Row First");
					return;
				}

				if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				string regNo = this.dgvConPatn.CurrentRow.Cells["regNo"].Value.ToString();
				this.query = "select * from InjectableConPatient where regNo = '" + regNo + "'";
				var dt = DataAccess.GetDataTable(this.query);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("Invalid.");
				}
				else
				{
					//this.query = "ALTER TABLE OCP NOCHECK CONSTRAINT FK_OCP_Contraceptive";
					//DataAccess.ExecuteQuery(this.query);
					this.query = "Delete from InjectableConPatient where regNo = '" + regNo + "'; ";
					int count = DataAccess.ExecuteQuery(this.query);
					//this.query = "ALTER TABLE OCP CHECK CONSTRAINT FK_OCP_Contraceptive";
					//DataAccess.ExecuteQuery(this.query);
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
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int TotalQua()
		{
			this.query = "Select conName from InjectableConPatient ";
			var dt = DataAccess.GetDataTable(this.query);
			int total = dt.Rows.Count;
			
			return total;
		}
	}
}
