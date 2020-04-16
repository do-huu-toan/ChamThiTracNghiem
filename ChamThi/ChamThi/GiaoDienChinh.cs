using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChamThi
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            frmScanForm frm = new frmScanForm();
            frm.Show();

        }

        private void btnXuLyAnh_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\FormScanner_1.1.2\bin\FormScanner.exe");
        }

        private void btnGhepDiem_Click(object sender, EventArgs e)
        {
            frmChamThi frm = new frmChamThi();
            frm.Show();
        }

        private void showHelp(object sender, EventArgs e) {
            MessageBox.Show("OKKKK2", "Chọn File", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OKKKK1", "Chọn File", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
        }
    }
}
