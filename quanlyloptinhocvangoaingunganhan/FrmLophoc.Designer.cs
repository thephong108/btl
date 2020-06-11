namespace quanlyloptinhocvangoaingunganhan
{
    partial class FrmLophoc
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
            this.cboMaca = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gridviewLop = new System.Windows.Forms.DataGridView();
            this.txtSiso = new System.Windows.Forms.TextBox();
            this.cboNam1 = new System.Windows.Forms.ComboBox();
            this.cboThang1 = new System.Windows.Forms.ComboBox();
            this.cboNgay1 = new System.Windows.Forms.ComboBox();
            this.cboMamon = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNgay = new System.Windows.Forms.ComboBox();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaphong = new System.Windows.Forms.ComboBox();
            this.cboMathoigian = new System.Windows.Forms.ComboBox();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewLop)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaca
            // 
            this.cboMaca.FormattingEnabled = true;
            this.cboMaca.Location = new System.Drawing.Point(150, 203);
            this.cboMaca.Name = "cboMaca";
            this.cboMaca.Size = new System.Drawing.Size(144, 24);
            this.cboMaca.TabIndex = 60;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(942, 558);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 59;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(709, 558);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(484, 558);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(237, 558);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 56;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 558);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridviewLop
            // 
            this.gridviewLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malop,
            this.tenlop,
            this.Mamon,
            this.MaGv,
            this.NgayBD,
            this.NgayKT,
            this.MaCa,
            this.Mathoigian,
            this.Maphong,
            this.Siso});
            this.gridviewLop.Location = new System.Drawing.Point(13, 334);
            this.gridviewLop.Name = "gridviewLop";
            this.gridviewLop.RowTemplate.Height = 24;
            this.gridviewLop.Size = new System.Drawing.Size(1034, 184);
            this.gridviewLop.TabIndex = 54;
            this.gridviewLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewLop_CellClick);
            // 
            // txtSiso
            // 
            this.txtSiso.Location = new System.Drawing.Point(150, 252);
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.Size = new System.Drawing.Size(144, 22);
            this.txtSiso.TabIndex = 53;
            // 
            // cboNam1
            // 
            this.cboNam1.FormattingEnabled = true;
            this.cboNam1.Location = new System.Drawing.Point(829, 248);
            this.cboNam1.Name = "cboNam1";
            this.cboNam1.Size = new System.Drawing.Size(76, 24);
            this.cboNam1.TabIndex = 50;
            // 
            // cboThang1
            // 
            this.cboThang1.FormattingEnabled = true;
            this.cboThang1.Location = new System.Drawing.Point(709, 248);
            this.cboThang1.Name = "cboThang1";
            this.cboThang1.Size = new System.Drawing.Size(76, 24);
            this.cboThang1.TabIndex = 49;
            // 
            // cboNgay1
            // 
            this.cboNgay1.FormattingEnabled = true;
            this.cboNgay1.Location = new System.Drawing.Point(593, 248);
            this.cboNgay1.Name = "cboNgay1";
            this.cboNgay1.Size = new System.Drawing.Size(76, 24);
            this.cboNgay1.TabIndex = 48;
            // 
            // cboMamon
            // 
            this.cboMamon.FormattingEnabled = true;
            this.cboMamon.Location = new System.Drawing.Point(150, 97);
            this.cboMamon.Name = "cboMamon";
            this.cboMamon.Size = new System.Drawing.Size(144, 24);
            this.cboMamon.TabIndex = 47;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(829, 199);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(76, 24);
            this.cboNam.TabIndex = 46;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(709, 199);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(76, 24);
            this.cboThang.TabIndex = 45;
            // 
            // cboNgay
            // 
            this.cboNgay.FormattingEnabled = true;
            this.cboNgay.Location = new System.Drawing.Point(593, 199);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Size = new System.Drawing.Size(76, 24);
            this.cboNgay.TabIndex = 44;
            // 
            // cboMaGV
            // 
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(150, 152);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(144, 24);
            this.cboMaGV.TabIndex = 43;
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(567, 51);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(144, 22);
            this.txtTenlop.TabIndex = 42;
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(150, 51);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(144, 22);
            this.txtMalop.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Sĩ số";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ngày kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mã Phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mã Ca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mã Thời gian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã GV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày Bắt Đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã Lớp";
            // 
            // cboMaphong
            // 
            this.cboMaphong.FormattingEnabled = true;
            this.cboMaphong.Location = new System.Drawing.Point(567, 94);
            this.cboMaphong.Name = "cboMaphong";
            this.cboMaphong.Size = new System.Drawing.Size(144, 24);
            this.cboMaphong.TabIndex = 61;
            // 
            // cboMathoigian
            // 
            this.cboMathoigian.FormattingEnabled = true;
            this.cboMathoigian.Location = new System.Drawing.Point(567, 152);
            this.cboMathoigian.Name = "cboMathoigian";
            this.cboMathoigian.Size = new System.Drawing.Size(144, 24);
            this.cboMathoigian.TabIndex = 62;
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "MaLop";
            this.Malop.HeaderText = "Mã lớp";
            this.Malop.Name = "Malop";
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "TenLop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.Name = "tenlop";
            // 
            // Mamon
            // 
            this.Mamon.DataPropertyName = "MaMon";
            this.Mamon.HeaderText = "Mã môn";
            this.Mamon.Name = "Mamon";
            // 
            // MaGv
            // 
            this.MaGv.DataPropertyName = "MaGV";
            this.MaGv.HeaderText = "Mã GV";
            this.MaGv.Name = "MaGv";
            // 
            // NgayBD
            // 
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày BĐ";
            this.NgayBD.Name = "NgayBD";
            // 
            // NgayKT
            // 
            this.NgayKT.DataPropertyName = "NgayKT";
            this.NgayKT.HeaderText = "Ngày KT";
            this.NgayKT.Name = "NgayKT";
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã Ca";
            this.MaCa.Name = "MaCa";
            // 
            // Mathoigian
            // 
            this.Mathoigian.DataPropertyName = "MaThoiGian";
            this.Mathoigian.HeaderText = "Mã Thời gian";
            this.Mathoigian.Name = "Mathoigian";
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "MaPhong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.Name = "Maphong";
            // 
            // Siso
            // 
            this.Siso.DataPropertyName = "SiSo";
            this.Siso.HeaderText = "Sĩ Số";
            this.Siso.Name = "Siso";
            // 
            // FrmLophoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 633);
            this.Controls.Add(this.cboMathoigian);
            this.Controls.Add(this.cboMaphong);
            this.Controls.Add(this.cboMaca);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridviewLop);
            this.Controls.Add(this.txtSiso);
            this.Controls.Add(this.cboNam1);
            this.Controls.Add(this.cboThang1);
            this.Controls.Add(this.cboNgay1);
            this.Controls.Add(this.cboMamon);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.cboNgay);
            this.Controls.Add(this.cboMaGV);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLophoc";
            this.Text = "FrmLophoc";
            this.Activated += new System.EventHandler(this.btnSua_Click);
            this.Load += new System.EventHandler(this.FrmLophoc_Load);
            this.Click += new System.EventHandler(this.btnSua_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaca;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gridviewLop;
        private System.Windows.Forms.TextBox txtSiso;
        private System.Windows.Forms.ComboBox cboNam1;
        private System.Windows.Forms.ComboBox cboThang1;
        private System.Windows.Forms.ComboBox cboNgay1;
        private System.Windows.Forms.ComboBox cboMamon;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaphong;
        private System.Windows.Forms.ComboBox cboMathoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siso;
    }
}