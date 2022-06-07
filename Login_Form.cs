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
    public partial class Login_Form : Form
    {
        SqlConnection conn_publisher = new SqlConnection();
        QlyGV qlyGV = new QlyGV();
        Main_Form main_Form = new Main_Form();
        TabPage tabPage = new TabPage();
        
        
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cbx_Khoa.SelectedValue.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            if(KetNoi_MayChu() == 0)
            {
                return;
            }
            LayDSK("SELECT * FROM v_GetSubcribers");
            
            cbx_Khoa.SelectedIndex = 0;
            Program.serverName = cbx_Khoa.SelectedValue.ToString();
        }

        public void LayDSK( String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();

            Program.bds_DSK.DataSource = dt;
            
            cbx_Khoa.DataSource = Program.bds_DSK;
            cbx_Khoa.DisplayMember = "TENKHOA";
            cbx_Khoa.ValueMember = "TENSERVER";

            
            
        }



        private int KetNoi_MayChu()
        {
            if(conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }

            try
            {
                conn_publisher.ConnectionString = Program.conn_Publisher;
                conn_publisher.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Loi ket noi du lieu goc");
                return 0;
            }
        }

        private Form IsExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                    return f;
            }
            return null;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(txt_TaiKhoan.Text.Trim() == "" || txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("Login name va mat khau khong duoc de trong", "", MessageBoxButtons.OK);
                return;

            }

            Program.mLogin = txt_TaiKhoan.Text.Trim();
            Program.password = txt_Password.Text.Trim();

            if (Program.KetNoi() == 0)
            {
                return;
            }

            // set 2 nút button check GV và SV, 
            if (cb_Admin.Checked == true)
            {
                Program.mKhoa = cbx_Khoa.SelectedIndex;
                Program.maKhoa = cbx_Khoa.Text;
                Program.mLoginDN = Program.mLogin;
                Program.passwordDN = Program.password;
                //Sưa khuc nay
                String strLenh = "EXEC sp_Lay_Thong_Tin_GV_Tu_Login '" + Program.mLogin + "'";
                Console.WriteLine(strLenh);
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();

                Program.userName = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.userName))
                {
                    MessageBox.Show("Tai khoan khong co quyen truy cap");
                    return;
                }
                Program.mHo = Program.myReader.GetString(1);
                Program.mTen = Program.myReader.GetString(2);
                //Program.mGroup = Program.myReader.GetString(3);

                Program.myReader.Close();
                Program.conn.Close();

                Program.frmChinh.MSSV.Text = "Ma GV = " + Program.userName;
                Program.frmChinh.HO.Text = "Ho GV = " + Program.mHo;
                Program.frmChinh.TEN.Text = "Ten GV = " + Program.mTen;

                Program.frmChinh.HienThiMenuAdmin();
                
                //Program.frmLogin.Close();
                //Form frm1 = this.IsExists(typeof(QlyGV));
                //if (frm1 != null)
                //{
                //    frm1.Activate();
                //}
                //else
                //{
                  
                //    qlyGV.MdiParent = main_Form;
                    //Program.frmLogin.Close();
                 //   qlyGV.Show();
                //}
                

               
                //qlyGV.Show();
                this.Close();
            }

            else if (cb_GiangVien.Checked == true)
            {
                Program.mKhoa = cbx_Khoa.SelectedIndex;
                Program.maKhoa = cbx_Khoa.Text;
                Program.mLoginDN = Program.mLogin;
                Program.passwordDN = Program.password;
                //Sưa khuc nay
                String strLenh = "EXEC sp_Lay_Thong_Tin_GV_Tu_Login '" + Program.mLogin + "'";
                Console.WriteLine(strLenh);
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();

                Program.userName = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.userName))
                {
                    MessageBox.Show("Tai khoan khong co quyen truy cap");
                    return;
                }
                Program.mHo = Program.myReader.GetString(1);
                Program.mTen = Program.myReader.GetString(2);
                //Program.mGroup = Program.myReader.GetString(3);

                Program.myReader.Close();
                Program.conn.Close();

                Program.frmChinh.MSSV.Text = "Ma GV = " + Program.userName;
                Program.frmChinh.HO.Text = "Ho GV = " + Program.mHo;
                Program.frmChinh.TEN.Text = "Ten GV = " + Program.mTen;

                Program.frmChinh.HienThiMenuGiangVien();
                //Program.frmChinh.HienThiMenu();
                this.Close();
            }
            else if(cb_SinhVien.Checked == true)
            {
                Program.mKhoa = cbx_Khoa.SelectedIndex;
                Program.maKhoa = cbx_Khoa.Text;
                Program.mLoginDN = Program.mLogin;
                Program.passwordDN = Program.password;
                //Sưa khuc nay
                String strLenh = "EXEC sp_Lay_Thong_Tin_SV_Tu_Login '" + Program.mLogin + "'";
                Console.WriteLine(strLenh);
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();

                Program.userName = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.userName))
                {
                    MessageBox.Show("Tai khoan khong co quyen truy cap");
                    return;
                }
                Program.mHo = Program.myReader.GetString(1);
                Program.mTen = Program.myReader.GetString(2);
                //Program.mGroup = Program.myReader.GetString(3);

                Program.myReader.Close();
                Program.conn.Close();

                Program.frmChinh.MSSV.Text = "Ma SV = " + Program.userName;
                Program.frmChinh.HO.Text = "Ho SV = " + Program.mHo;
                Program.frmChinh.TEN.Text = "Ten SV = " + Program.mTen;

                Program.frmChinh.HienThiMenuSinhVien();
                //Program.frmChinh.HienThiMenu();
                this.Close();
            }

            
            //Program.frmChinh..Text = "Ten SV = " + Program.mTen;

            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                //Application.Exit();
                this.Close();
            }
        }

        private void cb_SinhVien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_GiangVien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void MatKhau_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_Admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
