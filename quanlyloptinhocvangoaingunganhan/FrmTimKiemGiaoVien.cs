using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyloptinhocvangoaingunganhan
{
    public partial class FrmTimKiemGiaoVien : Form
    {
        public FrmTimKiemGiaoVien()
        {
            InitializeComponent();
        }
        DataTable tblGiaovien;

        private void FrmTimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            ResetValues();
            GridviewTKGV.DataSource = null;
            cboMaGV.DataSource = DAO.DocBang("SELECT MaGV FROM tblGiaovien");
            cboMaGV.ValueMember = "MaGV";
      
            cboMaGV.SelectedIndex = -1;
            
            cboChuyenMon.DataSource = DAO.DocBang("SELECT MaChuyenMon FROM tblChuyenmon");
            cboChuyenMon.ValueMember = "MaChuyenMon";
        
            cboChuyenMon.SelectedIndex = -1;
            cboMonhoc.DataSource = DAO.DocBang("SELECT MaMon FROM tblMonhoc");
            cboMonhoc.DisplayMember = "MaMon";
     
            cboMonhoc.SelectedIndex = -1;
            cboTrinhdo.DataSource = DAO.DocBang("SELECT MaTrinhDo FROM tblTrinhdo");
            cboTrinhdo.ValueMember = "MaTrinhDo";
           
            cboTrinhdo.SelectedIndex = -1;
        }
        private void LoaddatatoGV()
        {

            GridviewTKGV.Columns[0].HeaderText = "Mã Giáo viên";

            GridviewTKGV.AllowUserToAddRows = false;
            GridviewTKGV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cboMaGV.Text = "";
            cboMaGV.Focus();
            cboChuyenMon.Text = "";
            txtTenGV.Text = "";
          
            cboTrinhdo.Text = "";
            cboMonhoc.Text = "";
        }

        private void cboChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {

            string sql;
        
            if ((cboMaGV.Text == "") && (txtTenGV.Text == "") && (cboTrinhdo.Text == "") && (cboMonhoc.Text == "") &&
                (cboChuyenMon.Text == "") )
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblGiaovien WHERE 1=1";

            if (cboMaGV.Text != "")
                sql = sql + " AND MaGV Like N'%" +cboMaGV.Text + "%'";
            if (txtTenGV.Text != "")
                sql = sql + " AND TenGV Like N'%" + txtTenGV.Text + "%'";
    
            if (cboChuyenMon.Text != "")
                sql = sql + " AND MaChuyenMon Like N'%" + cboChuyenMon.Text + "%'";
            if (cboMonhoc.Text != "")
                sql = "select tblLophoc.MaGV,tblMonhoc.MaMon from tblLophoc join tblMonhoc on tblLophoc.MaMon=tblMonhoc.MaMon where tblMonhoc.MaMon = N'%" + cboMonhoc.Text + "%'";
            if (cboTrinhdo.Text != "")
                sql = sql + " AND MaTrinhDo Like N'%" + cboTrinhdo.Text + "%'";

            tblGiaovien = DAO.DocBang(sql);
   
            if (tblGiaovien.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblGiaovien.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            GridviewTKGV.DataSource = tblGiaovien;
            LoaddatatoGV();
        }

        private void GridviewTKGV_DoubleClick(object sender, EventArgs e)
        {
            string MaGV;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MaGV = GridviewTKGV.CurrentRow.Cells["MaGV"].Value.ToString();
                FrmGiaovien frm = new FrmGiaovien();
               frm.txtMaGV.Text = MaGV;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }

        private void cboMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTrinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridviewTKGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
