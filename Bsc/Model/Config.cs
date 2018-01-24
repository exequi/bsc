using Bsc.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc.Model
{
    class Config
    {
        public string ApiHost { get; set; }

        public string UpInterval { get; set; }

        public string DownInterval { get; set; }


        public bool AutoStart { get; set; }

        public bool UpRigthNow { get; set; }


        public bool[] AutoFile { get; set; }


        public List<string> IgnoreRule { get; set; }

        public static string IniPath = string.Format("{0}\\{1}", System.Environment.CurrentDirectory, "app.ini");


        public Config()
        {

        }

        public bool Update()
        {
            var f = new IniFile(Config.IniPath);
            f.IniWriteValue("normal", "ApiHost", this.ApiHost);
            f.IniWriteValue("normal", "UpInterval", this.UpInterval);
            f.IniWriteValue("normal", "DownInterval", this.DownInterval);
            f.IniWriteValue("normal", "AutoStart", this.AutoStart.ToString());
            f.IniWriteValue("normal", "UpRigthNow", this.UpRigthNow.ToString());
            f.IniWriteValue("normal", "AutoNewFile", this.AutoFile[0].ToString());
            f.IniWriteValue("normal", "AutoUpdateFile", this.AutoFile[1].ToString());
            f.IniWriteValue("normal", "AutoDeleteFile", this.AutoFile[2].ToString());
            f.IniWriteValue("ext", "IgnoreRule", string.Join(";",this.IgnoreRule));
            return true;
        }

        public static Config Load()
        {
            var f = new IniFile(IniPath);
            return new Config()
            {
                ApiHost = f.IniReadValue("normal", "ApiHost"),
                UpInterval = f.IniReadValue("normal", "UpInterval"),
                DownInterval = f.IniReadValue("normal", "DownInterval"),
                AutoStart = Convert.ToBoolean(f.IniReadValue("normal", "AutoStart")),
                UpRigthNow = Convert.ToBoolean(f.IniReadValue("normal", "UpRigthNow")),
                AutoFile = new bool[]{Convert.ToBoolean(f.IniReadValue("normal", "AutoNewFile")),
                    Convert.ToBoolean(f.IniReadValue("normal", "AutoUpdateFile")),
                    Convert.ToBoolean(f.IniReadValue("normal", "AutoDeleteFile"))},
                IgnoreRule = f.IniReadValue("ext", "IgnoreRule").Split(';').ToList()
            };
        }
    }
}
