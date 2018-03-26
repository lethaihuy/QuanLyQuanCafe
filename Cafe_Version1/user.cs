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
    public partial class formUser : Form
    {
        public formUser()
        {
            InitializeComponent();
        }

        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();
        private void pnheader_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void pnheader_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void pnheader_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
