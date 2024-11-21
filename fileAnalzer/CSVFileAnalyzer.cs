using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileAnalzer
{
    public class CSVFileAnalyzer : IFileAnalyzer
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] FileString = File.ReadAllLines(fileInfo.FullName);
            AnalysisResulte resulte = new AnalysisResulte();
        }
    }
}
