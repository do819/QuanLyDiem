using Microsoft.Reporting.WinForms;
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
    public partial class BangDiem_Form : Form
    {
        public BangDiem_Form()
        {
            InitializeComponent();
        }

        private void BangDiem_Form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.reportBangDiem.RefreshReport();
        }

        private void reportBangDiem_Load(object sender, EventArgs e)
        {
            string strLenh = "sp_BangDiem";
            SqlDataAdapter ada = new SqlDataAdapter(strLenh, Program.conn);

            ada.SelectCommand = new SqlCommand(strLenh, Program.conn);
            ada.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                ada.Fill(ds);

                //che do xem report
                reportBangDiem.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportBangDiem.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportBangDiem.ZoomPercent = 100;

                reportBangDiem.LocalReport.ReportEmbeddedResource = "QuanLyDiem.BangDiem_Report.rdlc";

                //
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Tao nguojn du lieu cho bao cao
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet_BangDiem";
                    rds.Value = ds.Tables[0];

                    //Xoa du lieu cu
                    reportBangDiem.LocalReport.DataSources.Clear();

                    //add du lieu
                    reportBangDiem.LocalReport.DataSources.Add(rds);
                    //refresh
                    reportBangDiem.RefreshReport();
                }

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
