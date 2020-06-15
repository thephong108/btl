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
    public partial class FrmPhonghoc : Form
    {
        public FrmPhonghoc()
        {
            InitializeComponent();
        }

        private void FrmPhonghoc_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoaddatatoGridview();
            DAO.CloseConnection();
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblPhonghoc ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblPhonghoc = new DataTable();

                myAdapter.Fill(tblPhonghoc);
                gridviewMon.DataSource =tblPhonghoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
        }
        private void gridviewMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaPhong.Enabled = false;
            txtTenPhong.Text = gridviewMon.CurrentRow.Cells["Tenphong"].Value.ToString();
            txtMaPhong.Text = gridviewMon.CurrentRow.Cells["Maphong"].Value.ToString();
            txtDiachi.Text = gridviewMon.CurrentRow.Cells["Diachi"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";

            txtDiachi.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "update tblPhonghoc set TenPhong = N'" + txtTenPhong.Text.Trim() +
      "',DiaChi='" + txtDiachi.Text.Trim() + "' where MaPhong = '" + txtMaPhong.Text + "' ";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from tblPhonghoc where MaPhong = '" + txtMaPhong.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phòng ");
                txtMaPhong.Focus();
                return;

            }
            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên phòng");
                txtTenPhong.Focus();

                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ ");
                txtDiachi.Focus();
                return;

            }



            string sqlCheckKey = "Select * from tblPhonghoc where MaPhong ='" + txtMaPhong.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckKey))
            {
                MessageBox.Show(" Mã phòng đã tồn tại");
                DAO.CloseConnection();
                txtMaPhong.Focus();
                return;
            }
            else
            {
                string sql = " insert into tblPhonghoc values('" + txtMaPhong.Text.Trim() + "', N'" + txtTenPhong.Text.Trim() + "', N'" + txtDiachi.Text.Trim() + "')";


                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoaddatatoGridview();

            }
        }
    }
}
