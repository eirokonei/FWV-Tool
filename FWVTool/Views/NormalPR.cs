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
	public partial class NormalPR : Form
	{
		string user { get; set; }
		private string query { get; set; }
		private string bloodDef { get; set; }
		private string jaun { get; set; }

		private string edem { get; set; }
		public NormalPR(string name="")
		{
			InitializeComponent();
			this.txtNPRRegNo.Text = this.autoGenerateId();
			this.PopulateGridView();
			this.user = name;
		}

		private void NormalPR_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		

		private void btnNPRSave_Click(object sender, EventArgs e)
		{
			try
			{
				if(this.txtNPRRegNo.Text=="" || this.dtpNPS.Text=="" || this.txtNPRName.Text=="" || this.txtNPRAddress.Text=="" || this.txtNPRAge.Text=="" || this.rtbNPRProblem.Text=="" || this.txtNPRPulstation.Text=="" || this.txtNPRBodyTemp.Text=="" || this.txtMedName.Text=="" || this.txtMedQua.Text=="")
				{
					MessageBox.Show("You are missing some value");
					return;
				}
				if((this.rbNPRBloodDYes.Checked!=true && this.rbNPRBloodDNo.Checked!=true) || (this.rbNPREdemaYes.Checked!=true && this.rbNPREdemaNo.Checked!=true) || (this.rbNPRJaunYes.Checked!=true && this.rbNPRJaunNo.Checked!=true))
				{
					MessageBox.Show("You are missing radio buttons value");
					return;
				}
				//DataAccess.Sqcon.Open();
				this.query = @"insert into NormalPatient values('" + this.txtNPRRegNo.Text + "', '" + this.dtpNPS.Text + "'," +
					" '" + this.txtNPRName.Text + "', '" + this.txtNPRAddress.Text + "', " + this.txtNPRAge.Text + "," +
					" '" + this.rtbNPRProblem.Text + "', " + this.txtNPRPulstation.Text + ", " + this.txtNPRBodyTemp.Text + "," +
					" '" + this.bloodDef + "', '" + this.jaun + "', '" + this.edem + "', '" + this.txtMedName.Text + "', '" + this.txtMedQua.Text + "' );";
				

				int row = DataAccess.ExecuteQuery(this.query);
				if (row == 1)
				{
					MessageBox.Show("Value Added");
					this.UpdateMedicine();
					this.PopulateGridView();
					this.txtNPRRegNo.Text = this.autoGenerateId();
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
		private void PopulateGridView(string sql = @"select medName, quantity from Medicine;")
		{
			
			//var dt = DataAccess.GetDataTable(sql);
			this.dgvMedicine.AutoGenerateColumns = false;
			this.dgvMedicine.DataSource = DataAccess.GetDataTable(sql); ;		
		}

		private void dgvMedicine_DoubleClick(object sender, EventArgs e)
		{
			this.txtMedName.Text = this.dgvMedicine.CurrentRow.Cells["medName"].Value.ToString();
		}

		private void txtMedSearch_TextChanged(object sender, EventArgs e)
		{
			this.query= @"select medName, quantity from Medicine where medName like '" + this.txtMedSearch.Text + "%';";
			this.PopulateGridView(this.query);
		}

		private  void UpdateMedicine()
		{
			int quantity = Int32.Parse(this.txtMedQua.Text);
			int dtQuantity = Int32.Parse(this.dgvMedicine.CurrentRow.Cells["quantity"].Value.ToString());
			int finalQuantity = dtQuantity - quantity;
			this.query = @"update Medicine set quantity = " + finalQuantity + " where medName='"+this.txtMedName.Text+"';";
			DataAccess.ExecuteQuery(this.query);
		}

		private void rbNPRBloodDYes_CheckedChanged(object sender, EventArgs e)
		{
			this.bloodDef = "Yes";
		}

		private void rbNPRBloodDNo_CheckedChanged(object sender, EventArgs e)
		{
			this.bloodDef = "No";
		}

		private void rbNPRJaunYes_CheckedChanged(object sender, EventArgs e)
		{
			this.jaun = "Yes";
		}

		private void rbNPRJaunNo_CheckedChanged(object sender, EventArgs e)
		{
			this.jaun = "No";
		}

		private void rbNPREdemaYes_CheckedChanged(object sender, EventArgs e)
		{
			this.edem = "Yes";
		}

		private void rbNPREdemaNo_CheckedChanged(object sender, EventArgs e)
		{
			this.edem = "No";
		}
		private string autoGenerateId()
		{
			this.query = @"select regNo from NormalPatient";
			var dt = DataAccess.GetDataTable(this.query);
			int rowCount = dt.Rows.Count;
			
			string regNo = dt.Rows[rowCount - 1][0].ToString();
			string[] subReg = regNo.Split('n', '-');
			int autoId = Convert.ToInt32(subReg[2]);
			//autoId++;

			return "n-" + (++autoId).ToString("d3");
		}
		private void CleartxtBox()
		{
			this.txtNPRName.Clear();
			this.dtpNPS.Value = System.DateTime.Now;
			this.txtMedName.Clear();
			this.txtMedQua.Clear();
			this.rtbNPRProblem.Clear();
			this.txtMedSearch.Clear();
			this.txtNPRAddress.Clear();
			this.txtNPRAge.Clear();
			this.txtNPRBodyTemp.Clear();
			this.txtNPRPulstation.Clear();			
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home hm = new Home(this.user);
			hm.Show();
		}
	}
}
