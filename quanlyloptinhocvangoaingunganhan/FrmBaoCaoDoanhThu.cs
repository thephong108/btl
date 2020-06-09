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
    public partial class FrmBaoCaoDoanhThu : Form
    {
        public FrmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            Load_dgv();
        }

        private void dtpDen_ValueChanged(object sender, EventArgs e)
        {

        }

        DataTable tbl;
        private void Load_dgv()
        {
            string sql;
            sql = "Select a.MaLop,a.TenLop,a.MaMon,a.Siso (b.HocPhi * a.Siso) as tong from tblLopHoc a join tblMonHoc b on a.MaMon = b.MaMon where a.NgayBD between N'" + DAO.ConvertDateTime(dtpTu.Text) + "' and N'" + DAO.ConvertDateTime(dtpDen.Text) + "' group by a.MaLop, a.TenLop, a.MaMon,a.Siso";
            tbl = DAO.GetDataToTable(sql);
            dgvBaoCaoDoanhThu.DataSource = tbl;
            dgvBaoCaoDoanhThu.Columns[0].HeaderText = "Mã Lớp";
            dgvBaoCaoDoanhThu.Columns[1].HeaderText = "Tên Lớp";
            dgvBaoCaoDoanhThu.Columns[2].HeaderText = "Mã Môn";
            dgvBaoCaoDoanhThu.Columns[3].HeaderText = "Sĩ Số";
            dgvBaoCaoDoanhThu.Columns[4].HeaderText = "Doanh Thu";

            dgvBaoCaoDoanhThu.Columns[0].Width = 100;
            dgvBaoCaoDoanhThu.Columns[1].Width = 100;
            dgvBaoCaoDoanhThu.Columns[2].Width = 100;
            dgvBaoCaoDoanhThu.Columns[3].Width = 100;
            dgvBaoCaoDoanhThu.Columns[4].Width = 100;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgvBaoCaoDoanhThu.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgvBaoCaoDoanhThu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvBaoCaoDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
