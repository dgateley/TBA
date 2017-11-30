using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA.Util
{
    class FileInfo
    {
        // The path to the file
        public string Path { get; set; }

        // The size of the file in bytes
        public int Size { get; set; }

        
        
        public FileInfo(string path, int size)
        {
            // Set properties
            Path = path;
            Size = size;
        }
    }
}
