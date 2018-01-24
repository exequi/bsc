using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc.Model
{
    class Folder
    {
        public string Id { get; set; }
        public Account MachineAccount { get; set; }
        public DateTime CreateTime { get; set; }
        public string Path { get; set; }

        public Folder()
        {

        }

        public Folder(string path, Account account)
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreateTime = DateTime.Now;
            this.Path = path;
            this.MachineAccount = account;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}",MachineAccount.UserName,Path);
        }
    }
}
