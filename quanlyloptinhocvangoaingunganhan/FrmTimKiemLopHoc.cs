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
    public partial class FrmTimKiemLopHoc : Form
    {
        public FrmTimKiemLopHoc()
        {
            InitializeComponent();
        }
        DataTable tblLophoc;

        private void btnTK_Click(object sender, EventArgs e)
        {
            string sql;

            if ((cboMalop.Text == "") && (txtTenlop.Text == "") && (cboGV.Text == "") && (cboMonhoc.Text == "") &&
                (txtSiso.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblLophoc WHERE 1=1";

            if (cboMalop.Text != "")
                sql = sql + " AND MaLop Like N'%" + cboMalop.Text + "%'";
            if (txtTenlop.Text != "")
                sql = sql + " AND TenLop Like N'%" + txtTenlop.Text + "%'";

            if (cboGV.Text != "")
                sql = sql + " AND MaGV Like N'%" + cboGV.Text + "%'";
          
            if (cboMonhoc.Text != "")
                sql = sql + " AND MaMon Like N'%" + cboMonhoc.Text + "%'";

            tblLophoc = DAO.DocBang(sql);

            if (tblLophoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblLophoc.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            GridviewTKLophoc.DataSource = tblLophoc;
            LoaddatatoGV();
        }

        private void FrmTimKiemLopHoc_Load(object sender, EventArgs e)
        {
            ResetValues();
            GridviewTKLophoc.DataSource = null;
            cboMalop.DataSource = DAO.DocBang("SELECT MaLop FROM tblLophoc");
            cboMalop.ValueMember = "MaLop";

            cboMalop.SelectedIndex = -1;

            cboGV.DataSource = DAO.DocBang("SELECT MaGV FROM tblGiaovien");
            cboGV.ValueMember = "MaGV";

            cboGV.SelectedIndex = -1;
            cboMonhoc.DataSource = DAO.DocBang("SELECT MaMon FROM tblMonhoc");
            cboMonhoc.DisplayMember = "MaMon";

            cboMonhoc.SelectedIndex = -1;
            txtTenMon.Enabled = false;
            txtTGV.Enabled = false;
        }
        private void LoaddatatoGV()
        {

            GridviewTKLophoc.Columns[0].HeaderText = "Mã Lớp học";

            GridviewTKLophoc.AllowUserToAddRows = false;
            GridviewTKLophoc.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cboMalop.Text = "";
            cboMalop.Focus();
            cboMonhoc.Text = "";
            txtTGV.Text = "";

            txtSiso.Text = "";
            cboMonhoc.Text = "";
        }

        private void cboGV_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboGV.Text == "")
            {
                txtTGV.Text = "";
                return;
            }
            sql = "SELECT TenGV FROM tblGiaovien WHERE MaGV=N'" + cboGV.Text + "'";
            DataTable table = DAO.DocBang(sql);
            if (table.Rows.Count > 0)
            {
                txtTGV.Text = table.Rows[0][0].ToString();//dòng 0 cột 0
               
            }
        }

        private void cboMonhoc_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMonhoc.Text == "")
            {
                txtTenMon.Text = "";
                return;
            }
            sql = "SELECT TenMon FROM tblMonhoc WHERE MaMon=N'" + cboMonhoc.Text + "'";
            DataTable table = DAO.DocBang(sql);
            if (table.Rows.Count > 0)
            {
                txtTenMon.Text = table.Rows[0][0].ToString();//dòng 0 cột 0

            }
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
