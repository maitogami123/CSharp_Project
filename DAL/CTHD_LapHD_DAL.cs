using FoodStoreManagement.DAL;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class CTHD_LapHD_DAL
    {
        public static CTHD_LapHD_DAL instance;
        public static CTHD_LapHD_DAL Instance
        {
            get { if (instance == null) instance = new CTHD_LapHD_DAL(); return CTHD_LapHD_DAL.instance; }
            private set { CTHD_LapHD_DAL.instance = value; }
        }
        public CTHD_LapHD_DAL() { }
        public DataTable LoadBillInfo()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Food.Price ,Food.FoodName, BillInfo.idFood, BillInfo.id, BillInfo.idBill, BillInfo.AmountFood FROM Food RIGHT JOIN BillInfo ON Food.id = BillInfo.idFood");
            return data;
        }
        public DataTable LoadTableWithID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE id=N'" + id + "'");
            return data;
        }
        public DataTable AddRow(string idbill, string idfood,int sl)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("INSERT INTO BillInfo (idBill,idFood,AmountFood) VALUES (N'" + idbill + "',N'" + idfood + "',N'" + sl + "')");
            return data;
        }
        public DataTable SearchTable(string id,string table)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE " + table + " LIKE '%" + id + "%' OR " + table + " = N'" + id + "'");
            return dt;
        }
        public DataTable UpdateRow(string idbill, string idfood, int sl)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("UPDATE BillInfo SET AmountFood = N'" + sl + "' WHERE idBill=N'"+idbill+"' AND idFood=N'"+idfood+"'");
            return dt;
        }
        public DataTable DeleteRow(string idbill,string idfood)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("DELETE FROM BillInfo WHERE idBill=N'" + idbill + "' AND idFood=N'" + idfood + "'");
            return dt;
        }
    }
}
