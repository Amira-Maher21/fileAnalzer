using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileAnalzer
{
    public class TextFileAnalyzer : FileAnalyzer, IFileAnalyzer 
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
             
          string FileString=  File.ReadAllText(fileInfo.FullName);
            AnalysisResulte resulte = new AnalysisResulte();
           var Words = FileString.Split(new char[] {' ','\n' ,'\r'});
            resulte.WordCount = Words.Length;
            resulte.CharachterCount = FileString.Length;
            var Lines = FileString.Split(new char[] { '\n' });
            resulte.LineCount = Lines.Length;

            SetResulte(resulte);
        }
    }
}
