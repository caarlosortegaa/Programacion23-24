using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdupCopy
{
    public class FileInfo
    {
        public string Path { get; set; }
        public string ContainerPath { get; set; }
        public double Length { get; set; }
        public int HashLOng { get; set; }     
        public string HashSTring { get; set; }   
        public bool IsDisabled { get; set; }
        public string NewPath { get; set; }

    }
}
