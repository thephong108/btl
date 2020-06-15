namespace quanlyloptinhocvangoaingunganhan
{
    partial class FrmChuyenmon
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
            this.txtTenchuyenmon = new System.Windows.Forms.TextBox();
            this.txtMachuyenmon = new System.Windows.Forms.TextBox();
            this.gridviewCMon = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Machuyenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCMon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenchuyenmon
            // 
            this.txtTenchuyenmon.Location = new System.Drawing.Point(529, 109);
            this.txtTenchuyenmon.Name = "txtTenchuyenmon";
            this.txtTenchuyenmon.Size = new System.Drawing.Size(209, 22);
            this.txtTenchuyenmon.TabIndex = 45;
            // 
            // txtMachuyenmon
            // 
            this.txtMachuyenmon.Location = new System.Drawing.Point(230, 109);
            this.txtMachuyenmon.Name = "txtMachuyenmon";
            this.txtMachuyenmon.Size = new System.Drawing.Size(100, 22);
            this.txtMachuyenmon.TabIndex = 44;
            // 
            // gridviewCMon
            // 
            this.gridviewCMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewCMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Machuyenmon,
            this.TenChuyenMon});
            this.gridviewCMon.Location = new System.Drawing.Point(105, 187);
            this.gridviewCMon.Name = "gridviewCMon";
            this.gridviewCMon.RowHeadersWidth = 51;
            this.gridviewCMon.RowTemplate.Height = 24;
            this.gridviewCMon.Size = new System.Drawing.Size(593, 150);
            this.gridviewCMon.TabIndex = 43;
            // 
            // btnthoat
            // 
            this.btnthoat.Enabled = false;
            this.btnthoat.Location = new System.Drawing.Point(623, 392);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 42;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(499, 393);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 41;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(365, 392);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 40;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(230, 392);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 39;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(105, 393);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 38;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tên chuyên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã chuyên môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Chuyên môn";
            // 
            // Machuyenmon
            // 
            this.Machuyenmon.DataPropertyName = "MaChuyenMon";
            this.Machuyenmon.HeaderText = "Mã chuyên môn";
            this.Machuyenmon.MinimumWidth = 6;
            this.Machuyenmon.Name = "Machuyenmon";
            this.Machuyenmon.Width = 125;
            // 
            // TenChuyenMon
            // 
            this.TenChuyenMon.DataPropertyName = "TenChuyenMon";
            this.TenChuyenMon.HeaderText = "Tên chuyên môn";
            this.TenChuyenMon.MinimumWidth = 6;
            this.TenChuyenMon.Name = "TenChuyenMon";
            this.TenChuyenMon.Width = 300;
            // 
            // FrmChuyenmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenchuyenmon);
            this.Controls.Add(this.txtMachuyenmon);
            this.Controls.Add(this.gridviewCMon);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmChuyenmon";
            this.Text = "FrmChuyenmon";
            this.Load += new System.EventHandler(this.FrmChuyenmon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenchuyenmon;
        private System.Windows.Forms.TextBox txtMachuyenmon;
        private System.Windows.Forms.DataGridView gridviewCMon;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machuyenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuyenMon;
    }
}