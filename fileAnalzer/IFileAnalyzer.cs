using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileAnalzer
{
    public interface IFileAnalyzer
    {
        void AnalyzeFile(FileInfo fileInfo);
    }
}
