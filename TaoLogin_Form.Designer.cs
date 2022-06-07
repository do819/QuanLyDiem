
namespace QuanLyDiem
{
    partial class TaoLogin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoLogin_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_SinhVien = new System.Windows.Forms.CheckBox();
            this.cb_AdminCN = new System.Windows.Forms.CheckBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.Label();
            this.TaiKhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TaoLogin = new System.Windows.Forms.Button();
            this.cb_Giangvien = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cb_Giangvien);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_SinhVien);
            this.panel1.Controls.Add(this.cb_AdminCN);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_TaiKhoan);
            this.panel1.Controls.Add(this.MatKhau);
            this.panel1.Controls.Add(this.TaiKhoan);
            this.panel1.Location = new System.Drawing.Point(12, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 322);
            this.panel1.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(186, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(251, 30);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên User: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Role: ";
            // 
            // cb_SinhVien
            // 
            this.cb_SinhVien.AutoSize = true;
            this.cb_SinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SinhVien.Location = new System.Drawing.Point(329, 207);
            this.cb_SinhVien.Name = "cb_SinhVien";
            this.cb_SinhVien.Size = new System.Drawing.Size(108, 26);
            this.cb_SinhVien.TabIndex = 7;
            this.cb_SinhVien.Text = "Sinh Viên";
            this.cb_SinhVien.UseVisualStyleBackColor = true;
            // 
            // cb_AdminCN
            // 
            this.cb_AdminCN.AutoSize = true;
            this.cb_AdminCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AdminCN.Location = new System.Drawing.Point(160, 207);
            this.cb_AdminCN.Name = "cb_AdminCN";
            this.cb_AdminCN.Size = new System.Drawing.Size(132, 26);
            this.cb_AdminCN.TabIndex = 6;
            this.cb_AdminCN.Text = "Admin Khoa";
            this.cb_AdminCN.UseVisualStyleBackColor = true;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(186, 106);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(251, 30);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(186, 66);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(251, 30);
            this.txt_TaiKhoan.TabIndex = 3;
            this.txt_TaiKhoan.TextChanged += new System.EventHandler(this.txt_TaiKhoan_TextChanged);
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.Location = new System.Drawing.Point(12, 114);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(93, 22);
            this.MatKhau.TabIndex = 2;
            this.MatKhau.Text = "Mật khẩu: ";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSize = true;
            this.TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoan.Location = new System.Drawing.Point(12, 69);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(135, 22);
            this.TaiKhoan.TabIndex = 1;
            this.TaiKhoan.Text = "Tên đăng nhập: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria Math", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(216, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 184);
            this.label2.TabIndex = 13;
            this.label2.Text = "TẠO TÀI KHOẢN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(465, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 163);
            this.panel2.TabIndex = 14;
            // 
            // btn_TaoLogin
            // 
            this.btn_TaoLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_TaoLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TaoLogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoLogin.Image")));
            this.btn_TaoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoLogin.Location = new System.Drawing.Point(465, 368);
            this.btn_TaoLogin.Name = "btn_TaoLogin";
            this.btn_TaoLogin.Size = new System.Drawing.Size(174, 47);
            this.btn_TaoLogin.TabIndex = 11;
            this.btn_TaoLogin.Text = "TẠO LOGIN";
            this.btn_TaoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoLogin.UseVisualStyleBackColor = false;
            this.btn_TaoLogin.Click += new System.EventHandler(this.btn_TaoLogin_Click);
            // 
            // cb_Giangvien
            // 
            this.cb_Giangvien.AutoSize = true;
            this.cb_Giangvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Giangvien.Location = new System.Drawing.Point(160, 253);
            this.cb_Giangvien.Name = "cb_Giangvien";
            this.cb_Giangvien.Size = new System.Drawing.Size(120, 26);
            this.cb_Giangvien.TabIndex = 12;
            this.cb_Giangvien.Text = "Giảng Viên";
            this.cb_Giangvien.UseVisualStyleBackColor = true;
            // 
            // TaoLogin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(845, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_TaoLogin);
            this.Name = "TaoLogin_Form";
            this.Text = "TaoLogin_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_SinhVien;
        private System.Windows.Forms.CheckBox cb_AdminCN;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.Label TaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TaoLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Giangvien;
    }
}