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

namespace QuanLyDiem
{
    public partial class QlyGV : Form
    {

        SqlConnection connection = new SqlConnection();
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public QlyGV()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM GIANGVIEN WHERE MAGV= '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            HienthidulieuGiangVien();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

      

        private void btnFind_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MAGV,MAKHOA,HOGV,TENGV FROM GIANGVIEN WHERE MAGV = '" + txtTimKiemMAGV.Text + "' AND MAKHOA = '" + Program.maKhoa + "'";
            command.ExecuteNonQuery();

            

         
            
            adapter.SelectCommand = command;

            //DataTable dt = Program.ExecSqlDataTable(strLenh);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dgv_GiangVien.DataSource = dt;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO GIANGVIEN(MAGV,MAKHOA,HOGV,TENGV) VALUES('" + txtID.Text+"', '"+txtKhoa.Text+"', N'"+txtHoGV.Text+"', N'"+txtTenGV.Text+"')";
            command.ExecuteNonQuery();
            HienthidulieuGiangVien();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                //Application.Exit();
                this.Close();
            }
        }

        


        public void HienthidulieuGiangVien()
        {
            command = connection.CreateCommand();

            String strLenh = "SELECT MAGV,MAKHOA,HOGV,TENGV FROM GIANGVIEN WHERE MAKHOA = '"+Program.maKhoa+"'";
            command.CommandText = strLenh;
            adapter.SelectCommand = command;

            //DataTable dt = Program.ExecSqlDataTable(strLenh);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dgv_GiangVien.DataSource = dt;
            //dgv_GiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dgv_GiangVien.Columns[0].HeaderText = "Mã giảng viên";
            //dgv_GiangVien.Columns[1].HeaderText = "Mã khoa";
            //dgv_GiangVien.Columns[2].HeaderText = "Họ giảng viên";
            //dgv_GiangVien.Columns[3].HeaderText = "Tên giảng viên";

        }

        private void QlyGV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Program.conn_Publisher);
            connection.Open();
            
            HienthidulieuGiangVien();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            int i;
            i = dgv_GiangVien.CurrentRow.Index;
            txtID.Text = dgv_GiangVien.Rows[i].Cells[0].Value.ToString();
            txtKhoa.Text = dgv_GiangVien.Rows[i].Cells[1].Value.ToString();
            txtHoGV.Text = dgv_GiangVien.Rows[i].Cells[2].Value.ToString();
            txtTenGV.Text = dgv_GiangVien.Rows[i].Cells[3].Value.ToString();

        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            
            command.ExecuteNonQuery();
            HienthidulieuGiangVien();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE GIANGVIEN SET MAKHOA = '" +txtKhoa.Text+ "', HOGV= N'" + txtHoGV.Text + "',TENGV= N'" + txtTenGV.Text + "'WHERE MAGV = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            HienthidulieuGiangVien();
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            HienthidulieuGiangVien();
        }
    }
}
