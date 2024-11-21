using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIleAnalzer
{
    public static class FileInfoExtensions
    {
        public static bool IsTextFile(this FileInfo fileInfo) 
        {
            if (fileInfo.Extension == ".txt")
            {
                return true;
            }
            return false;    
        }
        public static bool IscsvFile(this FileInfo fileInfo) 
        {
            if (fileInfo.Extension == ".csv")
            {
                return true;
            }
            return false;    
        } 
    }
}
