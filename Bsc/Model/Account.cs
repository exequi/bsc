using Bsc.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc.Model
{
    class Account
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }



        public bool Register(string account, string passwd)
        {
            var f = new IniFile(Config.IniPath);
            f.IniWriteValue("account", "username", account);
            f.IniWriteValue("account", "password", passwd);
            return true;
        }

        public bool Login(string account, string passwd)
        {
            return true;
        }

        public static Account Load()
        {
            var f = new IniFile(Config.IniPath);
            Account a = new Account();
            a.UserName = f.IniReadValue("account", "username");
            a.Password = f.IniReadValue("account", "password");
            return a;
        }


        public bool IsPass()
        {
            return !string.IsNullOrEmpty(this.UserName) && !string.IsNullOrEmpty(this.Password);
        }

    }
}
