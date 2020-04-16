namespace ChamThi
{
    partial class frmScanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSoBai = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.P = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(72, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn cổng COM:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.ForeColor = System.Drawing.Color.Red;
            this.btnKetNoi.Location = new System.Drawing.Point(297, 70);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(85, 28);
            this.btnKetNoi.TabIndex = 2;
            this.btnKetNoi.Text = "Kết nối!";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblSoBai
            // 
            this.lblSoBai.AutoSize = true;
            this.lblSoBai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSoBai.Location = new System.Drawing.Point(81, 144);
            this.lblSoBai.Name = "lblSoBai";
            this.lblSoBai.Size = new System.Drawing.Size(64, 13);
            this.lblSoBai.TabIndex = 5;
            this.lblSoBai.Text = "Số bài quét:";
            // 
            // btnScan
            // 
            this.btnScan.ForeColor = System.Drawing.Color.Red;
            this.btnScan.Location = new System.Drawing.Point(297, 140);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(85, 27);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Quét";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // frmScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(441, 292);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lblSoBai);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmScanForm";
            this.Text = "ScanForm";
            this.Load += new System.EventHandler(this.frmScanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSoBai;
        private System.Windows.Forms.Button btnScan;
        private System.IO.Ports.SerialPort P;
    }
}