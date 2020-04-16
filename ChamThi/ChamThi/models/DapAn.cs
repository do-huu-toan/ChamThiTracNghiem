using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamThi.models
{
    public class DapAn
    {
        public int Cau { get; set; }
        public string Result { get; set; }

        public bool isCorrect { get; set; }

        public int rowIndex { get; set; }

        public int colIndex { get; set; }
    }
}
