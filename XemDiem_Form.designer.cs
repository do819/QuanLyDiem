
namespace QuanLyDiem
{
    partial class XemDiem_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDiem_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_XemDiem = new System.Windows.Forms.DataGridView();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.txtMaLoptc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(208, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANG QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_XemDiem);
            this.panel1.Location = new System.Drawing.Point(117, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 220);
            this.panel1.TabIndex = 1;
            // 
            // dgv_XemDiem
            // 
            this.dgv_XemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XemDiem.Location = new System.Drawing.Point(0, 3);
            this.dgv_XemDiem.Name = "dgv_XemDiem";
            this.dgv_XemDiem.RowHeadersWidth = 51;
            this.dgv_XemDiem.RowTemplate.Height = 24;
            this.dgv_XemDiem.Size = new System.Drawing.Size(649, 217);
            this.dgv_XemDiem.TabIndex = 0;
            this.dgv_XemDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.ForeColor = System.Drawing.Color.Red;
            this.btnEXIT.Location = new System.Drawing.Point(726, 572);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(98, 44);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            // 
            // txtMaLoptc
            // 
            this.txtMaLoptc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoptc.Location = new System.Drawing.Point(340, 199);
            this.txtMaLoptc.Name = "txtMaLoptc";
            this.txtMaLoptc.Size = new System.Drawing.Size(212, 30);
            this.txtMaLoptc.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã lớp tín chỉ: ";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Teal;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(196, 258);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(137, 46);
            this.btnReload.TabIndex = 32;
            this.btnReload.Text = "TẢI LẠI";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(406, 258);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(190, 46);
            this.btnFind.TabIndex = 31;
            this.btnFind.Text = "TÌM KIẾM";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // XemDiem_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtMaLoptc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "XemDiem_Form";
            this.Text = "Xem Điểm";
            this.Load += new System.EventHandler(this.XemDiem_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_XemDiem;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TextBox txtMaLoptc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnFind;
    }
}