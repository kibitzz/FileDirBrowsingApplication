using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorerApp.Entities
{
    public class FileDir
    {
        public string Name { get; set; }

        public bool isDir { get; set; }     

        public long Length { get; set; }
    }



}
