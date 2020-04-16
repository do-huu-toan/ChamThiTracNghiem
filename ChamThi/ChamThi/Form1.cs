using ChamThi.models;
using ChamThi.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Security.AccessControl;
using System.Security.Principal;
using Action = System.Action;

namespace ChamThi
{
    
    public partial class frmChamThi : Form
    {
        private const string pathResultFile = @"C:\PhanMemChamThi";
        private int totalProcess = 0;
        private bool isProcessing = false;
        public frmChamThi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void frmChamThi_Shown(object sender, EventArgs e)
        {
            ChangeSelectInFile();
        }

        private void frmChamThi_Activated(object sender, EventArgs e)
        {
           
        }

        private void rdoCungFile_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSelectInFile();
        }

        private void ChangeSelectInFile()
        {
            if (rdoCungFile.Checked)
            {
                grbDapAn.Text = "Đáp án và bài làm";
                grbBaiLam.Visible = false;
                lblSheetBaiLam1.Visible = true;
                numericUpDownBaiLam.Visible = true;
            }
            else
            {
                grbDapAn.Text = "Đáp án";
                grbBaiLam.Visible = true;
                lblSheetBaiLam1.Visible = false;
                numericUpDownBaiLam.Visible = false;
            }
        }

        private void btnChonDapAn_Click(object sender, EventArgs e)
        {
            //Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtPathDapAn.Text = openFileDialog1.FileName;
            }
        }

        private void btnChonBaiLam_Click(object sender, EventArgs e)
        {
            //Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtPathBaiLam.Text = openFileDialog1.FileName;
            }
        }

        
        private void btnChamThi_Click(object sender, EventArgs e)
        {
            if (isProcessing)
            {
                return;
            }
            //totalProcess là Tổng % xử lý
            totalProcess = 0;
            SetProgressValue();
            string pathFileDapAn = txtPathDapAn.Text.Trim(); //trim là bỏ khoảng trắng hai đầu của chuỗi
            int sheetDapAn = (int)numericUpDownDapAn.Value; //ép kiểu sang kiểu int lấy thứ tự sheet

            try
            {
                if (rdoCungFile.Checked)//Cùng file đc chọn
                {
                    if (string.IsNullOrEmpty(pathFileDapAn))
                    {
                        MessageBox.Show("Hãy chọn file đáp án và bài làm", "Chọn File", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    if (sheetDapAn <= 0)
                    {
                        MessageBox.Show("Hãy chọn sheet đáp án", "Chọn sheet", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    int sheetBailam = (int) numericUpDownBaiLam.Value;
                    if (sheetBailam <= 0)
                    {
                        MessageBox.Show("Hãy chọn sheet bài làm", "Chọn sheet", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    isProcessing = true;
                    ProcessData(pathFileDapAn, sheetDapAn, pathFileDapAn, sheetBailam);
                }
                else
                {

                    if (string.IsNullOrEmpty(pathFileDapAn))
                    {
                        MessageBox.Show("Hãy chọn file đáp án", "Chọn File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (sheetDapAn <= 0)
                    {
                        MessageBox.Show("Hãy chọn sheet đáp án", "Chọn sheet", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    string pathFileBaiLam = txtPathBaiLam.Text.Trim();
                    if (string.IsNullOrEmpty(pathFileBaiLam))
                    {
                        MessageBox.Show("Hãy chọn file bài làm", "Chọn File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int sheetBailam = (int) numericUpDownBaiLam2.Value;
                    if (sheetBailam <= 0)
                    {
                        MessageBox.Show("Hãy chọn sheet bài làm", "Chọn sheet", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    isProcessing = true;
                    ProcessData(pathFileDapAn, sheetDapAn, pathFileBaiLam, sheetBailam);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý", "Thông Báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            isProcessing = false;
        }

        private void ProcessData(string pathFileDapAn, int sheetDapAn, string pathFileBaiLam,int sheetBailam)
        {
            totalProcess = 5;
            SetProgressValue();

            List<DeThi> lsDethi = null;
            Task taskParseDethi = Task.Factory.StartNew(() =>
            {
                lsDethi = ProcessHelper.ProcessDeThi(pathFileDapAn, sheetDapAn); // xử lý đáp án
            });
            taskParseDethi.Wait();
            totalProcess = totalProcess + 15;
            SetProgressValue();
            if (lsDethi != null)
            {
                string pathFileResult = "";
                Task taskProcessBaiLam = Task.Factory.StartNew(() =>
                {
                    pathFileResult =
                        ProcessBaiLam(pathFileBaiLam,sheetBailam, lsDethi); //xử lý bài làm
                });
                taskProcessBaiLam.Wait();
                if (!string.IsNullOrEmpty(pathFileResult))
                {
                    // opens the folder in explorer - tự open folder
                    Process.Start(pathFileResult);
                }
            }
            else
            {
                MessageBox.Show("File đáp án không đúng định dạng, hãy kiểm tra lại file", "Chọn File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string ProcessBaiLam(string pathFileBaiLam, int sheetBaiLam, List<DeThi> lsDethi)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(pathFileBaiLam);
            _Worksheet xlWorksheet = xlWorkbook.Sheets[sheetBaiLam];
            Range xlRange = xlWorksheet.UsedRange;

            List<BaiLam> lsBaiLam = ParseBaiLam(xlRange,lsDethi);
            //xuất ra file kết quả excel
            var isSetTitle = false;
            foreach (var item in lsBaiLam)
            {
                if (!isSetTitle)
                {
                    xlRange.Cells[1, item.columnIndexResult].Value2 = "Điểm";
                    xlRange.Cells[1, item.columnIndexResult].Font.Color = Color.Red;
                    isSetTitle = true;
                }
                xlRange.Cells[item.rowIndex, item.columnIndexResult].Value2 = item.TongDiem;
                xlRange.Cells[item.rowIndex, item.columnIndexResult].Font.Color = Color.Red;
                foreach (var itemDapAn in item.DapAns)
                {
                    if (itemDapAn.isCorrect)
                    {
                        xlRange.Cells[itemDapAn.rowIndex, itemDapAn.colIndex].Font.Color = Color.Red;
                    }
                }
            }

            totalProcess = totalProcess + 20;
            SetProgressValue();

            if (!Directory.Exists(pathResultFile))
            {
                Directory.CreateDirectory(pathResultFile);
            }
            string pathFileResult = pathResultFile + "\\ketqua_" + Guid.NewGuid() + ".xlsx";
            xlWorkbook.SaveAs(pathFileResult);

            totalProcess = totalProcess + 10;
            SetProgressValue();
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

            return pathResultFile;
        }

        
        public List<BaiLam> ParseBaiLam(Range xlRange,List<DeThi> lsDethi)
        {
            if (xlRange == null)
            {
                return null; ;
            }
            List<BaiLam> lsBaiLam = new List<BaiLam>();
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            int indexColData = 0;
            int lengthSBD = 6; //nếu tăng lên n thì khai thêm la n
            int lengthMade = 3;

            bool checkParseData = false;
           
            //check data
            for (int i = 1; i <= rowCount; i++)
            {
                BaiLam baiLam = null;
                //get row and col for starting parseData
                if (!checkParseData) { 
                    for (int j = 1; j <= colCount; j++)
                    {
                        if (xlRange.Cells[i, j] != null)
                        {
                            object value = xlRange.Cells[i, j].Value2;
                            if (value != null)
                            {
                                if (value.ToString().Trim().Replace(" ", "").Equals("Filename", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    checkParseData = true;
                                    indexColData = j;
                                    totalProcess = totalProcess + 20;
                                    SetProgressValue();
                                    break;
                                }
                            }
                        }
                    }
                } else {
                    var page = xlRange.Cells[i, indexColData].Value2;
                    if (!string.IsNullOrEmpty(FuncUtils.GetStringValue(page)))
                    {
                        baiLam = new BaiLam();
                        baiLam.rowIndex = i;
                        //parse SBD
                        var sbdUse = new StringBuilder();
                        for (int j = indexColData + 1; j <= indexColData + lengthSBD; j++)
                        {
                            object value = xlRange.Cells[i, j].Value2;
                            //if (value != null){ //không có sbd vẫn làm tiếp                            
                                sbdUse.Append(FuncUtils.GetStringValue(value));
                            //}
                        }
                        if (!string.IsNullOrEmpty(sbdUse.ToString()))
                        {
                            baiLam.SBD = sbdUse.ToString();
                            //parse made
                            var made = new StringBuilder();
                            for (int j = (indexColData + lengthSBD + 1); j <= (indexColData + lengthSBD + lengthMade); j++)
                            {
                                object value = xlRange.Cells[i, j].Value2;
                                //if (value != null) //mã đề thiếu vẫn làm
                                //{
                                    made.Append(FuncUtils.GetStringValue(value));
                                //}
                            }
                            baiLam.MaDe = made.ToString();

                            //parse bai lam
                            var startIndex = indexColData + lengthSBD + lengthMade;
                            var cauIndex = 0;
                            var lsDapAn = new List<DapAn>();
                            for (int j = startIndex + 1; j <= colCount; j++)
                            {
                                object value = xlRange.Cells[i, j].Value2;
                                /*if (value != null)
                                {*/
                                    cauIndex++;
                                    lsDapAn.Add(new DapAn()
                                    {
                                        Cau = cauIndex,
                                        Result = FuncUtils.GetStringValue(value),
                                        colIndex = j,
                                        rowIndex = i
                                    });
                                /*}*/
                            }
                            var maxObject = lsDapAn.OrderByDescending(item => item.colIndex).First();
                            baiLam.columnIndexResult = maxObject.colIndex + 1; //lấy index cột cuối cùng
                            baiLam.DapAns = lsDapAn;
                        }

                    }
                }
                if (baiLam != null && !string.IsNullOrEmpty(baiLam.SBD) && !string.IsNullOrEmpty(baiLam.MaDe))
                {
                    lsBaiLam.Add(baiLam);
                }
            }
            if (!checkParseData)
            {
                throw new NotSupportedException("File bài làm lỗi");
            }
            totalProcess = totalProcess + 20;
            SetProgressValue();
            CalculateDiem(lsBaiLam, lsDethi);
            totalProcess = totalProcess + 10;
            SetProgressValue();
            return lsBaiLam;
        }


        public List<BaiLam> CalculateDiem(List<BaiLam> lsBaiLam, List<DeThi> lsDethi)
        {
            var heso = txtHeSoDiem.Value;
            foreach (var bailam in lsBaiLam)// chạy để so sánh đáp án và bài làm
            {
                //lấy đáp án theo mã đề bài làm.
                var de = lsDethi.FirstOrDefault(x => x.MaDe.Equals(bailam.MaDe,StringComparison.CurrentCultureIgnoreCase));
                if (de != null && bailam.DapAns != null)
                {
                    int totalCorrect = 0;
                    int totalInCorrect = 0;
                    foreach (var item in bailam.DapAns)
                    {
                        var dap = de.DapAns.FirstOrDefault(d=>d.Cau == item.Cau);
                        if (!string.IsNullOrEmpty(dap.Result) && dap.Result.Equals(item.Result, StringComparison.CurrentCultureIgnoreCase))
                        {
                            totalCorrect++;
                            item.isCorrect = true;
                        }
                        else
                        {
                            totalInCorrect++;
                        }
                        
                    }

                    bailam.TongDiem = ((float)totalCorrect) * ((float)heso);
                }
            }
            return lsBaiLam;
        }

        /// <summary>
        /// chay % tiến trình
        /// </summary>
        private void SetProgressValue()
        {
            var progressValue = "";
            if (totalProcess < 100 && totalProcess > 0)
            {
                progressValue = "Đang xử lý..." + "(" + totalProcess + "%)";
            }
            else
            {
                progressValue = "Chấm thi " + "(" + totalProcess + "%)";
            }
            //btnChamThi.Text = progressValue;
        }

        private void cbEditHeSo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditHeSo.Checked)
            {
                txtHeSoDiem.Enabled = true;
            }
            else
            {
                txtHeSoDiem.Enabled = false;
            }
        }
    }   
}
