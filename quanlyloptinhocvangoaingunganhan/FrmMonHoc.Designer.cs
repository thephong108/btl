namespace quanlyloptinhocvangoaingunganhan
{
    partial class FrmMonHoc
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
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.txtMamon = new System.Windows.Forms.TextBox();
            this.gridviewMon = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHocphi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hocphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(489, 112);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(209, 22);
            this.txtTenmon.TabIndex = 32;
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(205, 112);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(100, 22);
            this.txtMamon.TabIndex = 31;
            // 
            // gridviewMon
            // 
            this.gridviewMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mamon,
            this.Tenmon,
            this.Hocphi});
            this.gridviewMon.Location = new System.Drawing.Point(105, 187);
            this.gridviewMon.Name = "gridviewMon";
            this.gridviewMon.RowHeadersWidth = 51;
            this.gridviewMon.RowTemplate.Height = 24;
            this.gridviewMon.Size = new System.Drawing.Size(593, 150);
            this.gridviewMon.TabIndex = 30;
            // 
            // btnthoat
            // 
            this.btnthoat.Enabled = false;
            this.btnthoat.Location = new System.Drawing.Point(623, 392);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 29;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(499, 393);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 28;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(365, 392);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 27;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(230, 392);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 26;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(105, 393);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 25;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Môn học";
            // 
            // txtHocphi
            // 
            this.txtHocphi.Location = new System.Drawing.Point(205, 159);
            this.txtHocphi.Name = "txtHocphi";
            this.txtHocphi.Size = new System.Drawing.Size(195, 22);
            this.txtHocphi.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Học phí";
            // 
            // Mamon
            // 
            this.Mamon.DataPropertyName = "MaMon";
            this.Mamon.HeaderText = "Mã môn";
            this.Mamon.MinimumWidth = 6;
            this.Mamon.Name = "Mamon";
            this.Mamon.Width = 125;
            // 
            // Tenmon
            // 
            this.Tenmon.DataPropertyName = "TenMon";
            this.Tenmon.HeaderText = "Tên môn";
            this.Tenmon.MinimumWidth = 6;
            this.Tenmon.Name = "Tenmon";
            this.Tenmon.Width = 300;
            // 
            // Hocphi
            // 
            this.Hocphi.DataPropertyName = "HocPhi";
            this.Hocphi.HeaderText = "Học phí";
            this.Hocphi.Name = "Hocphi";
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHocphi);
            this.Controls.Add(this.txtTenmon);
            this.Controls.Add(this.txtMamon);
            this.Controls.Add(this.gridviewMon);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMonHoc";
            this.Text = "FrmMonHoc";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.TextBox txtMamon;
        private System.Windows.Forms.DataGridView gridviewMon;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hocphi;
        private System.Windows.Forms.TextBox txtHocphi;
        private System.Windows.Forms.Label label4;
    }
}