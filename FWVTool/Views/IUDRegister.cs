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

namespace FWVTool.Views
{
	public partial class IUDRegister : Form
	{
		string user { get; set; }
		private string sql { get; set; }
		public IUDRegister(string name="")
		{
			InitializeComponent();
			this.txtIUDRegNo.Text = this.autoGenerateId();
			this.PopulateGridView();
			user = name;
		}

		private void IUDRegister_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				//DataAccess.Sqcon.Open();
				this.sql =@"Select * from IUDRegister where regNo='" + this.txtIUDRegNo.Text + "';";
				var dt = DataAccess.GetDataTable(this.sql);
				if (dt.Rows.Count == 1)
				{
					this.sql = @"update IUDRegister set DetachDate='"+this.dtpIUDDetach.Text+"'" +
						" where regNo='" + this.txtIUDRegNo.Text + "' ;";
					int row = DataAccess.ExecuteQuery(this.sql);
					if (row == 1)
					{
						MessageBox.Show("Value Updated");
						//this.UpdateContraceptive();
						this.PopulateGridView();
						this.txtIUDRegNo.Text = this.autoGenerateId();
						this.CleartxtBox();
						this.pnlDetach.Visible = false;
					}
					else
					{
						MessageBox.Show("Failed");
					}
				}
				else
				{
					/*this.dtpIUDDetach.Value.AddYears(0000);
					this.dtpIUDDetach.Value.AddMonths(12);*/
					this.sql = @"insert into IUDRegister values('" + this.txtIUDRegNo.Text + "'," +
								" '" + this.dtpIUD.Text + "', '" + this.txtIUDName.Text + "', '" + this.txtIUDAddress.Text + "'," +
								" " + this.txtIUDAge.Text + ", " + this.txtIUDAllow.Text + ", '" + this.txtIUDConName.Text + "'," +
								" '"+ this.dtpIUDDetach.Text + "');";
					int row = DataAccess.ExecuteQuery(this.sql);
					if (row == 1)
					{
						MessageBox.Show("Value Added");
						this.UpdateContraceptive();
						this.PopulateGridView();
						this.txtIUDRegNo.Text = this.autoGenerateId();
						this.CleartxtBox();
					}
					else
					{
						MessageBox.Show("Failed");
					}
				}
				//DataAccess.Sqcon.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//DataAccess.Sqcon.Close();
			}
		}
		private void UpdateContraceptive()
		{
			this.sql = @"select quantity from Contraceptive where conName='" + this.txtIUDConName.Text + "';";
			var dt = DataAccess.GetDataTable(this.sql);
			int dtQuantity = Int32.Parse(dt.Rows[0][0].ToString());
			int finalQuantity = dtQuantity - 1;
			this.sql = @"update Contraceptive set quantity = " + finalQuantity + " where conName='" + this.txtIUDConName.Text + "';";
			DataAccess.ExecuteQuery(this.sql);
		}
		private string autoGenerateId()
		{
			this.sql = @"select regNo from IUDRegister";
			var dt = DataAccess.GetDataTable(this.sql);
			int rowCount = dt.Rows.Count;

			string regNo = dt.Rows[rowCount - 1][0].ToString();
			string[] subReg = regNo.Split('i', 'u', 'd', '-');
			int autoId = Convert.ToInt32(subReg[4]);
			//autoId++;

			return "iud-" + (++autoId).ToString("d3");
		}
		private void CleartxtBox()
		{
			this.txtIUDName.Clear();
			this.txtIUDAge.Clear();
			this.txtIUDAddress.Clear();
			this.dtpIUD.Value = System.DateTime.Now;
			//this.dtpIUDDetach.Value = System.DateTime.Now;
		}
		private void PopulateGridView(string sql = @"select regNo, date, IUDname, DetachDate from IUDRegister;")
		{

			//var dt = DataAccess.GetDataTable(sql);
			this.dgvIUD.AutoGenerateColumns = false;
			this.dgvIUD.DataSource = DataAccess.GetDataTable(sql); ;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home hm = new Home(user);
			hm.Show();
		}

		private void txtAutoSearch_TextChanged(object sender, EventArgs e)
		{
			this.sql = @"select regNo, date, IUDname, DetachDate from IUDRegister where IUDname like '" + this.txtAutoSearch.Text + "%';";
			this.PopulateGridView(this.sql);
		}

		private void dgvIUD_DoubleClick(object sender, EventArgs e)
		{
			this.pnlDetach.Visible = true;
			
			this.txtIUDRegNo.Text = this.dgvIUD.CurrentRow.Cells["regNo"].Value.ToString();
			this.txtIUDName.Text = this.dgvIUD.CurrentRow.Cells["IUDname"].Value.ToString();
			this.dtpIUD.Text = this.dgvIUD.CurrentRow.Cells["date"].Value.ToString();
			//this.dtpIUDDetach.Text = this.dgvIUD.CurrentRow.Cells["DetachDate"].Value.ToString();
		}
	}
}
