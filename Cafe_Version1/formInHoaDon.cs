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

namespace Cafe_Version1
{
    public partial class formInHoaDon : Form
    {
        public static int idBanInHoaDon;
        public formInHoaDon()
        {
            InitializeComponent();
        }

        private void formInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CAFE_VERSION_1DataSet1.USP_InHoaDon' table. You can move, or remove it, as needed.
            //DataTable data =  HoaDonDAL.Instance.InHoaDon(idBanInHoaDon);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
