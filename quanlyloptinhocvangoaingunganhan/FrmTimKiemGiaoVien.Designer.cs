using System.Windows.Forms;

namespace quanlyloptinhocvangoaingunganhan
{
    partial class FrmTimKiemGiaoVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridviewTKGV = new System.Windows.Forms.DataGridView();
            this.cboTrinhdo = new System.Windows.Forms.ComboBox();
            this.cboChuyenMon = new System.Windows.Forms.ComboBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboMonhoc = new System.Windows.Forms.ComboBox();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewTKGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Chuyên môn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Môn học";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tên Giáo viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Trình độ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GridviewTKGV
            // 
            this.GridviewTKGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridviewTKGV.Location = new System.Drawing.Point(94, 203);
            this.GridviewTKGV.Margin = new System.Windows.Forms.Padding(4);
            this.GridviewTKGV.Name = "GridviewTKGV";
            this.GridviewTKGV.Size = new System.Drawing.Size(869, 281);
            this.GridviewTKGV.TabIndex = 40;
            this.GridviewTKGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridviewTKGV_CellContentClick);
            this.GridviewTKGV.DoubleClick += new System.EventHandler(this.GridviewTKGV_DoubleClick);
            // 
            // cboTrinhdo
            // 
            this.cboTrinhdo.FormattingEnabled = true;
            this.cboTrinhdo.Location = new System.Drawing.Point(240, 145);
            this.cboTrinhdo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTrinhdo.Name = "cboTrinhdo";
            this.cboTrinhdo.Size = new System.Drawing.Size(188, 24);
            this.cboTrinhdo.TabIndex = 45;
            this.cboTrinhdo.SelectedIndexChanged += new System.EventHandler(this.cboTrinhdo_SelectedIndexChanged);
            // 
            // cboChuyenMon
            // 
            this.cboChuyenMon.FormattingEnabled = true;
            this.cboChuyenMon.Location = new System.Drawing.Point(770, 41);
            this.cboChuyenMon.Margin = new System.Windows.Forms.Padding(4);
            this.cboChuyenMon.Name = "cboChuyenMon";
            this.cboChuyenMon.Size = new System.Drawing.Size(192, 24);
            this.cboChuyenMon.TabIndex = 46;
            this.cboChuyenMon.SelectedIndexChanged += new System.EventHandler(this.cboChuyenMon_SelectedIndexChanged);
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(240, 97);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(188, 22);
            this.txtTenGV.TabIndex = 48;
            this.txtTenGV.TextChanged += new System.EventHandler(this.txtTenGV_TextChanged);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(108, 527);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 58;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Location = new System.Drawing.Point(467, 527);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(75, 23);
            this.btnTimlai.TabIndex = 59;
            this.btnTimlai.Text = "Hủy";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(868, 527);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 60;
            this.btnThoat.Text = "thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboMonhoc
            // 
            this.cboMonhoc.FormattingEnabled = true;
            this.cboMonhoc.Location = new System.Drawing.Point(771, 97);
            this.cboMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboMonhoc.Name = "cboMonhoc";
            this.cboMonhoc.Size = new System.Drawing.Size(192, 24);
            this.cboMonhoc.TabIndex = 61;
            this.cboMonhoc.SelectedIndexChanged += new System.EventHandler(this.cboMonhoc_SelectedIndexChanged);
            // 
            // cboMaGV
            // 
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(240, 41);
            this.cboMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(188, 24);
            this.cboMaGV.TabIndex = 62;
            this.cboMaGV.SelectedIndexChanged += new System.EventHandler(this.cboMaGV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mã Giáo Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmTimKiemGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaGV);
            this.Controls.Add(this.cboMonhoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.cboChuyenMon);
            this.Controls.Add(this.cboTrinhdo);
            this.Controls.Add(this.GridviewTKGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimKiemGiaoVien";
            this.Text = "FrmTimKiemGiaoVien";
            this.Load += new System.EventHandler(this.FrmTimKiemGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridviewTKGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridviewTKGV;
        private System.Windows.Forms.ComboBox cboTrinhdo;
        private System.Windows.Forms.ComboBox cboChuyenMon;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboMonhoc;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.Label label2;

        public FrmTimKiemGiaoVien(ComboBox cboMaGV)
        {
            this.cboMaGV = cboMaGV;
        }

        public FrmTimKiemGiaoVien(Label label2)
        {
            this.label2 = label2;
        }
    }
}