using FoodStoreManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            set { AccountDAL.instance = value; }
        }

        public string UserName { get; set; }

        private AccountDAL() { }
        public bool Login(string username, string password)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
    }
}
