using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc.Model
{
    class MasterFile
    {
        public string Id { get; set; }
        public Account MasterMachine { get; set; }
        public DateTime CreateTime { get; set; } 
        public string FileName { get; set; }

        public string Md5 { get; set; }
    }
}
