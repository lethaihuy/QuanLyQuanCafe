using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Text.RegularExpressions;

namespace Cafe_Version1
{
    public partial class formInHoaDon : Form
    {
        public static int idBanInHD;
        public static string tenBanInHD;
        public static string tenThuNganInHD;



        public formInHoaDon()
        {
            InitializeComponent();


        }
        private void formInHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CAFE_VERSION_1ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "USP_InHoaDon";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@idBan", idBanInHD));
            //Khai báo dataset chứa dữ liệu
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"D:\Do An C#\He Quan Tri CSDL\QuanLyQuanCafe\Cafe_Version1\Report1.rdlc";

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                //Gắn lên report
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }

            ReportParameter p1 = new ReportParameter("rptTenBan", tenBanInHD.ToUpper().ToString());
            ReportParameter p2 = new ReportParameter("rptThuNgan", tenThuNganInHD.ToString());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p2 });

            this.reportViewer1.RefreshReport();
        }
    }
}
