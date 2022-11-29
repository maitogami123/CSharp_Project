using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace FoodStoreManagement.DAL
{
    public class QuanLyTaiKhoan_DAL
    {
        public static QuanLyTaiKhoan_DAL instance;
        public static QuanLyTaiKhoan_DAL Instance
        {
            get { if (instance == null) instance = new QuanLyTaiKhoan_DAL(); return QuanLyTaiKhoan_DAL.instance; }
            private set { QuanLyTaiKhoan_DAL.instance = value; }
        }

        public DataTable LoadTableList()
        {
            
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account");


            return data;
        }
        public DataTable DeleteRow(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE FROM Account WHERE UserName = N'" + userName+"'");
            return data;
        }
        public DataTable AddRow(string userName, string displayUserName, string passWord, int typeAccount)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("INSERT INTO Account (UserName, DisplayUserName, PassWord, TypeAccount) VALUES (N'"+userName+"', N'"+displayUserName+"', N'"+passWord+"',"+typeAccount+")");
            return data;
        }
        public DataTable UpdateRow(string userName, string displayUserName, string passWord, int typeAccount)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("UPDATE Account SET DisplayUserName = N'" + displayUserName + "', PassWord =N'"+passWord+"',TypeAccount="+typeAccount + " WHERE UserName = N'" + userName+"'");
            return data;
        }


        //Update Staff
        public DataTable UpdateRowStaff(string idStaff, string staffName, string address, string phone)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("UPDATE Staff SET StaffName = N'" + staffName + "', Address =N'" + address + "', Phone=" + phone + " WHERE idStaff = N'" + idStaff + "'");
            return data;
        }
        //Update Customer
        public DataTable UpdateRowCustomer(string idUsernameCustom, string customName, string address, string phone, string typeCustom)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("UPDATE Customer SET CustomName = N'"+customName+"', Address =N'" + address + "', Phone=" + phone + " , TypeCustomer = N'"+typeCustom+ "' WHERE idUsernameCustom = N'" + idUsernameCustom + "'");
            return data;
        }

        //Search
        public DataTable SearchTable(string input, string select)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE " + select + " LIKE '%" + input + "%'");
            return data;
        }

        //Validate
        public DataTable ValidateAddForm__TypeAccount()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select TypeAccount from Account ");
            return data;
        }
        public DataTable ValidateAddForm__UserName()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select UserName from Account ");
            return data;
        }
    }

}
