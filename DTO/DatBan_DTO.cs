using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatBan
    {
        private int IdBan { get; set; }
        private string IdKH { get; set; }
        private string TenKH { get; set; }
        private string tg { get; set; }
        private string ngay { get; set; }
        private int songuoi { get; set; }

        public DatBan(int idBan, string idKH, string tenKH, string tg, string ngay, int songuoi)
        {
            IdBan = idBan;
            IdKH = idKH;
            TenKH = tenKH;
            this.tg = tg;
            this.ngay = ngay;
            this.songuoi = songuoi;
        }
        public DatBan(DataRow row) 
        {
            this.IdBan = (int)row["idBan"];
            this.IdKH = row["idKH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.tg = row["ThoiGian"].ToString();
            this.ngay = row["Ngay"].ToString();
            this.songuoi = (int)row["SoNguoi"];
        }
    }
}
