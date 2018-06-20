using Cafe_Version1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cafe_Version1
{
    public partial class chart : Form
    {
        public float x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public chart()
        {
            InitializeComponent();
            VeBieuDo();
        }

         void VeBieuDo()
        {
            if (HoaDonDAL.Instance.TongTienTheoThang(1) is DBNull)
            {
                x1 = 0;
            }
            else
            {
                x1 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(1));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(2) is DBNull)
            {
                x2 = 0;
            }
            else
            {
                x2 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(2));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(3) is DBNull)
            {
                x3 = 0;
            }
            else
            {
                x3 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(3));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(4) is DBNull)
            {
                x4 = 0;
            }
            else
            {
                x4 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(4));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(5) is DBNull)
            {
                x5 = 0;
            }
            else
            {
                x5 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(5));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(6) is DBNull)
            {
                x6 = 0;
            }
            else
            {
                x6= (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(6));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(1) is DBNull)
            {
                x7 = 0;
            }
            else
            {
                x7 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(7));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(8) is DBNull)
            {
                x8 = 0;
            }
            else
            {
                x8 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(8));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(9) is DBNull)
            {
                x9 = 0;
            }
            else
            {
                x9 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(9));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(10) is DBNull)
            {
                x10 = 0;
            }
            else
            {
                x10 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(10));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(11) is DBNull)
            {
                x11 = 0;
            }
            else
            {
                x11 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(11));
            }
            if (HoaDonDAL.Instance.TongTienTheoThang(12) is DBNull)
            {
                x12 = 0;
            }
            else
            {
                x12 = (float)Convert.ToDouble(HoaDonDAL.Instance.TongTienTheoThang(12));
            }

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 2000000;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 200000;

            chart1.Series.Add("Doanh thu");
            chart1.Series["Doanh thu"].ChartType = SeriesChartType.Line;
            chart1.Series["Doanh thu"].Color = Color.Blue;
            chart1.Series[0].IsVisibleInLegend = false;

            chart1.Series["Doanh thu"].Points.AddXY(1, x1);
            chart1.Series["Doanh thu"].Points.AddXY(2, x2);
            chart1.Series["Doanh thu"].Points.AddXY(3, x3);
            chart1.Series["Doanh thu"].Points.AddXY(4, x4);
            chart1.Series["Doanh thu"].Points.AddXY(5, x5);
            chart1.Series["Doanh thu"].Points.AddXY(6, x6);
            chart1.Series["Doanh thu"].Points.AddXY(7, x7);
            chart1.Series["Doanh thu"].Points.AddXY(8, x8);
            chart1.Series["Doanh thu"].Points.AddXY(9, x9);
            chart1.Series["Doanh thu"].Points.AddXY(10, x10);
            chart1.Series["Doanh thu"].Points.AddXY(11, x11);
            chart1.Series["Doanh thu"].Points.AddXY(12, x12);

        }
    }
}
