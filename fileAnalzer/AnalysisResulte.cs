using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileAnalzer
{
    public struct AnalysisResulte
    {
        public int WordCount { get; set; }
        public int CharachterCount { get; set; }
        public int LineCount { get; set; }
        public int FieldCount { get; set; }
    }
}
