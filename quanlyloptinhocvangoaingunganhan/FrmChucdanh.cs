using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace quanlyloptinhocvangoaingunganhan
{
    public partial class FrmChucdanh : Form
    {
        public FrmChucdanh()
        {
            InitializeComponent();
        }

        private void FrmChucdanh_Load(object sender, EventArgs e)
        {
            LoaddatatoGridview();
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblChucdanh ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblChucdanh = new DataTable();
                myAdapter.Fill(tblChucdanh);
                dataGridViewChucDanh.DataSource = tblChucdanh;
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

        private void dataGridViewChucDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaChucDanh.Text = dataGridViewChucDanh.CurrentRow.Cells["MaCD"].Value.ToString();
            txtTenChucDanh.Text = dataGridViewChucDanh.CurrentRow.Cells["TenCD"].Value.ToString();

            txtMaChucDanh.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtMaChucDanh.Enabled = true;
            txtTenChucDanh.Enabled = true;

            txtMaChucDanh.Text = "";
            txtTenChucDanh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblChucdanh set TenChucDanh = N'" + txtTenChucDanh.Text.Trim() + "' where MaChucDanh = '" + txtMaChucDanh.Text + "' ";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
         
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblChucdanh where MaChucDanh = '" + txtMaChucDanh.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaChucDanh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã chức danh ");
                txtMaChucDanh.Focus();
                return;

            }
            if (txtTenChucDanh.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên chức danh");
                txtTenChucDanh.Focus();

                return;
            }

            string sqlCheckKey = "Select * from tblChucdanh where MaChucDanh ='" + txtMaChucDanh.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckKey))
            {
                MessageBox.Show(" Mã chức danh đã tồn tại");
                DAO.CloseConnection();
                txtMaChucDanh.Focus();
                return;
            }
            else
            {
                string sql = " insert into tblChucdanh values('" + txtMaChucDanh.Text.Trim() + "', N'" + txtTenChucDanh.Text.Trim() + "')";


                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
            

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
