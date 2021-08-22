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
	public partial class InjectableExisting : UserControl
	{
		private string query { get; set; }
		private bool dateRes = false;
		public InjectableExisting()
		{
			InitializeComponent();
			
			this.PopulateGridView();
			
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			
			try
			{
				//DataAccess.Sqcon.Open();
				this.dateRes = this.CompareVisitingDate();	
				if(this.dateRes)
				{
					this.query = @"update InjectableConPatient set date='" + this.dtpICES.Text + "', " +
				         "visitingDate='" + this.dtpICENextDate.Text + "' where regNo='" + this.txtICERegNo.Text + "' ;";
					int cout = DataAccess.ExecuteQuery(this.query);
					if (cout == 1)
					{
						MessageBox.Show("Value Updated");
						this.UpdateContraceptive();
						this.PopulateGridView();
						//DataAccess.Sqcon.Close();
						this.ClearBox();

					}
					else
					{
						MessageBox.Show("Failed");
					}
					
				}
				else
				{
					MessageBox.Show("Patient isn't allowed");
				}
				this.dateRes = false;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				//DataAccess.Sqcon.Close();
			}
		}
		private void PopulateGridView(string sql = @"select regNo, name, date, visitingDate from InjectableConPatient;")
		{

			//var dt = DataAccess.GetDataTable(sql);
			this.dgvConPatn.AutoGenerateColumns = false;
			this.dgvConPatn.DataSource = DataAccess.GetDataTable(sql); ;
		}
		private void ClearBox()
		{
			this.txtICERegNo.Clear();
			this.txtICEName.Clear();
			this.dtpICES.Value = System.DateTime.Now;
			this.dtpICENextDate.Value = System.DateTime.Now;
			this.dtpICEPreviousS.Value = System.DateTime.Now;
		}

		private void dgvConPatn_DoubleClick(object sender, EventArgs e)
		{
			this.txtICERegNo.Text = this.dgvConPatn.CurrentRow.Cells["regNo"].Value.ToString();
			this.txtICEName.Text = this.dgvConPatn.CurrentRow.Cells["name"].Value.ToString();
			this.dtpICEPreviousS.Text = this.dgvConPatn.CurrentRow.Cells["visitingDate"].Value.ToString();
		}

		private void txtAutoSearch_TextChanged(object sender, EventArgs e)
		{
			this.query = @"select regNo, name, date, visitingDate from InjectableConPatient where name like '" + this.txtAutoSearch.Text + "%';";
			this.PopulateGridView(this.query);
		}

		private bool CompareVisitingDate()
		{
			if(this.dtpICES.Value > this.dtpICEPreviousS.Value || this.dtpICES.Value.Equals(this.dtpICEPreviousS.Value))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void UpdateContraceptive()
		{
			this.query = @"select quantity from Contraceptive where conName='Injection';";
			var dt = DataAccess.GetDataTable(this.query);
			int dtQuantity = Int32.Parse(dt.Rows[0][0].ToString());
			int finalQuantity = dtQuantity - 1;
			this.query = @"update Contraceptive set quantity = " + finalQuantity + " where conName='Injection';";
			DataAccess.ExecuteQuery(this.query);
		}
	}
}
