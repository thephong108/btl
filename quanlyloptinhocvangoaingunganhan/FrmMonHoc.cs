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
    public partial class FrmMonHoc : Form
    {
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
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
                string sql = "select * from tblMonhoc ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblMonhoc = new DataTable();

                myAdapter.Fill(tblMonhoc);
                gridviewMon.DataSource = tblMonhoc;
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
            txtMamon.Text = "";
            txtTenmon.Text = "";
            
            txtHocphi.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "update tblMonhoc set TenMon = N'" + txtTenmon.Text.Trim() +
           "',Hocphi='" + txtHocphi.Text.Trim()  + "' where MaMon = '" + txtMamon.Text + "' ";
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
            string sql = "DELETE from tblMonhoc where MaMon = '" + txtMamon.Text + "'";
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
        
                if (txtMamon.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã môn ");
                    txtMamon.Focus();
                    return;

                }
                if (txtTenmon.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập tên môn");
                    txtTenmon.Focus();

                    return;
                }
                if (txtHocphi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập Học phí ");
                    txtHocphi.Focus();
                    return;

                }
            

                string sqlCheckKey = "Select * from tblMonhoc where MaMon ='" + txtMamon.Text.Trim() + "'";
                DAO.OpenConnection();

                if (DAO.checkKeyexit(sqlCheckKey))
                {
                    MessageBox.Show(" Mã môn đã tồn tại");
                    DAO.CloseConnection();
                    txtMamon.Focus();
                    return;
                }
                else
                {
                    string sql = " insert into tblMonhoc values('" + txtMamon.Text.Trim() + "', N'" + txtTenmon.Text.Trim() + "', N'" + txtHocphi.Text.Trim()  + "')";


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

        private void gridviewMon_Click(object sender, EventArgs e)
        {

        }

        private void gridviewMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMamon.Enabled = false;
            txtTenmon.Text = gridviewMon.CurrentRow.Cells["TenMon"].Value.ToString();
            txtMamon.Text = gridviewMon.CurrentRow.Cells["MaMon"].Value.ToString();
            txtHocphi.Text = gridviewMon.CurrentRow.Cells["HocPhi"].Value.ToString();
        }
    }
}
