using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.ComponentModel;

namespace FoodStoreManagement.DAL
{
    public class Ban_DAL
    {
        private static Ban_DAL instance;

        public static Ban_DAL Instance
        {
            get { if (instance == null) instance = new Ban_DAL(); return Ban_DAL.instance; }
            private set { Ban_DAL.instance = value; }
        }

        private Ban_DAL() { }

        public DataTable LoadTableList()
        {
            //BindingList<Ban> tableList = new BindingList<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            /*foreach (DataRow item in data.Rows)
            {
                Ban table = new Ban(item);
                tableList.Add(table);
            }*/

            return data;
        }
        public DataTable DeleteRow(int id)
        {
            DataTable data =DataProvider.Instance.ExecuteQuery("DELETE FROM TableFood WHERE id = " + id);
            return data;
        }
        public DataTable AddRow(string value,string status)
        {
            DataTable data= DataProvider.Instance.ExecuteQuery("INSERT INTO TableFood(tablefood,status) VALUES (N'"+value+"',N'"+status+")");
            return data;
        }
    }
}
