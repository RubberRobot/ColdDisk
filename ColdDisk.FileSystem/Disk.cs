using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdDisk.FileSystem
{
    internal class Disk
    {
        public DateTime CreationData = default(DateTime);

        public Disk()
        {
            this.CreationData = DateTime.Now();
        }

        public int Identifier { get; set; }

        public Folder RootDirectory { get; set; }
    }
}