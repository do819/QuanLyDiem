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
    public partial class Qlydiem : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public Qlydiem()
        {
            InitializeComponent();
        }

        public void HienthidulieuDiem()
        {
            command = connection.CreateCommand();

            String strLenh = "SELECT MALTC, MASV,DIEM_QT,DIEM_GK,DIEM_CK FROM DIEM WHERE MALTC IN (SELECT MALTC FROM LOPTINCHI WHERE MAKHOA = '" + Program.maKhoa + "' )";
            command.CommandText = strLenh;
            adapter.SelectCommand = command;

            //DataTable dt = Program.ExecSqlDataTable(strLenh);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dgv_Diem.DataSource = dt;
            //dgv_GiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dgv_GiangVien.Columns[0].HeaderText = "Mã giảng viên";
            //dgv_GiangVien.Columns[1].HeaderText = "Mã khoa";
            //dgv_GiangVien.Columns[2].HeaderText = "Họ giảng viên";
            //dgv_GiangVien.Columns[3].HeaderText = "Tên giảng viên";

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Diem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dgv_Diem.CurrentRow.Index;
            txtID.Text = dgv_Diem.Rows[i].Cells[1].Value.ToString();
            txtMaLoptc.Text = dgv_Diem.Rows[i].Cells[0].Value.ToString();
            txtDiemQT.Text = dgv_Diem.Rows[i].Cells[2].Value.ToString();
            txtDiemGK.Text = dgv_Diem.Rows[i].Cells[3].Value.ToString();
            txtDiemCK.Text = dgv_Diem.Rows[i].Cells[4].Value.ToString();
         
        }

        private void Qlydiem_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Program.conn_Publisher);
            connection.Open();

            HienthidulieuDiem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO DIEM(MALTC,MASV,DIEM_QT,DIEM_GK,DIEM_CK) VALUES('" + txtMaLoptc.Text + "','" + txtID.Text + "','" + txtDiemQT.Text + "','" + txtDiemGK.Text + "','" + txtDiemCK.Text +"')";
            command.ExecuteNonQuery();
            HienthidulieuDiem();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtMaLoptc.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "UPDATE DIEM SET DIEM_QT = '" + txtDiemQT.Text + "', DIEM_GK= '" + txtDiemGK.Text + "',DIEM_CK= '" + txtDiemCK.Text + "' WHERE MASV = '" + txtID.Text + "' AND MALTC = '"+ txtMaLoptc.Text + "'";
            command.ExecuteNonQuery();
            command.ExecuteNonQuery();
            HienthidulieuDiem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM DIEM WHERE MASV= '" + txtID.Text + "' AND MALTC = '" + txtMaLoptc.Text + "'";
            command.ExecuteNonQuery();
            HienthidulieuDiem();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            HienthidulieuDiem();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MALTC,MASV,DIEM_QT,DIEM_GK,DIEM_CK FROM DIEM WHERE MASV = '" + txtTimKiemID.Text + "' AND MALTC = '" + txtTimKiemMTC.Text + "'";
            command.ExecuteNonQuery();

            adapter.SelectCommand = command;

            //DataTable dt = Program.ExecSqlDataTable(strLenh);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dgv_Diem.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
