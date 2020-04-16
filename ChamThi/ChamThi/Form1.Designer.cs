namespace ChamThi
{
    partial class frmChamThi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEditHeSo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeSoDiem = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbDapAn = new System.Windows.Forms.GroupBox();
            this.panelSheet = new System.Windows.Forms.Panel();
            this.numericUpDownBaiLam = new System.Windows.Forms.NumericUpDown();
            this.lblSheetBaiLam1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDapAn = new System.Windows.Forms.NumericUpDown();
            this.txtPathDapAn = new System.Windows.Forms.TextBox();
            this.btnChonDapAn = new System.Windows.Forms.Button();
            this.grbBaiLam = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownBaiLam2 = new System.Windows.Forms.NumericUpDown();
            this.lblSheetBaiLam2 = new System.Windows.Forms.Label();
            this.btnChonBaiLam = new System.Windows.Forms.Button();
            this.txtPathBaiLam = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoKhacFile = new System.Windows.Forms.RadioButton();
            this.rdoCungFile = new System.Windows.Forms.RadioButton();
            this.btnChamThi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeSoDiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grbDapAn.SuspendLayout();
            this.panelSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaiLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDapAn)).BeginInit();
            this.grbBaiLam.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaiLam2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEditHeSo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHeSoDiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnChamThi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbEditHeSo
            // 
            this.cbEditHeSo.AutoSize = true;
            this.cbEditHeSo.Location = new System.Drawing.Point(401, 408);
            this.cbEditHeSo.Name = "cbEditHeSo";
            this.cbEditHeSo.Size = new System.Drawing.Size(15, 14);
            this.cbEditHeSo.TabIndex = 11;
            this.cbEditHeSo.UseVisualStyleBackColor = true;
            this.cbEditHeSo.CheckedChanged += new System.EventHandler(this.cbEditHeSo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "(cho 1 câu đúng)";
            // 
            // txtHeSoDiem
            // 
            this.txtHeSoDiem.DecimalPlaces = 2;
            this.txtHeSoDiem.Enabled = false;
            this.txtHeSoDiem.Location = new System.Drawing.Point(228, 407);
            this.txtHeSoDiem.Name = "txtHeSoDiem";
            this.txtHeSoDiem.Size = new System.Drawing.Size(56, 20);
            this.txtHeSoDiem.TabIndex = 9;
            this.txtHeSoDiem.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Điểm";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.grbDapAn);
            this.groupBox3.Controls.Add(this.grbBaiLam);
            this.groupBox3.Location = new System.Drawing.Point(20, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 263);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // grbDapAn
            // 
            this.grbDapAn.Controls.Add(this.panelSheet);
            this.grbDapAn.Controls.Add(this.txtPathDapAn);
            this.grbDapAn.Controls.Add(this.btnChonDapAn);
            this.grbDapAn.Location = new System.Drawing.Point(17, 19);
            this.grbDapAn.Name = "grbDapAn";
            this.grbDapAn.Size = new System.Drawing.Size(517, 116);
            this.grbDapAn.TabIndex = 3;
            this.grbDapAn.TabStop = false;
            this.grbDapAn.Text = "Đáp án";
            // 
            // panelSheet
            // 
            this.panelSheet.Controls.Add(this.numericUpDownBaiLam);
            this.panelSheet.Controls.Add(this.lblSheetBaiLam1);
            this.panelSheet.Controls.Add(this.label1);
            this.panelSheet.Controls.Add(this.numericUpDownDapAn);
            this.panelSheet.Location = new System.Drawing.Point(6, 60);
            this.panelSheet.Name = "panelSheet";
            this.panelSheet.Size = new System.Drawing.Size(505, 40);
            this.panelSheet.TabIndex = 3;
            // 
            // numericUpDownBaiLam
            // 
            this.numericUpDownBaiLam.Location = new System.Drawing.Point(347, 9);
            this.numericUpDownBaiLam.Name = "numericUpDownBaiLam";
            this.numericUpDownBaiLam.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBaiLam.TabIndex = 3;
            // 
            // lblSheetBaiLam1
            // 
            this.lblSheetBaiLam1.AutoSize = true;
            this.lblSheetBaiLam1.Location = new System.Drawing.Point(265, 13);
            this.lblSheetBaiLam1.Name = "lblSheetBaiLam1";
            this.lblSheetBaiLam1.Size = new System.Drawing.Size(74, 13);
            this.lblSheetBaiLam1.TabIndex = 2;
            this.lblSheetBaiLam1.Text = "Sheet bài làm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sheet đáp án:";
            // 
            // numericUpDownDapAn
            // 
            this.numericUpDownDapAn.Location = new System.Drawing.Point(97, 11);
            this.numericUpDownDapAn.Name = "numericUpDownDapAn";
            this.numericUpDownDapAn.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDapAn.TabIndex = 1;
            // 
            // txtPathDapAn
            // 
            this.txtPathDapAn.Enabled = false;
            this.txtPathDapAn.Location = new System.Drawing.Point(22, 28);
            this.txtPathDapAn.Name = "txtPathDapAn";
            this.txtPathDapAn.Size = new System.Drawing.Size(395, 20);
            this.txtPathDapAn.TabIndex = 0;
            // 
            // btnChonDapAn
            // 
            this.btnChonDapAn.Location = new System.Drawing.Point(423, 26);
            this.btnChonDapAn.Name = "btnChonDapAn";
            this.btnChonDapAn.Size = new System.Drawing.Size(75, 22);
            this.btnChonDapAn.TabIndex = 2;
            this.btnChonDapAn.Text = "Chọn File";
            this.btnChonDapAn.UseVisualStyleBackColor = true;
            this.btnChonDapAn.Click += new System.EventHandler(this.btnChonDapAn_Click);
            // 
            // grbBaiLam
            // 
            this.grbBaiLam.Controls.Add(this.panel1);
            this.grbBaiLam.Controls.Add(this.btnChonBaiLam);
            this.grbBaiLam.Controls.Add(this.txtPathBaiLam);
            this.grbBaiLam.Location = new System.Drawing.Point(19, 141);
            this.grbBaiLam.Name = "grbBaiLam";
            this.grbBaiLam.Size = new System.Drawing.Size(515, 103);
            this.grbBaiLam.TabIndex = 4;
            this.grbBaiLam.TabStop = false;
            this.grbBaiLam.Text = "Bài làm";
            this.grbBaiLam.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownBaiLam2);
            this.panel1.Controls.Add(this.lblSheetBaiLam2);
            this.panel1.Location = new System.Drawing.Point(6, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 40);
            this.panel1.TabIndex = 5;
            // 
            // numericUpDownBaiLam2
            // 
            this.numericUpDownBaiLam2.Location = new System.Drawing.Point(93, 9);
            this.numericUpDownBaiLam2.Name = "numericUpDownBaiLam2";
            this.numericUpDownBaiLam2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBaiLam2.TabIndex = 3;
            // 
            // lblSheetBaiLam2
            // 
            this.lblSheetBaiLam2.AutoSize = true;
            this.lblSheetBaiLam2.Location = new System.Drawing.Point(11, 13);
            this.lblSheetBaiLam2.Name = "lblSheetBaiLam2";
            this.lblSheetBaiLam2.Size = new System.Drawing.Size(74, 13);
            this.lblSheetBaiLam2.TabIndex = 2;
            this.lblSheetBaiLam2.Text = "Sheet bài làm:";
            // 
            // btnChonBaiLam
            // 
            this.btnChonBaiLam.Location = new System.Drawing.Point(422, 24);
            this.btnChonBaiLam.Name = "btnChonBaiLam";
            this.btnChonBaiLam.Size = new System.Drawing.Size(75, 23);
            this.btnChonBaiLam.TabIndex = 2;
            this.btnChonBaiLam.Text = "Chọn File";
            this.btnChonBaiLam.UseVisualStyleBackColor = true;
            this.btnChonBaiLam.Click += new System.EventHandler(this.btnChonBaiLam_Click);
            // 
            // txtPathBaiLam
            // 
            this.txtPathBaiLam.Enabled = false;
            this.txtPathBaiLam.Location = new System.Drawing.Point(21, 27);
            this.txtPathBaiLam.Name = "txtPathBaiLam";
            this.txtPathBaiLam.Size = new System.Drawing.Size(395, 20);
            this.txtPathBaiLam.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoKhacFile);
            this.groupBox2.Controls.Add(this.rdoCungFile);
            this.groupBox2.Location = new System.Drawing.Point(20, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 80);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa Chọn";
            // 
            // rdoKhacFile
            // 
            this.rdoKhacFile.AutoSize = true;
            this.rdoKhacFile.Location = new System.Drawing.Point(21, 46);
            this.rdoKhacFile.Name = "rdoKhacFile";
            this.rdoKhacFile.Size = new System.Drawing.Size(214, 17);
            this.rdoKhacFile.TabIndex = 1;
            this.rdoKhacFile.Text = "Đáp án và bài làm không trong cùng file";
            this.rdoKhacFile.UseVisualStyleBackColor = true;
            // 
            // rdoCungFile
            // 
            this.rdoCungFile.AutoSize = true;
            this.rdoCungFile.Checked = true;
            this.rdoCungFile.Location = new System.Drawing.Point(21, 22);
            this.rdoCungFile.Name = "rdoCungFile";
            this.rdoCungFile.Size = new System.Drawing.Size(181, 17);
            this.rdoCungFile.TabIndex = 0;
            this.rdoCungFile.TabStop = true;
            this.rdoCungFile.Text = "Đáp án và bài làm trong cùng file";
            this.rdoCungFile.UseVisualStyleBackColor = true;
            this.rdoCungFile.CheckedChanged += new System.EventHandler(this.rdoCungFile_CheckedChanged);
            // 
            // btnChamThi
            // 
            this.btnChamThi.Location = new System.Drawing.Point(20, 404);
            this.btnChamThi.Name = "btnChamThi";
            this.btnChamThi.Size = new System.Drawing.Size(128, 24);
            this.btnChamThi.TabIndex = 5;
            this.btnChamThi.Text = "Chấm Thi";
            this.btnChamThi.UseVisualStyleBackColor = true;
            this.btnChamThi.Click += new System.EventHandler(this.btnChamThi_Click);
            // 
            // frmChamThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 467);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChamThi";
            this.Text = "Ghép Điểm ";
            this.Activated += new System.EventHandler(this.frmChamThi_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmChamThi_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeSoDiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.grbDapAn.ResumeLayout(false);
            this.grbDapAn.PerformLayout();
            this.panelSheet.ResumeLayout(false);
            this.panelSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaiLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDapAn)).EndInit();
            this.grbBaiLam.ResumeLayout(false);
            this.grbBaiLam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaiLam2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChonDapAn;
        private System.Windows.Forms.TextBox txtPathDapAn;
        private System.Windows.Forms.Button btnChamThi;
        private System.Windows.Forms.GroupBox grbBaiLam;
        private System.Windows.Forms.Button btnChonBaiLam;
        private System.Windows.Forms.TextBox txtPathBaiLam;
        private System.Windows.Forms.GroupBox grbDapAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoKhacFile;
        private System.Windows.Forms.RadioButton rdoCungFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownBaiLam;
        private System.Windows.Forms.Label lblSheetBaiLam1;
        private System.Windows.Forms.NumericUpDown numericUpDownDapAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSheet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownBaiLam2;
        private System.Windows.Forms.Label lblSheetBaiLam2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtHeSoDiem;
        private System.Windows.Forms.CheckBox cbEditHeSo;
    }
}

