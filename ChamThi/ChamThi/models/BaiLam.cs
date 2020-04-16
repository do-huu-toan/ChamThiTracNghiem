using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamThi.models
{
    public class BaiLam
    {
        public string SBD { get; set; }
        public string MaDe { get; set; }
        public List<DapAn> DapAns { get; set; }       

        public float TongDiem { get; set; }

        public int rowIndex { get; set; }

        public int columnIndex { get; set; }

        public int columnIndexResult { get; set; }
    }
}
