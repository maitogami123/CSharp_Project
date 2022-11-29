using FoodStoreManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHang_DAL
    {
        public static KhachHang_DAL instance;
        public static KhachHang_DAL Instance
        {
            get { if (instance == null) instance = new KhachHang_DAL(); return KhachHang_DAL.instance; }
            private set { KhachHang_DAL.instance = value; }
        }

        private KhachHang_DAL() { }
        public DataTable LoadTableList()
        {
            //BindingList<Ban> tableList = new BindingList<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Customer");

            /*foreach (DataRow item in data.Rows)
            {
                Ban table = new Ban(item);
                tableList.Add(table);
            }*/

            return data;
        }
        public DataTable DeleteRow(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE FROM Customer WHERE idUsernameCustom = N'" + id+"'");
            return data;
        }
        public DataTable AddRow(string id,string name,string sdt,string dc, string loai)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("INSERT INTO Customer(idUsernameCustom,CustomName,Phone,Address,TypeCustom) VALUES (N'" + id + "',N'" + name + "',N'" + sdt + "',N'" + dc + "',N'" + loai + "')");
            return data;
        }
        public DataTable UpdateRow(string id, string name, string sdt, string dc, string loai)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("UPDATE Customer SET CustomName = N'" + name+ "',Phone = N'" + sdt + "',Address = N'" + dc + "',TypeCustom = N'" + loai + "' WHERE idUsernameCustom = N'" + id+"'");
            return data;
        }
        public DataTable SearchTable(string name, string table)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Customer WHERE " + table + " LIKE '%" + name + "%' OR " + table + " = N'" + name + "'");
            return data;
        }
    }
}
