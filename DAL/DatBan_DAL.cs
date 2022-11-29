using FoodStoreManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;

namespace DAL
{
    public class DatBan_DAL
    {
        public static DatBan_DAL instance;

        public static DatBan_DAL Instance
        {
            get { if (instance == null) instance = new DatBan_DAL(); return DatBan_DAL.instance; }
            private set { DatBan_DAL.instance = value; }
        }
        private DatBan_DAL() { }
        public DataTable LoadTableList()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM DatBan");
            return dt;
        }
        public DataTable GetidKH()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT idUsernameCustom FROM Customer");
            return dt;
        }
        public DataTable GetidBan()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT id FROM TableFood");
            return dt;
        }
        public DataTable AddRow(int iddatban, int idban, string idkh, string tg, string ngay, int songuoi) 
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("INSERT INTO DatBan(idBan,idKH,ThoiGian,Ngay,SoNguoi,idDatBan) VALUES (N'"+idban+"',N'"+idkh+"',N'"+tg+"',N'"+ngay+"',N'"+songuoi+"',N'"+iddatban+"')");
            return dt;
        }
        public DataTable DeleteRow(string iddatban)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("DELETE FROM DatBan WHERE idDatBan = N'" + iddatban + "'");
            return dt;
        }
        public DataTable UpdateRow(int iddatban, int idban, string idkh, string tg, string ngay, int songuoi)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("UPDATE DatBan SET idBan = N'" + idban + "',idKH = N'" + idkh + "',ThoiGian = N'" + tg + "',Ngay = N'" + ngay + "',SoNguoi = N'" + songuoi + "' WHERE idDatBan = N'" + iddatban + "'");
            return dt;
        }
        public DataTable SearchTable(string name,string table)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM DatBan WHERE " + table + " LIKE '%" + name + "%' OR " + table + " = N'" + name + "'");
            return dt;
        }
        public DataTable GetColumnTableDatBan(string column)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT "+column+" FROM DatBan");
            return dt;
        }
    }
}
