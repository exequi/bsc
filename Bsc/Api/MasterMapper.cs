using Bsc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc.Api
{
    class MasterMapper
    {
        public Folder MasterFolder { get; set; }
        public Folder SlaveFolder { get; set; }


        public override string ToString()
        {
            return string.Format("{0}:{1} => {2}{3}", MasterFolder.MachineAccount.UserName,
                MasterFolder.Path, SlaveFolder.MachineAccount.UserName, SlaveFolder.Path);
        }

        public List<MasterMapper> GetUserMapper(string slaveUserId)
        {
            return new List<MasterMapper>();
        }
    }
}
