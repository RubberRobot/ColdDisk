namespace ColdDisk.FileSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    /// <summary>
    /// Represents a file
    /// </summary>
    public class File
    {
        /// <summary>
        /// The original file's path.
        /// </summary>
        private string _Path = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public File(string path)
        {
            this._Path = path;
        }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public FileInfo FileName { get; set; }

        /// <summary>
        /// Gets or sets the hash.
        /// </summary>
        /// <value>The hash.</value>
        public byte[] Hash { get; set; }

        /// <summary>
        /// Scans the file. This must be run on object creation.
        /// </summary>
        public void ScanFile()
        {
            this.FileName = new FileInfo(this._Path);
            using (var fs = System.IO.File.Open(this._Path, FileMode.Open, FileAccess.Read))
            {
                var hasher = SHA256Managed.Create();
                this.Hash = hasher.ComputeHash(fs);
            }
        }
    }
}