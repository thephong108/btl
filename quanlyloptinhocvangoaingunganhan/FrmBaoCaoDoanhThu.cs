using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

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

        
        private void Load_dgv()
        {
            DAO.OpenConnection();
            string sql;
            sql = "Select tblLophoc.MaLop,tblLophoc.TenLop,tblLophoc.MaMon,tblLophoc.SiSo (tblMonhoc.HocPhi * tblLophoc.SiSo) as Tong from tblLopHoc  join tblMonHoc  on tblLophoc.MaMon = tblMonhoc.MaMon where tblLophoc.NgayBD between N'" + DAO.ConvertDateTime(dtpTu.Text) + "' and N'" + DAO.ConvertDateTime(dtpDen.Text) + "' group by tblLophoc.MaLop, tblLophoc.TenLop, tblLophoc.MaMon,tblLophoc.SiSo";
          
         
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
         
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgvBaoCaoDoanhThu.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgvBaoCaoDoanhThu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvBaoCaoDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            Load_dgv();
        }
    }
}
