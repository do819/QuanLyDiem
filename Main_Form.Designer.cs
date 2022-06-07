
namespace QuanLyDiem
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rib_HeThong = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton_DangNhap = new System.Windows.Forms.RibbonButton();
            this.rib_QlyThongTin = new System.Windows.Forms.RibbonTab();
            this.rib_Giangvien = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.rib_Sinhvien = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.rib_TaoTaiKhoan = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.rib_Quanlydiem = new System.Windows.Forms.RibbonTab();
            this.rib_Qlydiem = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.rib_Xuatpdf = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.rib_Xemdiem = new System.Windows.Forms.RibbonTab();
            this.rib_XemBangDiem = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.rib_QuanlydiemGV = new System.Windows.Forms.RibbonTab();
            this.rib_BangdiemGV = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MSSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HO = new System.Windows.Forms.ToolStripStatusLabel();
            this.TEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 116);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(832, 177);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.rib_HeThong);
            this.ribbon1.Tabs.Add(this.rib_QlyThongTin);
            this.ribbon1.Tabs.Add(this.rib_Quanlydiem);
            this.ribbon1.Tabs.Add(this.rib_Xemdiem);
            this.ribbon1.Tabs.Add(this.rib_QuanlydiemGV);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.LargeImage")));
            this.ribbonOrbMenuItem1.Name = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // rib_HeThong
            // 
            this.rib_HeThong.Name = "rib_HeThong";
            this.rib_HeThong.Panels.Add(this.ribbonPanel1);
            this.rib_HeThong.Panels.Add(this.ribbonPanel2);
            this.rib_HeThong.Text = "Hệ thống";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton_DangNhap);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Đăng nhập";
            this.ribbonPanel1.Click += new System.EventHandler(this.ribbonPanel1_Click);
            // 
            // ribbonButton_DangNhap
            // 
            this.ribbonButton_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton_DangNhap.Image")));
            this.ribbonButton_DangNhap.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_DangNhap.LargeImage")));
            this.ribbonButton_DangNhap.MaximumSize = new System.Drawing.Size(500, 500);
            this.ribbonButton_DangNhap.Name = "ribbonButton_DangNhap";
            this.ribbonButton_DangNhap.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_DangNhap.SmallImage")));
            this.ribbonButton_DangNhap.Text = "";
            this.ribbonButton_DangNhap.Click += new System.EventHandler(this.ribbonButton_DangNhap_Click);
            // 
            // rib_QlyThongTin
            // 
            this.rib_QlyThongTin.Name = "rib_QlyThongTin";
            this.rib_QlyThongTin.Panels.Add(this.rib_Giangvien);
            this.rib_QlyThongTin.Panels.Add(this.rib_Sinhvien);
            this.rib_QlyThongTin.Panels.Add(this.rib_TaoTaiKhoan);
            this.rib_QlyThongTin.Text = "Quản lý thông tin";
            this.rib_QlyThongTin.Visible = false;
            // 
            // rib_Giangvien
            // 
            this.rib_Giangvien.Image = ((System.Drawing.Image)(resources.GetObject("rib_Giangvien.Image")));
            this.rib_Giangvien.Items.Add(this.ribbonButton1);
            this.rib_Giangvien.Name = "rib_Giangvien";
            this.rib_Giangvien.Text = "Giảng Viên";
            this.rib_Giangvien.Click += new System.EventHandler(this.rib_Giangvien_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            // 
            // rib_Sinhvien
            // 
            this.rib_Sinhvien.Items.Add(this.ribbonButton2);
            this.rib_Sinhvien.Name = "rib_Sinhvien";
            this.rib_Sinhvien.Text = "Sinh Viên";
            this.rib_Sinhvien.Click += new System.EventHandler(this.rib_Sinhvien_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            // 
            // rib_TaoTaiKhoan
            // 
            this.rib_TaoTaiKhoan.Items.Add(this.ribbonButton3);
            this.rib_TaoTaiKhoan.Name = "rib_TaoTaiKhoan";
            this.rib_TaoTaiKhoan.Text = "Tạo tài khoản";
            this.rib_TaoTaiKhoan.Click += new System.EventHandler(this.rib_TaoTaiKhoan_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            // 
            // rib_Quanlydiem
            // 
            this.rib_Quanlydiem.Name = "rib_Quanlydiem";
            this.rib_Quanlydiem.Panels.Add(this.rib_Qlydiem);
            this.rib_Quanlydiem.Panels.Add(this.rib_Xuatpdf);
            this.rib_Quanlydiem.Text = "Quản lý điểm";
            this.rib_Quanlydiem.Visible = false;
            // 
            // rib_Qlydiem
            // 
            this.rib_Qlydiem.Items.Add(this.ribbonButton4);
            this.rib_Qlydiem.Name = "rib_Qlydiem";
            this.rib_Qlydiem.Text = "Kết quả học tập";
            this.rib_Qlydiem.Click += new System.EventHandler(this.rib_Qlydiem_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Click += new System.EventHandler(this.ribbonButton4_Click);
            // 
            // rib_Xuatpdf
            // 
            this.rib_Xuatpdf.Items.Add(this.ribbonButton5);
            this.rib_Xuatpdf.Name = "rib_Xuatpdf";
            this.rib_Xuatpdf.Text = "In bảng điểm";
            this.rib_Xuatpdf.Click += new System.EventHandler(this.rib_Xuatpdf_Click);
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.LargeImage")));
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Click += new System.EventHandler(this.ribbonButton5_Click);
            // 
            // rib_Xemdiem
            // 
            this.rib_Xemdiem.Name = "rib_Xemdiem";
            this.rib_Xemdiem.Panels.Add(this.rib_XemBangDiem);
            this.rib_Xemdiem.Text = "Kết quả học tập";
            this.rib_Xemdiem.Visible = false;
            // 
            // rib_XemBangDiem
            // 
            this.rib_XemBangDiem.Items.Add(this.ribbonButton6);
            this.rib_XemBangDiem.Name = "rib_XemBangDiem";
            this.rib_XemBangDiem.Text = "Xem kết quả";
            this.rib_XemBangDiem.Click += new System.EventHandler(this.rib_XemBangDiem_Click);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.LargeImage")));
            this.ribbonButton6.Name = "ribbonButton6";
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            // 
            // rib_QuanlydiemGV
            // 
            this.rib_QuanlydiemGV.Name = "rib_QuanlydiemGV";
            this.rib_QuanlydiemGV.Panels.Add(this.rib_BangdiemGV);
            this.rib_QuanlydiemGV.Text = "Quản lý điểm";
            this.rib_QuanlydiemGV.Visible = false;
            // 
            // rib_BangdiemGV
            // 
            this.rib_BangdiemGV.Items.Add(this.ribbonButton7);
            this.rib_BangdiemGV.Name = "rib_BangdiemGV";
            this.rib_BangdiemGV.Text = "Xem bảng điểm";
            this.rib_BangdiemGV.Click += new System.EventHandler(this.rib_BangdiemGV_Click);
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.LargeImage")));
            this.ribbonButton7.Name = "ribbonButton7";
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSSV,
            this.HO,
            this.TEN});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(832, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MSSV
            // 
            this.MSSV.Name = "MSSV";
            this.MSSV.Size = new System.Drawing.Size(37, 20);
            this.MSSV.Text = "       ";
            // 
            // HO
            // 
            this.HO.Name = "HO";
            this.HO.Size = new System.Drawing.Size(29, 20);
            this.HO.Text = "     ";
            // 
            // TEN
            // 
            this.TEN.Name = "TEN";
            this.TEN.Size = new System.Drawing.Size(25, 20);
            this.TEN.Text = "    ";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.ribbonButton8);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Đăng xuất";
            this.ribbonPanel2.Click += new System.EventHandler(this.ribbonPanel2_Click);
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.Image")));
            this.ribbonButton8.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.LargeImage")));
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab rib_HeThong;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton_DangNhap;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MSSV;
        public System.Windows.Forms.ToolStripStatusLabel HO;
        public System.Windows.Forms.ToolStripStatusLabel TEN;
        private System.Windows.Forms.RibbonTab rib_QlyThongTin;
        private System.Windows.Forms.RibbonPanel rib_Giangvien;
        private System.Windows.Forms.RibbonPanel rib_Sinhvien;
        private System.Windows.Forms.RibbonPanel rib_TaoTaiKhoan;
        private System.Windows.Forms.RibbonTab rib_Quanlydiem;
        private System.Windows.Forms.RibbonPanel rib_Qlydiem;
        private System.Windows.Forms.RibbonPanel rib_Xuatpdf;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonTab rib_Xemdiem;
        private System.Windows.Forms.RibbonPanel rib_XemBangDiem;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonTab rib_QuanlydiemGV;
        private System.Windows.Forms.RibbonPanel rib_BangdiemGV;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton8;
    }
}