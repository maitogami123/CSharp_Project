using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DAL
{
    internal class Program
    {
        class DataProvide
        {

            //Connect phpMyAdmin database
            public MySqlConnection connect;
            private string server = "sql12.freemysqlhosting.net";
            private string uid = "ql12569667";
            private string password = "DXBPa1f8Jm";
            private string database = "sql12569667";

            public void Connect()
            {
                connect = new MySqlConnection("Datasource = " + server + "; username=" + uid + ";password=" + password + ";database=" + database + ";");
            }

        }
        static void Main(string[] args)
        {

        }
    }
}
