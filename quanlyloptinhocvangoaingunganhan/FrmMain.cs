using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyloptinhocvangoaingunganhan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hocVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHocvien f1 = new FrmHocvien();
            f1.Show();
        }

        private void giaoVieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiaovien f1 = new FrmGiaovien();
            f1.Show();
        }

        private void cơQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoquan f1 = new frmCoquan();
            f1.Show();
        }

        private void nghềNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNghenghiep f1 = new frmNghenghiep();
            f1.Show();
        }

      

        private void baoCaoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoDoanhThu f1 = new FrmBaoCaoDoanhThu();
            f1.Show();

        }

        private void danhSáchĐiểmTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSDiem f1 = new FrmDSDiem();
            f1.Show();
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSHVTheoLop f1 = new FrmDSHVTheoLop();
            f1.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonHoc f1 = new FrmMonHoc();
            f1.Show();
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChuyenmon f1 = new FrmChuyenmon();
            f1.Show();
        }

        private void tìmKiếmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemGiaoVien f1 = new FrmTimKiemGiaoVien();
            f1.Show();
        }

        private void phòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhonghoc f1 = new FrmPhonghoc();
            f1.Show();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLophoc f1 = new FrmLophoc();
            f1.Show();
        }

        private void tìmKiếmLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmTimKiemLopHoc f1 = new FrmTimKiemLopHoc();
            f1.Show();
        }
    }
    }
    

