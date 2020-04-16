using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ChamThi.models;
using Microsoft.Office.Interop.Excel;

namespace ChamThi.utils
{
    class ProcessHelper
    {
        private static int totalProcess = 0;

        #region Process Bai De thi
        public static List<DeThi> ProcessDeThi(string pathFileDapAn, int sheetDapAn)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(pathFileDapAn);
            _Worksheet xlWorksheet = xlWorkbook.Sheets[sheetDapAn];
            Range xlRange = xlWorksheet.UsedRange;

            List<DeThi> lsDeThi = ParseMaDe(xlRange);
            lsDeThi = ParseDapAn(xlRange, lsDeThi);

            //cleanup
            GC.Collect();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            return lsDeThi;
        }


        public static List<DeThi> ParseMaDe(Range xlRange)
        {
            if (xlRange == null)
            {
                return null; 
            }

            List<DeThi> lsDeThi = new List<DeThi>();
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            int colCau = 0;
            for (int i = 1; i <= rowCount; i++)
            {
                bool parseMaDe = false;
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] != null && !parseMaDe)
                    {
                        object value = xlRange.Cells[i, j].Value2;
                        if (value != null)
                        {
                            if (value.ToString().Replace(" ","").Replace("/","").Trim().Equals("Mãcâuhỏi", StringComparison.CurrentCultureIgnoreCase))
                            {
                                parseMaDe = true;
                                colCau = j;
                            }
                        }
                    }
                    else if (parseMaDe)
                    {
                        //process ma de thi
                        if (xlRange.Cells[i, j] != null)
                        {
                            object value = xlRange.Cells[i, j].Value2;
                            if (value != null)
                            {
                                lsDeThi.Add(new DeThi()
                                {
                                    MaDe = FuncUtils.GetStringValue(value),
                                    rowIndex = i,
                                    columnIndex = j,
                                    columnIndexCau = (colCau > 0? colCau:1)
                                });
                            }
                        }
                    }
                }
                if (parseMaDe)
                {
                    break;
                }
            }
            return lsDeThi;
        }

        public static List<DeThi> ParseDapAn(Range xlRange, List<DeThi> lsDeThi)
        {
            if (xlRange == null && lsDeThi != null && lsDeThi.Any())
            {
                return null;
            }
            foreach (var item in lsDeThi)
            {
                int rowIndex = item.rowIndex;
                int colIndex = item.columnIndex;
                bool hasValue = true;
                List<DapAn> lsDapAn = null;
                while (hasValue)
                {
                    rowIndex++;
                    if (xlRange.Cells[rowIndex, colIndex] != null)
                    {
                        if (lsDapAn == null)
                        {
                            lsDapAn = new List<DapAn>();
                        }
                        var colIndexCau = item.columnIndexCau;
                        object valueCau = xlRange.Cells[rowIndex, colIndexCau].Value2;
                        int cau = 0;
                        if (valueCau != null)
                        {
                            cau = FuncUtils.GetIntValue(valueCau.ToString());
                        }
                        object value = xlRange.Cells[rowIndex, colIndex].Value2;
                        if (value != null && cau > 0)
                        {
                            lsDapAn.Add(new DapAn()
                            {
                                Cau = cau,
                                Result = value.ToString()
                            });
                        }
                        else
                        {
                            hasValue = false;
                            break;
                        }
                    }
                    else
                    {
                        hasValue = false;
                        break;
                    }

                }

                item.DapAns = lsDapAn;
            }
            return lsDeThi;
        }

        #endregion
      
    }
}
