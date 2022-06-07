using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class Main_Form : Form
    {
        //QlyGV qlyGV = new QlyGV();
        public Main_Form()
        {
            InitializeComponent();
        }

        public void HienThiMenuAdmin()
        {
           
            MSSV.Text = "Ma GV = " + Program.userName;
            HO.Text = "Ho GV = " + Program.mHo;
            TEN.Text = "Ten GV = " + Program.mTen;

            rib_QlyThongTin.Visible = true;
            rib_Quanlydiem.Visible = true;


        }

        public void HienThiMenuSinhVien()
        {

            MSSV.Text = "Ma SV = " + Program.userName;
            HO.Text = "Ho SV = " + Program.mHo;
            TEN.Text = "Ten SV = " + Program.mTen;

            rib_Xemdiem.Visible = true;
            


        }

        public void HienThiMenuGiangVien()
        {

            MSSV.Text = "Ma GV = " + Program.userName;
            HO.Text = "Ho GV = " + Program.mHo;
            TEN.Text = "Ten GV = " + Program.mTen;

            rib_QuanlydiemGV.Visible = true;



        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

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
             

        private void ribbonButton_DangNhap_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(Login_Form));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Login_Form f = new Login_Form();
                f.MdiParent = this;
                f.Show();
            }

           
        }
        public void addform(TabPage tp, Form f)
        {

            f.TopLevel = false;
            //no border if needed
            f.FormBorderStyle = FormBorderStyle.None;
            f.AutoScaleMode = AutoScaleMode.Dpi;

            if (!tp.Controls.Contains(f))
            {
                tp.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();
                Refresh();
            }
            Refresh();
        }

        private void tabGV_Click(object sender, EventArgs e)
        {

        }

        private void tabQly_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rib_Giangvien_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(QlyGV));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                QlyGV f = new QlyGV();
                Qlysinhvien f1 = new Qlysinhvien();  
                f.MdiParent = this;
                f.Show();
                f1.Hide();
            }

        }

        private void rib_Sinhvien_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(Qlysinhvien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Qlysinhvien f = new Qlysinhvien();
                QlyGV f1 = new QlyGV();
                f.MdiParent = this;
                f.Show();
                f1.Hide();
            }

        }

        private void rib_Qlydiem_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(Qlydiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Qlydiem f = new Qlydiem();
                
                f.MdiParent = this;
                f.Show();
                
            }
        }

        private void rib_Xuatpdf_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(BangDiem_Form));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                BangDiem_Form f = new BangDiem_Form();

                f.MdiParent = this;
                f.Show();

            }
        }

        private void rib_XemBangDiem_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(XemDiem_Form));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                XemDiem_Form f = new XemDiem_Form();

                f.MdiParent = this;
                f.Show();

            }
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {

        }

        private void rib_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(TaoLogin_Form));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                TaoLogin_Form f = new TaoLogin_Form();

                f.MdiParent = this;
                f.Show();

            }
        }

        private void rib_BangdiemGV_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(QlydiemGV));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                QlydiemGV f = new QlydiemGV();

                f.MdiParent = this;
                f.Show();

            }
        }

        private void ribbonButton_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExists(typeof(Login_Form));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Login_Form f = new Login_Form();
                f.MdiParent = this;
                f.Show();
            }

        }
    }
}
