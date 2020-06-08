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
    }
}
