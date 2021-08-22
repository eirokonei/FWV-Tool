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
	public partial class MyProfile : MetroForm
	{
		string user { get; set; }
		public MyProfile(string name="")
		{
			InitializeComponent();
			this.user = name;
			this.Populate();
		}

		private void MyProfile_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string sq = @"Select userId from FWVUser where userName='" + this.user + "' ";
			var dt = DataAccess.GetDataTable(sq);
			string uid = dt.Rows[0][0].ToString();

			string que = @"Update FWVUser set userName='" + this.txtUserName.Text + "', fullName='" + this.txtFullName.Text + "'," +
				" mobile='"+ this.txtMoblie.Text + "', email='"+ this.txtEmail.Text + "', password='"+ this.txtPassword.Text + "' where userId='"+uid+"' ";
			int c = DataAccess.ExecuteQuery(que);
			if(c==1)
			{
				MessageBox.Show("Updated");
				this.PPopulate();
			}
			else
			{
				MessageBox.Show("Invalid");
			}
		}

		private void Populate()
		{
			try
			{
				string sql = @"Select * from FWVUser where userName='" + this.user + "' ";
				var dt = DataAccess.GetDataTable(sql);

				this.txtUserId.Text = dt.Rows[0][0].ToString();
				this.txtUserName.Text = dt.Rows[0][1].ToString();
				this.txtFullName.Text = dt.Rows[0][2].ToString();
				this.txtMoblie.Text = dt.Rows[0][3].ToString();
				this.txtEmail.Text = dt.Rows[0][4].ToString();
				this.txtPassword.Text = dt.Rows[0][5].ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void PPopulate()
		{
			try
			{
				string sql = @"Select * from FWVUser where userName='" + this.txtUserName.Text + "' ";
				var dt = DataAccess.GetDataTable(sql);

				this.txtUserId.Text = dt.Rows[0][0].ToString();
				this.txtUserName.Text = dt.Rows[0][1].ToString();
				this.txtFullName.Text = dt.Rows[0][2].ToString();
				this.txtMoblie.Text = dt.Rows[0][3].ToString();
				this.txtEmail.Text = dt.Rows[0][4].ToString();
				this.txtPassword.Text = dt.Rows[0][5].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home hm = new Home(this.txtUserName.Text);
			hm.Show();
		}

	}
}
