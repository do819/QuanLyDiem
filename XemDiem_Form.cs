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
    public partial class XemDiem_Form : Form
    {

        SqlConnection connection = new SqlConnection();
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();


        public XemDiem_Form()
        {
            InitializeComponent();
        }

        public void HienthidulieuDiem()
        {
            command = connection.CreateCommand();

            String strLenh = "SELECT MASV,MALTC,DIEM_QT,DIEM_GK,DIEM_CK FROM DIEM WHERE MALTC IN (SELECT MALTC FROM LOPTINCHI WHERE MAKHOA = '" + Program.maKhoa + "' ) AND MASV = '" +Program.userName+"'";
            //command.CommandText = strLenh;
            //adapter.SelectCommand = command;

            
            //DataTable dt = new DataTable();
            //dt.Clear();
            //adapter.Fill(dt);
            //dgv_XemDiem.DataSource = dt;



            SqlDataAdapter ada = new SqlDataAdapter(strLenh, Program.conn);

            ada.SelectCommand = new SqlCommand(strLenh, Program.conn);
           
            DataTable dt = new DataTable();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                dt.Clear();
                ada.Fill(dt);
                dgv_XemDiem.DataSource = dt;
            }

            
            catch (SqlException e1)
            {
                if (e1.Message.Contains("Error"))
                    MessageBox.Show("Loi");
                else
                    MessageBox.Show(e1.Message);
                Program.conn.Close();

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void XemDiem_Form_Load(object sender, EventArgs e)
        {
            HienthidulieuDiem();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            HienthidulieuDiem();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();

            String strLenh = "SELECT MASV,MALTC,DIEM_QT,DIEM_GK,DIEM_CK FROM DIEM WHERE MALTC IN (SELECT MALTC FROM LOPTINCHI WHERE MAKHOA = '" + Program.maKhoa + "' ) AND MALTC = '" + txtMaLoptc.Text + "'";
            //command.CommandText = strLenh;
            //adapter.SelectCommand = command;


            //DataTable dt = new DataTable();
            //dt.Clear();
            //adapter.Fill(dt);
            //dgv_XemDiem.DataSource = dt;



            SqlDataAdapter ada = new SqlDataAdapter(strLenh, Program.conn);

            ada.SelectCommand = new SqlCommand(strLenh, Program.conn);

            DataTable dt = new DataTable();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                dt.Clear();
                ada.Fill(dt);
                dgv_XemDiem.DataSource = dt;
            }


            catch (SqlException e1)
            {
                if (e1.Message.Contains("Error"))
                    MessageBox.Show("Loi");
                else
                    MessageBox.Show(e1.Message);
                Program.conn.Close();

            }
        }
    }
}
