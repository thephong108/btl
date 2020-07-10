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
    public partial class FrmBaocaosinhviendiemcao : Form
    {
        public FrmBaocaosinhviendiemcao()
        {
            InitializeComponent();
        }

        private void cboMaLop_DropDown(object sender, EventArgs e)
        {
            cboMaLop.DataSource = DAO.GetDataToTable("select MaLop from tblLophoc");
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.SelectedIndex = -1;
        }

        private void Baocaosinhviendiemcao_Load(object sender, EventArgs e)
        {

        }
        DataTable tbl;
        private void btnXem_Click(object sender, EventArgs e)
        {
            Load_dgv();
        }
        private void Load_dgv()
        {
            string sql;
            sql = "select top (3) MaHocVien , TenHocVien, Diem from tblHocvien where MaLop = N'" + cboMaLop.Text + "'order by Diem desc";
            tbl = DAO.GetDataToTable(sql);
            dgvDanhSachDiem.DataSource = tbl;
            dgvDanhSachDiem.Columns[0].HeaderText = "Mã Học Viên";
            dgvDanhSachDiem.Columns[1].HeaderText = "Tên Học viên";
            dgvDanhSachDiem.Columns[2].HeaderText = "Điểm";

            dgvDanhSachDiem.Columns[0].Width = 100;
            dgvDanhSachDiem.Columns[1].Width = 100;
            dgvDanhSachDiem.Columns[2].Width = 100;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgvDanhSachDiem.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgvDanhSachDiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
