using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ChamThi
{
    public partial class frmScanForm : Form
    {
        public frmScanForm()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
               //P.PortName = comboBox1.Text;
           if(!P.IsOpen)
           {
               if (comboBox1.Text == "")
               {
                   MessageBox.Show(" Chưa kết nối máy quét!");
               }
               else
               {
                   P.PortName = comboBox1.Text;
                   P.Open();
                   btnKetNoi.Text = " Đã kết nối";
                   
                   

            }
               
            }
           //else { P.Close(); }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Nhập số bài cần quét"); }
            else 
            {
                P.Write(textBox1.Text);
                textBox1.Text = "";
                MessageBox.Show("Đã gửi số bài cần quét");
            }
            
                         
        }

        private void frmScanForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }
    }
}
