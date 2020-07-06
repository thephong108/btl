namespace quanlyloptinhocvangoaingunganhan
{
    partial class FrmChucdanh
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenChucDanh = new System.Windows.Forms.TextBox();
            this.txtMaChucDanh = new System.Windows.Forms.TextBox();
            this.dataGridViewChucDanh = new System.Windows.Forms.DataGridView();
            this.MaCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchucdanh = new System.Windows.Forms.Label();
            this.machucdanh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(652, 404);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 21;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(496, 404);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 20;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(361, 404);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(215, 404);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(74, 405);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenChucDanh
            // 
            this.txtTenChucDanh.Location = new System.Drawing.Point(261, 130);
            this.txtTenChucDanh.Name = "txtTenChucDanh";
            this.txtTenChucDanh.Size = new System.Drawing.Size(100, 22);
            this.txtTenChucDanh.TabIndex = 16;
            // 
            // txtMaChucDanh
            // 
            this.txtMaChucDanh.Location = new System.Drawing.Point(261, 84);
            this.txtMaChucDanh.Name = "txtMaChucDanh";
            this.txtMaChucDanh.Size = new System.Drawing.Size(100, 22);
            this.txtMaChucDanh.TabIndex = 15;
            // 
            // dataGridViewChucDanh
            // 
            this.dataGridViewChucDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChucDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCD,
            this.TenCD});
            this.dataGridViewChucDanh.Location = new System.Drawing.Point(117, 206);
            this.dataGridViewChucDanh.Name = "dataGridViewChucDanh";
            this.dataGridViewChucDanh.RowHeadersWidth = 51;
            this.dataGridViewChucDanh.RowTemplate.Height = 24;
            this.dataGridViewChucDanh.Size = new System.Drawing.Size(506, 150);
            this.dataGridViewChucDanh.TabIndex = 14;
            this.dataGridViewChucDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChucDanh_CellClick);
            // 
            // MaCD
            // 
            this.MaCD.DataPropertyName = "MaChucDanh";
            this.MaCD.HeaderText = "Mã chức danh ";
            this.MaCD.MinimumWidth = 6;
            this.MaCD.Name = "MaCD";
            this.MaCD.Width = 125;
            // 
            // TenCD
            // 
            this.TenCD.DataPropertyName = "TenChucDanh";
            this.TenCD.HeaderText = "Tên chức danh ";
            this.TenCD.MinimumWidth = 6;
            this.TenCD.Name = "TenCD";
            this.TenCD.Width = 125;
            // 
            // tenchucdanh
            // 
            this.tenchucdanh.AutoSize = true;
            this.tenchucdanh.Location = new System.Drawing.Point(114, 136);
            this.tenchucdanh.Name = "tenchucdanh";
            this.tenchucdanh.Size = new System.Drawing.Size(107, 17);
            this.tenchucdanh.TabIndex = 13;
            this.tenchucdanh.Text = "Tên chức danh ";
            // 
            // machucdanh
            // 
            this.machucdanh.AutoSize = true;
            this.machucdanh.Location = new System.Drawing.Point(114, 90);
            this.machucdanh.Name = "machucdanh";
            this.machucdanh.Size = new System.Drawing.Size(101, 17);
            this.machucdanh.TabIndex = 12;
            this.machucdanh.Text = "Mã chức danh ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "CHỨC DANH ";
            // 
            // FrmChucdanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenChucDanh);
            this.Controls.Add(this.txtMaChucDanh);
            this.Controls.Add(this.dataGridViewChucDanh);
            this.Controls.Add(this.tenchucdanh);
            this.Controls.Add(this.machucdanh);
            this.Controls.Add(this.label1);
            this.Name = "FrmChucdanh";
            this.Text = "FrmChucdanh";
            this.Load += new System.EventHandler(this.FrmChucdanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenChucDanh;
        private System.Windows.Forms.TextBox txtMaChucDanh;
        private System.Windows.Forms.DataGridView dataGridViewChucDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCD;
        private System.Windows.Forms.Label tenchucdanh;
        private System.Windows.Forms.Label machucdanh;
        private System.Windows.Forms.Label label1;
    }
}