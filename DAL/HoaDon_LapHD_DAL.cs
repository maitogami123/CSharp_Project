using DTO;
using FoodStoreManagement.DAL;
using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDon_LapHD_DAL
    {
        public static HoaDon_LapHD_DAL instance;
        public static HoaDon_LapHD_DAL Instance
        {
            get { if (instance == null) instance = new HoaDon_LapHD_DAL(); return HoaDon_LapHD_DAL.instance; }
            private set { HoaDon_LapHD_DAL.instance = value; }
        }
        public HoaDon_LapHD_DAL() { }
        public DataTable GetidBan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id FROM TableFood");
            return data;
        }
        public DataTable GetTableStatus(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id,status FROM TableFood WHERE id=N'"+id+"'");
            return data;
        }
        public DataTable ChangeTableStatus(string id,string status)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("UPDATE TableFood SET status=N'"+status+"' WHERE id=N'" + id + "'");
            return data;
        }
        public DataTable AddRow(string idban, string idnv, string dayin, string dayout, string status,float tien)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("INSERT INTO Bill(idTableFood,idStaff,DayIn,DayOut,status,TotalPrice) VALUES (N'" + idban + "',N'" + idnv + "',N'" + dayin + "',N'" + dayout + "',N'" + status + "',N'" + tien + "')");
            return data;
        }
        public DataTable LoadId(string id,string table,string status)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id,idTableFood,idStaff FROM Bill WHERE "+table+"=N'"+id+"' AND status=N'"+status+"'");
            return data;
        }
        public DataTable UpdateHDStatusAndMoney(string id,string idban, string idnv, string status,string money)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("UPDATE Bill SET status = N'" + status + "',TotalPrice=N'"+money+"' WHERE id = N'" + id + "' AND idTableFood = N'" + idban + "' AND idStaff = N'" + idnv + "'");
            return dt;
        }

    }
}
