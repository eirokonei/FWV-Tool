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
	public partial class NormalPData : MetroForm
	{
		private string query { get; set; }
		public NormalPData()
		{
			InitializeComponent();
			this.PopulateGridView();
			this.txtTotal.Text = this.TotalQua().ToString();
		}

		private void NormalPData_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminHome ahm = new AdminHome();
			ahm.Show();
		}

		private void dgvNPatn_DoubleClick(object sender, EventArgs e)
		{
			this.txtregNo.Text = this.dgvNPatn.CurrentRow.Cells["regNo"].Value.ToString();
			this.txtName.Text = this.dgvNPatn.CurrentRow.Cells["name"].Value.ToString();
			this.dtpDate.Text = this.dgvNPatn.CurrentRow.Cells["date"].Value.ToString();
			this.txtAddress.Text = this.dgvNPatn.CurrentRow.Cells["address"].Value.ToString();
			this.txtAge.Text = this.dgvNPatn.CurrentRow.Cells["age"].Value.ToString();
			this.txtBloodDef.Text = this.dgvNPatn.CurrentRow.Cells["bloodDef"].Value.ToString();
			this.txtEdema.Text = this.dgvNPatn.CurrentRow.Cells["edema"].Value.ToString();
			this.txtJaun.Text = this.dgvNPatn.CurrentRow.Cells["jaundice"].Value.ToString();
			this.txtMedName.Text = this.dgvNPatn.CurrentRow.Cells["medName"].Value.ToString();
			this.txtProb.Text = this.dgvNPatn.CurrentRow.Cells["problem"].Value.ToString();
			this.txtPuls.Text = this.dgvNPatn.CurrentRow.Cells["pulstation"].Value.ToString();
			this.txtQuantity.Text = this.dgvNPatn.CurrentRow.Cells["medQuantity"].Value.ToString();
			this.txtTemp.Text = this.dgvNPatn.CurrentRow.Cells["bodyTemp"].Value.ToString();

		}
		private void PopulateGridView(string sql = @"select * from NormalPatient;")
		{

			this.dgvNPatn.AutoGenerateColumns = false;
			this.dgvNPatn.DataSource = DataAccess.GetDataTable(sql); ;
		}

		private void txtAuto_TextChanged(object sender, EventArgs e)
		{

			this.query = @"select * from NormalPatient where name like '" + this.txtAuto.Text + "%';";
			this.PopulateGridView(this.query);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				this.query = @"update NormalPatient set name='" + this.txtName.Text + "', date='" + this.dtpDate.Text + "', " +
						 " address='" + this.txtAddress.Text + "', age=" + this.txtAge.Text + ", problem='" + this.txtProb.Text + "', pulstation=" + this.txtPuls.Text + "," +
						  " bodyTemp=" + this.txtTemp.Text + ", bloodDef='" + this.txtBloodDef.Text + "', jaundice='" + this.txtJaun.Text + "'," +
							" edema='" + this.txtEdema.Text + "', medName='" + this.txtMedName.Text + "', medQuantity=" + this.txtQuantity.Text + " where regNo='" + this.txtregNo.Text + "' ;";
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
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ClearBox()
		{
			this.txtregNo.Clear();
			this.txtName.Clear();
			this.dtpDate.Value = System.DateTime.Now;
			
			this.txtMedName.Clear();
			
			this.txtAge.Clear();
			this.txtAddress.Clear();
			this.txtEdema.Clear();
			this.txtJaun.Clear();
			this.txtProb.Clear();
			this.txtTemp.Clear();
			this.txtProb.Clear();
			this.txtQuantity.Clear();
			this.txtBloodDef.Clear();
		}

		private int TotalQua()
		{
			this.query = "Select medQuantity from NormalPatient";
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvNPatn.SelectedRows.Count != 1)
				{
					MessageBox.Show("Please Select A Row First");
					return;
				}

				if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				string regNo = this.dgvNPatn.CurrentRow.Cells["regNo"].Value.ToString();
				this.query = "select * from NormalPatient where regNo = '" + regNo + "'";
				var dt = DataAccess.GetDataTable(this.query);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("Invalid.");
				}
				else
				{
					//this.query = "ALTER TABLE OCP NOCHECK CONSTRAINT FK_OCP_Contraceptive";
					//DataAccess.ExecuteQuery(this.query);
					this.query = "Delete from NormalPatient where regNo = '" + regNo + "'; ";
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
	}
}
