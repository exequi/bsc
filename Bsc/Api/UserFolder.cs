using Bsc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc.Api
{
    class UserFolder
    {
        Account account = Account.Load();

        public UserFolder()
        {

        }
        public List<Folder> GetMasterFolder()
        {
            return new List<Folder>();
        }

        public bool AddMasterFolder(string path)
        {
            return true;
        }


        internal bool DeleteMasterFolder(string path)
        {
            return true;
        }

        public List<Folder> GetSlaveFolder(string path)
        {
            return new List<Folder>();
        }
    }
}
