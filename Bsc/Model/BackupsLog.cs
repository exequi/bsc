using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc.Model
{
    class BackupsLog
    {
        public MasterFile File { get; set; }
       
        public string SlaveName { get; set; }

        public int DownStatus { get; set; }

        public DateTime DownTime { get; set; }
    }
}
