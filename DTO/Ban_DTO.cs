using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban
    {
        private int iD;
        private string name;
        private string status;
        public Ban(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Ban(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["tablefood"].ToString();
            this.Status = row["status"].ToString();
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
