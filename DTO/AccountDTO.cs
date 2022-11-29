using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public AccountDTO(string UserName, string DisplayUserName, string PassWord, string TypeAccount)
        {
            this.UserName = UserName;
            this.DisplayUserName = DisplayUserName;
            this.PassWord = PassWord;
            this.TypeAccount = TypeAccount;
        }
        public AccountDTO(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayUserName = row["DisplayUserName"].ToString();
            this.PassWord = row["PassWord"].ToString();
            this.TypeAccount = row["TypeAccount"].ToString();
        }
        static string userName;
        private string displayUserName;
        private string passWord;
        private string typeAccount;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string DisplayUserName
        {
            get { return displayUserName; }
            set { displayUserName = value; }
        }
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        public string TypeAccount
        {
            get { return typeAccount; }
            set { typeAccount = value; }
        }
    }
}
