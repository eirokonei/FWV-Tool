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
	public partial class OCP : Form
	{
		string user { get; set; }
		private string sql { get; set; }
		public OCP(string name="")
		{
			InitializeComponent();
			this.txtOCPRegNo.Text = this.autoGenerateId();
			this.user = name;
		}

		private void OCP_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home hm = new Home(this.user);
			hm.Show();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				
				this.sql = @"insert into OCP values('" + this.txtOCPRegNo.Text + "'," +
				" '" + this.dtpOCP.Text + "', '" + this.txtOCPName.Text + "', '" + this.txtOCPAddress.Text + "'," +
				" " + this.txtOCPAge.Text + ", " + this.txtOCPChild.Text + ", '" + this.cmbPillName.SelectedItem + "'," +
				" '" + this.txtQuantity.Text + "');";
				int row = DataAccess.ExecuteQuery(this.sql);
				if (row == 1)
				{
					MessageBox.Show("Value Added");
					this.UpdateContraceptive();
					this.txtOCPRegNo.Text = this.autoGenerateId();
					this.CleartxtBox();
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
		private string autoGenerateId()
		{
			this.sql = @"select regNo from OCP";
			var dt = DataAccess.GetDataTable(this.sql);
			int rowCount = dt.Rows.Count;

			string regNo = dt.Rows[rowCount - 1][0].ToString();
			string[] subReg = regNo.Split('o', 'c', 'p', '-');
			int autoId = Convert.ToInt32(subReg[4]);
			//autoId++;

			return "ocp-" + (++autoId).ToString("d3");
		}
		private void UpdateContraceptive()
		{
			this.sql = @"select quantity from Contraceptive where conName='" + this.cmbPillName.SelectedItem + "';";
			var dt = DataAccess.GetDataTable(this.sql);
			int dtQuantity = Int32.Parse(dt.Rows[0][0].ToString());
			int txtQuantity = Int32.Parse(this.txtQuantity.Text);
			int finalQuantity = dtQuantity - txtQuantity;
			this.sql = @"update Contraceptive set quantity = " + finalQuantity + " where conName='" + this.cmbPillName.SelectedItem + "';";
			DataAccess.ExecuteQuery(this.sql);
		}
		private void CleartxtBox()
		{
			this.txtOCPName.Clear();
			this.txtOCPChild.Clear();
			this.txtOCPAge.Clear();
			this.txtOCPAddress.Clear();
			this.dtpOCP.Value = System.DateTime.Now;
			this.txtQuantity.Text = "";
		}
	}
	
}
