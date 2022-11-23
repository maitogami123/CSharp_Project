using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private Ban_DAL() { }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }

        public List<Ban> LoadTableList()
        {
            List<Ban> tableList = new List<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Ban table = new Ban(item);
                tableList.Add(table);
            }

            return tableList;
        }
    }
}
