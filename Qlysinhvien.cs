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
    public partial class Qlysinhvien : Form
    {

        SqlConnection connection = new SqlConnection();
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public Qlysinhvien()
        {
            InitializeComponent();
        }

        public void LoadComboBox()
        {
            var cmd = new SqlCommand("SELECT PHAI FROM SINHVIEN",connection);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbx_Phai.DisplayMember = "PHAI";
            cbx_Phai.DataSource = dt;
            

        }

        public void HienthidulieuSinhVien()
        {
            command = connection.CreateCommand();

            String strLenh = "SELECT MASV, HoSV,TENSV,PHAI,NGAYSINH,NOISINH,MALOP FROM SINHVIEN SV WHERE SV.MALOP IN (SELECT MALOP FROM LOP WHERE MAKHOA = '" + Program.maKhoa+ "' )";
            command.CommandText = strLenh;
            adapter.SelectCommand = command;

            //DataTable dt = Program.ExecSqlDataTable(strLenh);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dgv_Sinhvien.DataSource = dt;
            //dgv_GiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dgv_GiangVien.Columns[0].HeaderText = "Mã giảng viên";
            //dgv_GiangVien.Columns[1].HeaderText = "Mã khoa";
            //dgv_GiangVien.Columns[2].HeaderText = "Họ giảng viên";
            //dgv_GiangVien.Columns[3].HeaderText = "Tên giảng viên";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Qlysinhvien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Program.conn_Publisher);
            connection.Open();

            HienthidulieuSinhVien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM SINHVIEN WHERE MASV= '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            HienthidulieuSinhVien();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Sinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = false;
            int i;
            i = dgv_Sinhvien.CurrentRow.Index;
            txtID.Text = dgv_Sinhvien.Rows[i].Cells[0].Value.ToString();
            txtHo.Text = dgv_Sinhvien.Rows[i].Cells[1].Value.ToString();
            txtTen.Text = dgv_Sinhvien.Rows[i].Cells[2].Value.ToString();
            cbx_Phai.Text = dgv_Sinhvien.Rows[i].Cells[3].Value.ToString();
            txtNgaySinh.Text = dgv_Sinhvien.Rows[i].Cells[4].Value.ToString();
            txtNoiSinh.Text = dgv_Sinhvien.Rows[i].Cells[5].Value.ToString();
            txtMaLop.Text = dgv_Sinhvien.Rows[i].Cells[6].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO SINHVIEN(MASV, HoSV,TENSV,PHAI,NGAYSINH,NOISINH,MALOP) VALUES('" + txtID.Text + "', N'" + txtHo.Text + "', N'" + txtTen.Text + "', N'" + cbx_Phai.Text + "','" + txtNgaySinh.Text + "', N'" + txtNoiSinh.Text + "','" + txtMaLop.Text + "')";
            command.ExecuteNonQuery();
            HienthidulieuSinhVien();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "UPDATE SINHVIEN SET HoSV = N'" + txtHo.Text + "', TENSV= N'" + txtTen.Text + "',PHAI= N'" + cbx_Phai.Text + "',NGAYSINH= '" + txtNgaySinh.Text + "',NOISINH= N'" + txtNoiSinh.Text + "',MALOP= '" + txtMaLop.Text + "'WHERE MASV = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            command.ExecuteNonQuery();
            HienthidulieuSinhVien();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MASV, HoSV,TENSV,PHAI,NGAYSINH,NOISINH,MALOP FROM SINHVIEN SV WHERE SV.MALOP IN (SELECT MALOP FROM LOP WHERE MAKHOA = '" + Program.maKhoa + "' ) AND MASV = '" +txtTimKiem.Text+ "'" ;
            command.ExecuteNonQuery();

            adapter.SelectCommand = command;

            //DataTable dt = Program.ExecSqlDataTable(strLenh);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dgv_Sinhvien.DataSource = dt;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
           
            HienthidulieuSinhVien();
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
    }
}
