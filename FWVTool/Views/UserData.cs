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
	public partial class UserData : MetroForm
	{
		private string query { get; set; }
		public UserData()
		{
			InitializeComponent();
			this.PopulateGridView();
		}

		private void UserData_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminHome aam = new AdminHome();
			aam.Show();
		}

		private void txtAuto_TextChanged(object sender, EventArgs e)
		{
			this.query = @"select * from FWVUser where userName like '" + this.txtAuto.Text + "%';";
			this.PopulateGridView(this.query);
		}
		private void PopulateGridView(string sql = @"select * from FWVUser;")
		{
			this.dgvUser.AutoGenerateColumns = false;
			this.dgvUser.DataSource = DataAccess.GetDataTable(sql); ;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvUser.SelectedRows.Count != 1)
				{
					MessageBox.Show("Please Select A Row First");
					return;
				}

				if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				string regNo = this.dgvUser.CurrentRow.Cells["UserId"].Value.ToString();
				this.query = "select * from FWVUser where userId = '" + regNo + "'";
				var dt = DataAccess.GetDataTable(this.query);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("Invalid.");
				}
				else
				{
				
					this.query = "Delete from FWVUser where userId = '" + regNo + "'; ";
					int count = DataAccess.ExecuteQuery(this.query);
					
					if (count == 1)
					{
						MessageBox.Show("Delete Confirmed.");
						this.PopulateGridView();
						
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

		private void dgvUser_DoubleClick(object sender, EventArgs e)
		{
			this.txtUserId.Text = this.dgvUser.CurrentRow.Cells["userId"].Value.ToString();
			this.txtUserName.Text = this.dgvUser.CurrentRow.Cells["userName"].Value.ToString();
			this.txtPassword.Text = this.dgvUser.CurrentRow.Cells["password"].Value.ToString();
			this.txtMoblie.Text = this.dgvUser.CurrentRow.Cells["mobile"].Value.ToString();
			this.txtFullName.Text = this.dgvUser.CurrentRow.Cells["fullName"].Value.ToString();
			this.txtEmail.Text = this.dgvUser.CurrentRow.Cells["email"].Value.ToString();
		}
	}
}
