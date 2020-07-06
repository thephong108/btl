namespace quanlyloptinhocvangoaingunganhan
{
    partial class FrmTrinhdo
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
            this.txtTenTrinhDo = new System.Windows.Forms.TextBox();
            this.txtMaTrinhDo = new System.Windows.Forms.TextBox();
            this.TenTD = new System.Windows.Forms.Label();
            this.MaTD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTrinhDo = new System.Windows.Forms.DataGridView();
            this.MaTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrinhDo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTrinhDo
            // 
            this.txtTenTrinhDo.Location = new System.Drawing.Point(566, 115);
            this.txtTenTrinhDo.Name = "txtTenTrinhDo";
            this.txtTenTrinhDo.Size = new System.Drawing.Size(100, 22);
            this.txtTenTrinhDo.TabIndex = 21;
            // 
            // txtMaTrinhDo
            // 
            this.txtMaTrinhDo.Location = new System.Drawing.Point(213, 116);
            this.txtMaTrinhDo.Name = "txtMaTrinhDo";
            this.txtMaTrinhDo.Size = new System.Drawing.Size(100, 22);
            this.txtMaTrinhDo.TabIndex = 20;
            // 
            // TenTD
            // 
            this.TenTD.AutoSize = true;
            this.TenTD.Location = new System.Drawing.Point(404, 115);
            this.TenTD.Name = "TenTD";
            this.TenTD.Size = new System.Drawing.Size(89, 17);
            this.TenTD.TabIndex = 19;
            this.TenTD.Text = "Tên trình độ ";
            // 
            // MaTD
            // 
            this.MaTD.AutoSize = true;
            this.MaTD.Location = new System.Drawing.Point(91, 116);
            this.MaTD.Name = "MaTD";
            this.MaTD.Size = new System.Drawing.Size(83, 17);
            this.MaTD.TabIndex = 18;
            this.MaTD.Text = "Mã trình độ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "TRÌNH ĐỘ";
            // 
            // dataGridViewTrinhDo
            // 
            this.dataGridViewTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrinhDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTrinhDo,
            this.TenTrinhDo});
            this.dataGridViewTrinhDo.Location = new System.Drawing.Point(122, 202);
            this.dataGridViewTrinhDo.Name = "dataGridViewTrinhDo";
            this.dataGridViewTrinhDo.RowHeadersWidth = 51;
            this.dataGridViewTrinhDo.RowTemplate.Height = 24;
            this.dataGridViewTrinhDo.Size = new System.Drawing.Size(555, 150);
            this.dataGridViewTrinhDo.TabIndex = 16;
            this.dataGridViewTrinhDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrinhDo_CellClick);
            // 
            // MaTrinhDo
            // 
            this.MaTrinhDo.DataPropertyName = "MaTrinhDo";
            this.MaTrinhDo.HeaderText = "Mã trình độ";
            this.MaTrinhDo.MinimumWidth = 6;
            this.MaTrinhDo.Name = "MaTrinhDo";
            this.MaTrinhDo.Width = 125;
            // 
            // TenTrinhDo
            // 
            this.TenTrinhDo.DataPropertyName = "TenTrinhDo";
            this.TenTrinhDo.HeaderText = "Tên trình độ ";
            this.TenTrinhDo.MinimumWidth = 6;
            this.TenTrinhDo.Name = "TenTrinhDo";
            this.TenTrinhDo.Width = 125;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(634, 384);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(495, 384);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(359, 385);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 13;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(250, 385);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(111, 385);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // FrmTrinhdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenTrinhDo);
            this.Controls.Add(this.txtMaTrinhDo);
            this.Controls.Add(this.TenTD);
            this.Controls.Add(this.MaTD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTrinhDo);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Name = "FrmTrinhdo";
            this.Text = "FrmTrinhdo";
            this.Load += new System.EventHandler(this.FrmTrinhdo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrinhDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTrinhDo;
        private System.Windows.Forms.TextBox txtMaTrinhDo;
        private System.Windows.Forms.Label TenTD;
        private System.Windows.Forms.Label MaTD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrinhDo;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
    }
}