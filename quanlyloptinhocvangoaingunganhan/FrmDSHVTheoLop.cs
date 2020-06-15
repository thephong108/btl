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
    public partial class FrmDSHVTheoLop : Form
    {
        public FrmDSHVTheoLop()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Load_dgv();
        }
        DataTable tbl;
        private void Load_dgv()
        {
            string sql;
            sql = "select MaHocVien , TenHocVien,NgaySinh, Diem from tblHocvien where MaLop = N'" + cboMaLop.Text + "'";
            tbl = DAO.GetDataToTable(sql);
            dgvDanhSachHV.DataSource = tbl;
           
            dgvDanhSachHV.Columns[0].HeaderText = "Mã Học Viên";
            dgvDanhSachHV.Columns[1].HeaderText = "Tên Học viên";
            dgvDanhSachHV.Columns[2].HeaderText = "Ngày Sinh";
            dgvDanhSachHV.Columns[3].HeaderText = "Điểm";

            dgvDanhSachHV.Columns[0].Width = 100;
            dgvDanhSachHV.Columns[1].Width = 100;
            dgvDanhSachHV.Columns[2].Width = 100;
            dgvDanhSachHV.Columns[3].Width = 100;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgvDanhSachHV.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgvDanhSachHV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvDanhSachHV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
        }

        private void cboMaLop_DropDown(object sender, EventArgs e)
        {
            cboMaLop.DataSource = DAO.GetDataToTable("select MaLop from tblLophoc");
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.SelectedIndex = -1;
        }
    }
}
