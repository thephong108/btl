namespace quanlyloptinhocvangoaingunganhan
{
    partial class frmNghenghiep
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
            this.txtTenNghe = new System.Windows.Forms.TextBox();
            this.txtMaNghe = new System.Windows.Forms.TextBox();
            this.dataGridViewNgheNghiep = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNgheNghiep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNghe
            // 
            this.txtTenNghe.Location = new System.Drawing.Point(489, 112);
            this.txtTenNghe.Name = "txtTenNghe";
            this.txtTenNghe.Size = new System.Drawing.Size(209, 22);
            this.txtTenNghe.TabIndex = 21;
            // 
            // txtMaNghe
            // 
            this.txtMaNghe.Location = new System.Drawing.Point(205, 112);
            this.txtMaNghe.Name = "txtMaNghe";
            this.txtMaNghe.Size = new System.Drawing.Size(100, 22);
            this.txtMaNghe.TabIndex = 20;
            // 
            // dataGridViewNgheNghiep
            // 
            this.dataGridViewNgheNghiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNgheNghiep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNghe,
            this.TenNghe});
            this.dataGridViewNgheNghiep.Location = new System.Drawing.Point(105, 187);
            this.dataGridViewNgheNghiep.Name = "dataGridViewNgheNghiep";
            this.dataGridViewNgheNghiep.RowHeadersWidth = 51;
            this.dataGridViewNgheNghiep.RowTemplate.Height = 24;
            this.dataGridViewNgheNghiep.Size = new System.Drawing.Size(593, 150);
            this.dataGridViewNgheNghiep.TabIndex = 19;
            this.dataGridViewNgheNghiep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNgheNghiep_CellClick_1);
            // 
            // btnthoat
            // 
            this.btnthoat.Enabled = false;
            this.btnthoat.Location = new System.Drawing.Point(623, 392);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 18;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(499, 393);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 17;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(365, 392);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(230, 392);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(105, 393);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên Nghề";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã nghề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nghề nghiệp";
            // 
            // MaNghe
            // 
            this.MaNghe.DataPropertyName = "MaNghe";
            this.MaNghe.HeaderText = "Mã nghề";
            this.MaNghe.MinimumWidth = 6;
            this.MaNghe.Name = "MaNghe";
            this.MaNghe.Width = 125;
            // 
            // TenNghe
            // 
            this.TenNghe.DataPropertyName = "TenNghe";
            this.TenNghe.HeaderText = "Tên nghề";
            this.TenNghe.MinimumWidth = 6;
            this.TenNghe.Name = "TenNghe";
            this.TenNghe.Width = 300;
            // 
            // frmNghenghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenNghe);
            this.Controls.Add(this.txtMaNghe);
            this.Controls.Add(this.dataGridViewNgheNghiep);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNghenghiep";
            this.Text = "FrmNgheNghiep";
            this.Load += new System.EventHandler(this.frmNghenghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNgheNghiep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNghe;
        private System.Windows.Forms.TextBox txtMaNghe;
        private System.Windows.Forms.DataGridView dataGridViewNgheNghiep;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNghe;
    }
}