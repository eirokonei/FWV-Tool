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
	public partial class ContraceptiveData : MetroForm
	{
		int c, d, ee = 0;
		private string query { get; set; }
		private string sql { get; set; }
		public ContraceptiveData()
		{
			InitializeComponent();
			this.PopulateGridView();
			this.txtTotal.Text = this.TotalQua().ToString();
		}

		private void ContraceptiveData_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminHome am = new AdminHome();
			am.Show();
		}
		private void PopulateGridView(string sql = @"select * from Contraceptive;")
		{

			this.dgvConData.AutoGenerateColumns = false;
			this.dgvConData.DataSource = DataAccess.GetDataTable(sql);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvConData.SelectedRows.Count != 1)
				{
					MessageBox.Show("Please Select A Row First");
					return;
				}

				if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				int serial =int.Parse (this.dgvConData.CurrentRow.Cells["serial"].Value.ToString());
				this.query = "select * from Contraceptive where serial = "+serial+"; ";
				var dt = DataAccess.GetDataTable(this.query);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("Invalid.");
				}
				else
				{
					//this.query = "ALTER TABLE OCP NOCHECK CONSTRAINT FK_OCP_Contraceptive";
					//DataAccess.ExecuteQuery(this.query);
					this.query = "Delete from Contraceptive where serial = "+serial+"; ";
					int count = DataAccess.ExecuteQuery(this.query);
					/*this.query = "ALTER TABLE OCP CHECK CONSTRAINT FK_OCP_Contraceptive";
					DataAccess.ExecuteQuery(this.query);*/

					if (count == 1)
					{
						MessageBox.Show("Delete Confirmed.");
						this.PopulateGridView();
						this.CleartxtBox();
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				this.sql = @"Select * from Contraceptive where conName='"+this.txtConName.Text+"';";
				var dt = DataAccess.GetDataTable(this.sql);
				if (dt.Rows.Count == 1)
				{
					this.sql = @"update Contraceptive set type='" + this.txtType.Text + "', conName='"+this.txtConName.Text+"', quantity="+this.txtQuantity.Text+" where conName='"+this.txtConName.Text+"' ;";
					int row = DataAccess.ExecuteQuery(this.sql);
					if (row == 1)
					{
						MessageBox.Show("Value Updated");
						//this.UpdateContraceptive();
						this.PopulateGridView();
						this.txtTotal.Text = this.TotalQua().ToString();
						this.CleartxtBox();
						
					}
					else
					{
						MessageBox.Show("Failed");
					}
				}
				else
				{

					this.sql = @"insert into Contraceptive(type, conName, quantity) values('" + this.txtType.Text + "', '" + this.txtConName.Text + "', '" + this.txtQuantity.Text + "'); ";
					int row = DataAccess.ExecuteQuery(this.sql);
					if (row == 1)
					{
						MessageBox.Show("Value Added");
						
						this.PopulateGridView();
						this.txtTotal.Text = this.TotalQua().ToString();
						this.CleartxtBox();
					}
					else
					{
						MessageBox.Show("Failed");
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dgvConData_DoubleClick(object sender, EventArgs e)
		{
			
			this.txtConName.Text = this.dgvConData.CurrentRow.Cells["conName"].Value.ToString();
			this.txtQuantity.Text = this.dgvConData.CurrentRow.Cells["quantity"].Value.ToString();
			this.txtType.Text = this.dgvConData.CurrentRow.Cells["type"].Value.ToString();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.richtxtShow.Clear();
			this.richtxtShow.Text = "Reg No     Date                                       Name                      Address";
		}

		private void CleartxtBox()
		{
			this.txtConName.Clear();
			this.txtQuantity.Clear();
			this.txtType.Clear();
		}
		private int TotalQua()
		{
			this.query = "Select quantity from Contraceptive";
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

		private void btnShow_Click(object sender, EventArgs e)
		{
			if (this.dgvConData.SelectedRows.Count != 1)
			{
				MessageBox.Show("Please Select A Row First");
				return;
			}

			string Contra = this.dgvConData.CurrentRow.Cells["conName"].Value.ToString();


			string sql1 = @"Select regNo, date, name, address from InjectableConPatient where conName=(Select conName from Contraceptive where conName= '" + Contra + "' );";

			var dt = DataAccess.GetDataTable(sql1);

			string sql2 = @"Select regNo, date, OCPname, address from OCP where conName=(Select conName from Contraceptive where conName= '" + Contra + "' );";

			string sql3 = @"Select regNo, date, IUDname, address from IUDRegister where conName=(Select conName from Contraceptive where conName= '" + Contra + "' );";
			//this.richtxtShow.AppendText("Reg No\t Date\t Name\t Address\n\n");
			this.richtxtShow.AppendText("\n");

			while (c < dt.Rows.Count)
			{
				this.richtxtShow.AppendText("\n");
				this.richtxtShow.AppendText(dt.Rows[c][0].ToString());
				this.richtxtShow.AppendText("\t");
				this.richtxtShow.AppendText(dt.Rows[c][1].ToString());
				this.richtxtShow.AppendText("\t");
				this.richtxtShow.AppendText(dt.Rows[c][2].ToString());
				this.richtxtShow.AppendText("\t\t");
				this.richtxtShow.AppendText(dt.Rows[c][3].ToString());
				this.richtxtShow.AppendText("\n");
				c++;
			}
			dt = DataAccess.GetDataTable(sql2);
			while (d < dt.Rows.Count)
			{
				this.richtxtShow.AppendText("\n");
				this.richtxtShow.AppendText(dt.Rows[d][0].ToString());
				this.richtxtShow.AppendText("\t");
				this.richtxtShow.AppendText(dt.Rows[d][1].ToString());
				this.richtxtShow.AppendText("\t");
				this.richtxtShow.AppendText(dt.Rows[d][2].ToString());
				this.richtxtShow.AppendText("\t\t");
				this.richtxtShow.AppendText(dt.Rows[d][3].ToString());
				this.richtxtShow.AppendText("\n");
				d++;
			}

			dt = DataAccess.GetDataTable(sql3);

			while (ee < dt.Rows.Count)
			{
				this.richtxtShow.AppendText("\n");
				this.richtxtShow.AppendText(dt.Rows[ee][0].ToString());
				this.richtxtShow.AppendText("\t");
				this.richtxtShow.AppendText(dt.Rows[ee][1].ToString());
				this.richtxtShow.AppendText("\t");
				this.richtxtShow.AppendText(dt.Rows[ee][2].ToString());
				this.richtxtShow.AppendText("\t\t");
				this.richtxtShow.AppendText(dt.Rows[ee][3].ToString());
				this.richtxtShow.AppendText("\n");
				ee++;
			}
			

		}

		
	}
}
