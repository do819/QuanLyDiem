using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static SqlConnection conn = new SqlConnection();
        public static String connStr;
        public static String conn_Publisher = "Data Source = DESKTOP-2PN6TQ8\\MAYCHU; Initial Catalog = QuanLyDiem; Integrated Security = True ";


        public static SqlDataReader myReader;
        public static String serverName = "";
        public static String userName = "";
        public static String mLogin = "";
        public static string password = "";

        public static String database = "QuanLyDiem";
        public static String remoteLogin = "HoTroKetNoi";
        public static String remotePassword = "123456";
        public static String mLoginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHo = "";
        public static String mTen = "";
        public static int mKhoa = 0;
        public static String maKhoa = "";
        public static String maSV = "";

        public static Main_Form frmChinh;
        public static Login_Form frmLogin;
        public static QlyGV frmQlyGV;
        public static Qlysinhvien frmQlysinhvien;

       



        public static BindingSource bds_DSK = new BindingSource();

        public static int KetNoi()
        {
            if( Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open )
            {
                Program.conn.Close();
            }

            try
            {
                Program.connStr = "Data Source=" + Program.serverName.ToString() + "; Initial CataLog= " + Program.database+ "; User ID=" + Program.mLogin+ "; password=" + Program.password;
                //Console.WriteLine(Program.connStr);
                Program.conn.ConnectionString = Program.connStr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi csdl");
                return 0;
            }
        }

        internal static DataTable ExecSqlDataTable(string strLenh)
        {
            throw new NotImplementedException();
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = System.Data.CommandType.Text;
            if (Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch(Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void ExecSQLCommand(SqlCommand sqlCommand)
        {
            if(Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                sqlCommand.ExecuteNonQuery();
                Program.conn.Close();
            }
            catch (SqlException e)
            {
                if (e.Message.Contains("error"))
                    MessageBox.Show("Lỗi");
                else 
                    MessageBox.Show(e.Message);
                Program.conn.Close();
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main_Form());
            frmChinh =  new Main_Form();
            Application.Run(frmChinh);
        }
    }
}
