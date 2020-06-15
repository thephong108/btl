namespace quanlyloptinhocvangoaingunganhan
{
    partial class FrmGiaovien
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
            this.cboMaCQ = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gridviewGV = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machuyenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matrinhdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.cboMatrinhdo = new System.Windows.Forms.ComboBox();
            this.cboMachuyenmon = new System.Windows.Forms.ComboBox();
            this.cboMachucdanh = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNgay = new System.Windows.Forms.ComboBox();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
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
            this.btnopen = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaCQ
            // 
            this.cboMaCQ.FormattingEnabled = true;
            this.cboMaCQ.Location = new System.Drawing.Point(156, 218);
            this.cboMaCQ.Name = "cboMaCQ";
            this.cboMaCQ.Size = new System.Drawing.Size(144, 24);
            this.cboMaCQ.TabIndex = 60;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(948, 573);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 59;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(715, 573);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(490, 573);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(243, 573);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 56;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(41, 573);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridviewGV
            // 
            this.gridviewGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.Ngaysinh,
            this.Gioitinh,
            this.SDT,
            this.Diachi,
            this.MaChucDanh,
            this.Machuyenmon,
            this.MaCQ,
            this.Matrinhdo,
            this.Anh});
            this.gridviewGV.Location = new System.Drawing.Point(53, 343);
            this.gridviewGV.Name = "gridviewGV";
            this.gridviewGV.RowTemplate.Height = 24;
            this.gridviewGV.Size = new System.Drawing.Size(1148, 184);
            this.gridviewGV.TabIndex = 54;
            this.gridviewGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewGV_CellClick);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.Name = "MaGV";
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "NgaySinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "GioiTinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "DienThoai";
            this.SDT.HeaderText = "Điện Thoại";
            this.SDT.Name = "SDT";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "DiaChi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // MaChucDanh
            // 
            this.MaChucDanh.DataPropertyName = "MaChucDanh";
            this.MaChucDanh.HeaderText = "Mã Chức Danh";
            this.MaChucDanh.Name = "MaChucDanh";
            // 
            // Machuyenmon
            // 
            this.Machuyenmon.DataPropertyName = "MaChuyenMon";
            this.Machuyenmon.HeaderText = "Mã chuyên môn";
            this.Machuyenmon.Name = "Machuyenmon";
            // 
            // MaCQ
            // 
            this.MaCQ.DataPropertyName = "MaCQ";
            this.MaCQ.HeaderText = "Mã Cơ Quan";
            this.MaCQ.Name = "MaCQ";
            // 
            // Matrinhdo
            // 
            this.Matrinhdo.DataPropertyName = "MaTrinhDo";
            this.Matrinhdo.HeaderText = "Mã Trình Độ";
            this.Matrinhdo.Name = "Matrinhdo";
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.Name = "Anh";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(573, 119);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(144, 22);
            this.txtSDT.TabIndex = 52;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(573, 270);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(364, 22);
            this.txtDiachi.TabIndex = 51;
            // 
            // cboMatrinhdo
            // 
            this.cboMatrinhdo.FormattingEnabled = true;
            this.cboMatrinhdo.Location = new System.Drawing.Point(156, 263);
            this.cboMatrinhdo.Name = "cboMatrinhdo";
            this.cboMatrinhdo.Size = new System.Drawing.Size(144, 24);
            this.cboMatrinhdo.TabIndex = 49;
            // 
            // cboMachuyenmon
            // 
            this.cboMachuyenmon.FormattingEnabled = true;
            this.cboMachuyenmon.Location = new System.Drawing.Point(573, 167);
            this.cboMachuyenmon.Name = "cboMachuyenmon";
            this.cboMachuyenmon.Size = new System.Drawing.Size(144, 24);
            this.cboMachuyenmon.TabIndex = 48;
            // 
            // cboMachucdanh
            // 
            this.cboMachucdanh.FormattingEnabled = true;
            this.cboMachucdanh.Location = new System.Drawing.Point(156, 112);
            this.cboMachucdanh.Name = "cboMachucdanh";
            this.cboMachucdanh.Size = new System.Drawing.Size(144, 24);
            this.cboMachucdanh.TabIndex = 47;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(844, 214);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(93, 24);
            this.cboNam.TabIndex = 46;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(700, 214);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(90, 24);
            this.cboThang.TabIndex = 45;
            // 
            // cboNgay
            // 
            this.cboNgay.FormattingEnabled = true;
            this.cboNgay.Location = new System.Drawing.Point(573, 214);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Size = new System.Drawing.Size(76, 24);
            this.cboNgay.TabIndex = 44;
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Location = new System.Drawing.Point(156, 167);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(144, 24);
            this.cboGioitinh.TabIndex = 43;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(573, 66);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(144, 22);
            this.txtTenGV.TabIndex = 42;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(156, 66);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(144, 22);
            this.txtMaGV.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Mã Trình Độ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Mã Chuyên Môn\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mã Cơ Quan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã Chức Danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã Giáo Viên";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(1142, 218);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(100, 28);
            this.btnopen.TabIndex = 62;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.Btnopen_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(1042, 263);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(209, 22);
            this.txtAnh.TabIndex = 63;
            this.txtAnh.TextChanged += new System.EventHandler(this.txtAnh_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1056, 224);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "Ảnh";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(1042, 12);
            this.picAnh.Margin = new System.Windows.Forms.Padding(4);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(209, 179);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 65;
            this.picAnh.TabStop = false;
            // 
            // FrmGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 752);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.cboMaCQ);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridviewGV);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.cboMatrinhdo);
            this.Controls.Add(this.cboMachuyenmon);
            this.Controls.Add(this.cboMachucdanh);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.cboNgay);
            this.Controls.Add(this.cboGioitinh);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtMaGV);
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
            this.Name = "FrmGiaovien";
            this.Text = "Giaovien";
            this.Load += new System.EventHandler(this.FrmGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaCQ;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gridviewGV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.ComboBox cboMatrinhdo;
        private System.Windows.Forms.ComboBox cboMachuyenmon;
        private System.Windows.Forms.ComboBox cboMachucdanh;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.TextBox txtTenGV;
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
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machuyenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matrinhdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        public System.Windows.Forms.TextBox txtMaGV;
    }
}