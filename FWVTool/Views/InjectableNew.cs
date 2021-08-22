using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FWVTool.Data_Layer;

namespace FWVTool.Views
{
	public partial class InjectableNew : UserControl
	{
		private string sql { get; set; }
		public InjectableNew()
		{
			InitializeComponent();
			this.txtICRegNo.Text = this.autoGenerateId();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			
			try
			{
				//DataAccess.Sqcon.Open();
				this.sql = @"insert into InjectableConPatient values('" + this.txtICRegNo.Text + "'," +
				" '" + this.dtpICS.Text + "', '" + this.txtICName.Text + "', '" + this.txtICAddress.Text + "'," +
				" " + this.txtICAge.Text + ", " + this.txtICChild.Text + ", '" + this.dtpICNextDate.Text + "'," +
				" '" + this.txtConName.Text + "');";
				int row = DataAccess.ExecuteQuery(this.sql);
				if (row == 1)
				{
					MessageBox.Show("Value Added");
					this.UpdateContraceptive();
					this.txtICRegNo.Text = this.autoGenerateId();
					this.CleartxtBox();
				}
				else
				{
					MessageBox.Show("Failed");
				}
				//DataAccess.Sqcon.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				//DataAccess.Sqcon.Close();
			}
		}
		private string autoGenerateId()
		{
			this.sql = @"select regNo from InjectableConPatient";
			var dt = DataAccess.GetDataTable(this.sql);
			int rowCount = dt.Rows.Count;

			string regNo = dt.Rows[rowCount - 1][0].ToString();
			string[] subReg = regNo.Split('i', 'c', '-');
			int autoId = Convert.ToInt32(subReg[3]);
			//autoId++;

			return "ic-" + (++autoId).ToString("d3");
		}
		private void UpdateContraceptive()
		{
			this.sql = @"select quantity from Contraceptive where conName='"+this.txtConName.Text+"';";
			var dt = DataAccess.GetDataTable(this.sql);
			int dtQuantity = Int32.Parse(dt.Rows[0][0].ToString());
			int finalQuantity = dtQuantity - 1;
			this.sql = @"update Contraceptive set quantity = " + finalQuantity + " where conName='" + this.txtConName.Text + "';";
			DataAccess.ExecuteQuery(this.sql);
		}
		private void CleartxtBox()
		{
			this.txtICName.Clear();
			this.txtICChild.Clear();
			this.txtICAge.Clear();
			this.txtICAddress.Clear();
			this.dtpICS.Value= System.DateTime.Now;
			this.dtpICNextDate.Value= System.DateTime.Now;
		}
	}
}
