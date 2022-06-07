
namespace QuanLyDiem
{
    partial class BangDiem_Form
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
            this.reportBangDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportBangDiem
            // 
            this.reportBangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBangDiem.Location = new System.Drawing.Point(0, 0);
            this.reportBangDiem.Name = "reportBangDiem";
            this.reportBangDiem.ServerReport.BearerToken = null;
            this.reportBangDiem.Size = new System.Drawing.Size(800, 450);
            this.reportBangDiem.TabIndex = 0;
            this.reportBangDiem.Load += new System.EventHandler(this.reportBangDiem_Load);
            // 
            // BangDiem_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportBangDiem);
            this.Name = "BangDiem_Form";
            this.Text = "BangDiem_Form";
            this.Load += new System.EventHandler(this.BangDiem_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportBangDiem;
    }
}