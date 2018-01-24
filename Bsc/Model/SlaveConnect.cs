using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc.Model
{
    class SlaveConnect
    {
        public string Id { get; set; }
        public Folder MasterFolder { get; set; }

        public Folder SlaveFolder { get; set; }
    }
}
