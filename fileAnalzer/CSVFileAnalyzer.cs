using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileAnalzer
{
    public class CSVFileAnalyzer : FileAnalyzer ,IFileAnalyzer
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] FileString = File.ReadAllLines(fileInfo.FullName);
           var rowElements = FileString[0].Split(',');
            AnalysisResulte resulte = new AnalysisResulte();
            resulte.FieldCount = rowElements.Length;

            SetResulte(resulte);
        }
    }
}
