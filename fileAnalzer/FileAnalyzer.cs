using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileAnalzer
{
    public class FileAnalyzer
    {
        private AnalysisResulte _resulte;
        public AnalysisResulte GetResulte()
        {
            return _resulte;

        }
        public void SetResulte(AnalysisResulte resulte)
        {
            _resulte = resulte;

        }
    }
}
