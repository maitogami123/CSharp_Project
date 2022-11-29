using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace  FoodStoreManagement.DAL
{
    public class Bill_DAL
    {
        public static Bill_DAL instance;
        public static Bill_DAL Instance
        {
            get { if (instance == null) instance = new Bill_DAL(); return Bill_DAL.instance; }
            private set { Bill_DAL.instance = value; }
        }
        public DataTable DeleteRow(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE FROM Bill WHERE id = " + id);
            return data;
        }
        public DataTable AddRow(string foodName, int idCategory, float price)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("INSERT INTO Bill (id, DayIn, DayOut,idTableFood, TotalPrice, status, idStaff) VALUES(N'B1', N'2022-11-21', N'2022-11-21', 1, 25000, 0, N'NV-1')");
            return data;
        }
        public DataTable UpdateRow(int id, string foodName, int idCategory, float price)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("UPDATE Food SET FoodName= N'" + foodName + "', Price =" + price + " WHERE id =" + id);
            return data;
        }
        public DataTable LoadTableList()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill");
            return data;
        }

        public DataTable SearchTable(string input, string select)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE " + select + " LIKE '%" + input + "%'");
            return data;
        }

    }
}
