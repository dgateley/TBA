using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TBA.Util
{
    public class FileInfo
    {
        /// <summary>
        /// Contains information about an executable
        /// </summary>
        public class HeaderInfo
        {
            // The intended architecture
            public ushort machine;

            // Number of sectiosn
            public ushort sections;

            // When it was compiled 
            public DateTime timestamp;

            // Size of code
            public uint codesize;
        }

        // The path to the file
        public string Path { get; set; }

        // The size of the file in bytes
        public long Size { get; set; }

        // The content of the file
        public List<byte> Bytes { get; set; }

        // The extension of the file
        public string Extension { get; set; }

        // If the file is an executable
        public bool IsExecutable { get; set; }

        // Header information for executables
        public HeaderInfo PEInfo { get; set; } = new HeaderInfo();

        // If the file is an image
        public bool IsImage { get; set; }

        public FileInfo(string path)
        {
            try
            {
                // Set properties

                // Set path
                Path = path;

                // Read file
                Bytes = File.ReadAllBytes(path).ToList();
                Size = Bytes.Count;
                Extension = System.IO.Path.GetExtension(path);
                IsExecutable = (Extension == ".exe") ? true : false;
                IsImage = (Extension == ".png" || Extension == ".jpg" || Extension == ".jpeg");

                // If it's an executable, get some information from the PE header
                if (IsExecutable)
                {
                    // "Magic number"
                    ushort magic = BitConverter.ToUInt16(Bytes.ToArray(), 0);
                    if (magic != 0x5a4d)
                    {
                        // File isn't in PE format
                        System.Windows.Forms.MessageBox.Show("File is not a real Windows Portable Executable. Please fix the file extension.");
                        IsExecutable = false;
                    }

                    // Get arch
                    uint header = BitConverter.ToUInt32(Bytes.ToArray(), 0x3c);
                    PEInfo.machine = BitConverter.ToUInt16(Bytes.ToArray(), (int)header + 4);

                    // Get # of sections
                    PEInfo.sections = BitConverter.ToUInt16(Bytes.ToArray(), (int)header + 6);

                    // Get Date
                    PEInfo.timestamp = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(BitConverter.ToUInt32(Bytes.ToArray(), (int)header + 8));

                    // Get # of symbols
                    PEInfo.codesize = BitConverter.ToUInt32(Bytes.ToArray(), (int)header + 28);


                   // System.Windows.Forms.MessageBox.Show(PEInfo.codesize.ToString());

                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("File could not be opened. Please try again.", "Error opening file");
                return;
            }
            
        }


        // Size to formatted string
        public static string GetPrettySize(long size)
        {
            string[] units = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };

            if (size == 0)
                return "0" + units[0];
            long bytes = Math.Abs(size);

            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);

            return (Math.Sign(size) * num).ToString() + units[place];
        }
    }
}
