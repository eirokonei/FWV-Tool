using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWVTool.Entity;
using FWVTool.Data_Layer;
using System.Data;
using System.Windows.Forms;

namespace FWVTool.Repo
{
	class MedicineRepo
	{
		public List<Medicine> GetAll()
		{
			var productList = new List<Medicine>();
			try
			{
				string query = "select * from Medicine;";
				var dt = DataAccess.GetDataTable(query);

				for (int ax = 0; ax < dt.Rows.Count; ax++)
				{
					Medicine p = ConvertToEntity(dt.Rows[ax]);
					productList.Add(p);
				}
				return productList;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public int TotalQua()
		{
			string qua = "Select quantity from Medicine";
			var dt = DataAccess.GetDataTable(qua);
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

		public bool Delete(int serial)
		{
			string query = "select * from Medicine where serial = '" + serial + "'";
			var dt = DataAccess.GetDataTable(query);

			if (dt == null || dt.Rows.Count == 0)
			{
				return false;
			}
			query= "ALTER TABLE NORMALPATIENT NOCHECK CONSTRAINT FK_NORMALPATIENT_MEDICINE";
			DataAccess.ExecuteQuery(query);
			query = "delete from Medicine where serial = '" + serial + "'";
			int count = DataAccess.ExecuteQuery(query);
			query = "ALTER TABLE NORMALPATIENT CHECK CONSTRAINT FK_NORMALPATIENT_MEDICINE";
			DataAccess.ExecuteQuery(query);
			if (count == 1)
				return true;
			else
				return false;
			
		}
		public bool Save(int serial, string type, string medName, int quntity)
		{
			try
			{
				var pro = new Medicine();
				pro.serial = serial;
				pro.type = type;
				pro.medName = medName;
				pro.quantity = quntity;

				string query = "select * from Medicine where serial = "+pro.serial+"";
				

				var dt = DataAccess.GetDataTable(query);


				if (dt == null || dt.Rows.Count == 0)
				{
					query = "Insert into Medicine(type,medName,quantity) values ('" + pro.type + "','" + pro.medName + "','" + pro.quantity + "');";
				}
				else
				{
					query = "ALTER TABLE NORMALPATIENT NOCHECK CONSTRAINT FK_NORMALPATIENT_MEDICINE";
					DataAccess.ExecuteQuery(query);
					query = "Update Medicine set type = '" + pro.type + "', medName= '" + pro.medName + "',quantity= " + pro.quantity + " where serial = " + pro.serial + "";
				}

				int count = DataAccess.ExecuteQuery(query);

				query = "ALTER TABLE NORMALPATIENT CHECK CONSTRAINT FK_NORMALPATIENT_MEDICINE";
				DataAccess.ExecuteQuery(query);

				if (count >= 1)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception excep)
			{
				MessageBox.Show(excep.Message);
				return false;
			}
		}
		private Medicine ConvertToEntity(DataRow row)
		{
			if (row == null)
			{
				return null;
			}
			var p = new Medicine();
			p.serial = Convert.ToInt32(row["serial"].ToString());
			p.type = row["type"].ToString();
			p.medName = row["medName"].ToString();
			p.quantity = Int32.Parse(row["quantity"].ToString());
			return p;
		}
		public int AutoGenerateSerial()
		{
			string query = @"select serial from Medicine";
			var dt = DataAccess.GetDataTable(query);
			int rowCount = dt.Rows.Count;

			string regNo = dt.Rows[rowCount - 1][0].ToString();

			int value = Int32.Parse(regNo);
			//autoId++;

			return ++value;
		}

		public List<Medicine> GetSearchValue(string MmedName)
		{
			var productList = new List<Medicine>();
			try
			{
				var pr = new Medicine();
				pr.medName = MmedName;

				string q = "select * from Medicine where medName like '"+pr.medName+"%' ";

				var dt = DataAccess.GetDataTable(q);

				for (int ax = 0; ax < dt.Rows.Count; ax++)
				{
					Medicine p = ConvertToEntity(dt.Rows[ax]);
					productList.Add(p);
				}
				return productList;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

	}
}
