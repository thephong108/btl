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
    public partial class FrmChuyenmon : Form
    {
        public FrmChuyenmon()
        {
            InitializeComponent();
        }

        private void FrmChuyenmon_Load(object sender, EventArgs e)
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
                string sql = "select * from tblChuyenmon ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblChuyenmon = new DataTable();

                myAdapter.Fill(tblChuyenmon);
                gridviewCMon.DataSource = tblChuyenmon;
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtMachuyenmon.Text = "";
            txtTenchuyenmon.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "update tblChuyenmon set TenChuyenMon = N'" + txtTenchuyenmon.Text.Trim() +
           "' where MaChuyenMon = '" + txtMachuyenmon.Text + "' ";
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
            string sql = "DELETE from tblChuyenmon where MaChuyenMon = '" + txtMachuyenmon.Text + "'";
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

            if (txtMachuyenmon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã chuyên môn ");
                txtMachuyenmon.Focus();
                return;

            }
            if (txtTenchuyenmon.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên môn");
                txtTenchuyenmon.Focus();

                return;
            }
          


            string sqlCheckKey = "Select * from tblChuyenmon where MaChuyenMon ='" + txtMachuyenmon.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyexit(sqlCheckKey))
            {
                MessageBox.Show(" Mã chuyên môn đã tồn tại");
                DAO.CloseConnection();
                txtMachuyenmon.Focus();
                return;
            }
            else
            {
                string sql = " insert into tblChuyenmon values('" + txtMachuyenmon.Text.Trim() + "', N'" + txtTenchuyenmon.Text.Trim() +  "')";


                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoaddatatoGridview();

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
