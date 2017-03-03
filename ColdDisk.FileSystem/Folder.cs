using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdDisk.FileSystem
{
    class Folder
    {
        public List<File> Files { get; set; }

        public List<Folder> Subfolders { get; set; }

        public string FileName { get; set; }
    }
}
