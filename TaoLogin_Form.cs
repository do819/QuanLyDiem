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
    public partial class TaoLogin_Form : Form
    {
        public TaoLogin_Form()
        {
            InitializeComponent();
        }

        private bool CheckValidate(TextBox tb, String str )
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TaoLogin_Click(object sender, EventArgs e)
        {
            if (!CheckValidate(txt_TaiKhoan, "Login name không để trống")) return;
            if (!CheckValidate(txt_Password, "Password không để trống")) return;
            if (!CheckValidate(txtUsername, "User name không để trống")) return;
            if (!(cb_AdminCN.Checked || cb_SinhVien.Checked)) 
            {
                MessageBox.Show("Role không được để trống", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            String role = "";
            if (cb_AdminCN.Checked)
                role = "ADMINCN";
            else if (cb_SinhVien.Checked)
                role = "SINHVIEN";
            else if (cb_Giangvien.Checked)
                role = "GIANGVIEN";

            try
            {
                String strLenh = "sp_Login";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;

                sqlCommand.Parameters.Add(new SqlParameter("@LoginName", txt_TaiKhoan.Text.Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@Password", txt_Password.Text.Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text.Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@Role", role));

                Program.ExecSQLCommand(sqlCommand);


            }
            catch (Exception)
            { }

        }
    }
}
