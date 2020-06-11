namespace quanlyloptinhocvangoaingunganhan
{
    partial class frmCoquan
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
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenCQ = new System.Windows.Forms.TextBox();
            this.txtMaCQ = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridViewCoQuan = new System.Windows.Forms.DataGridView();
            this.MaCoQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCoQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cqDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cqDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.TenCQ = new System.Windows.Forms.Label();
            this.MaCQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(526, 146);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(133, 22);
            this.txtDienThoai.TabIndex = 29;
            this.txtDienThoai.TextChanged += new System.EventHandler(this.txtDienThoai_TextChanged);
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(526, 108);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(247, 22);
            this.txtDiaChi.TabIndex = 28;
            // 
            // txtTenCQ
            // 
            this.txtTenCQ.Location = new System.Drawing.Point(182, 146);
            this.txtTenCQ.Name = "txtTenCQ";
            this.txtTenCQ.Size = new System.Drawing.Size(100, 22);
            this.txtTenCQ.TabIndex = 27;
            // 
            // txtMaCQ
            // 
            this.txtMaCQ.Location = new System.Drawing.Point(182, 110);
            this.txtMaCQ.Name = "txtMaCQ";
            this.txtMaCQ.Size = new System.Drawing.Size(100, 22);
            this.txtMaCQ.TabIndex = 26;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(660, 385);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 25;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(510, 385);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 24;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(370, 385);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 23;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(219, 385);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 22;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(69, 385);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridViewCoQuan
            // 
            this.dataGridViewCoQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCoQuan,
            this.TenCoQuan,
            this.cqDiaChi,
            this.cqDienThoai});
            this.dataGridViewCoQuan.Location = new System.Drawing.Point(130, 195);
            this.dataGridViewCoQuan.Name = "dataGridViewCoQuan";
            this.dataGridViewCoQuan.RowHeadersWidth = 51;
            this.dataGridViewCoQuan.RowTemplate.Height = 24;
            this.dataGridViewCoQuan.Size = new System.Drawing.Size(557, 150);
            this.dataGridViewCoQuan.TabIndex = 20;
            this.dataGridViewCoQuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoQuan_CellClick_1);
            // 
            // MaCoQuan
            // 
            this.MaCoQuan.DataPropertyName = "MaCQ";
            this.MaCoQuan.HeaderText = "Mã Cơ Quan ";
            this.MaCoQuan.MinimumWidth = 6;
            this.MaCoQuan.Name = "MaCoQuan";
            this.MaCoQuan.Width = 125;
            // 
            // TenCoQuan
            // 
            this.TenCoQuan.DataPropertyName = "TenCQ";
            this.TenCoQuan.HeaderText = "Tên cơ quan";
            this.TenCoQuan.MinimumWidth = 6;
            this.TenCoQuan.Name = "TenCoQuan";
            this.TenCoQuan.Width = 125;
            // 
            // cqDiaChi
            // 
            this.cqDiaChi.DataPropertyName = "DiaChi";
            this.cqDiaChi.HeaderText = "Địa Chỉ";
            this.cqDiaChi.MinimumWidth = 6;
            this.cqDiaChi.Name = "cqDiaChi";
            this.cqDiaChi.Width = 125;
            // 
            // cqDienThoai
            // 
            this.cqDienThoai.DataPropertyName = "DienThoai";
            this.cqDienThoai.HeaderText = "Điện thoại ";
            this.cqDienThoai.MinimumWidth = 6;
            this.cqDienThoai.Name = "cqDienThoai";
            this.cqDienThoai.Width = 125;
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSize = true;
            this.DienThoai.Location = new System.Drawing.Point(447, 151);
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Size = new System.Drawing.Size(72, 17);
            this.DienThoai.TabIndex = 19;
            this.DienThoai.Text = "Điện thoại";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(447, 112);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(55, 17);
            this.DiaChi.TabIndex = 18;
            this.DiaChi.Text = "Địa chỉ ";
            // 
            // TenCQ
            // 
            this.TenCQ.AutoSize = true;
            this.TenCQ.Location = new System.Drawing.Point(66, 151);
            this.TenCQ.Name = "TenCQ";
            this.TenCQ.Size = new System.Drawing.Size(93, 17);
            this.TenCQ.TabIndex = 17;
            this.TenCQ.Text = "Tên Cơ Quan";
            // 
            // MaCQ
            // 
            this.MaCQ.AutoSize = true;
            this.MaCQ.Location = new System.Drawing.Point(66, 113);
            this.MaCQ.Name = "MaCQ";
            this.MaCQ.Size = new System.Drawing.Size(87, 17);
            this.MaCQ.TabIndex = 16;
            this.MaCQ.Text = "Mã Cơ Quan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cơ Quan";
            // 
            // frmCoquan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenCQ);
            this.Controls.Add(this.txtMaCQ);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridViewCoQuan);
            this.Controls.Add(this.DienThoai);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.TenCQ);
            this.Controls.Add(this.MaCQ);
            this.Controls.Add(this.label1);
            this.Name = "frmCoquan";
            this.Text = "FrmCoquan";
            this.Load += new System.EventHandler(this.frmCoquan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCQ;
        private System.Windows.Forms.TextBox txtMaCQ;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridViewCoQuan;
        private System.Windows.Forms.Label DienThoai;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label TenCQ;
        private System.Windows.Forms.Label MaCQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCoQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCoQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cqDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cqDienThoai;
    }
}