using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DTO
{
    public class DanhMuc
    {
        private int ID;
        private string tenDanhMuc;

        public DanhMuc(int id, string ten)
        {
            this.ID = id;
            this.tenDanhMuc = ten;
        }

        public DanhMuc()
        {

        }
        public DanhMuc(DataRow item)
        {
            this.ID = (int)item["ID"];
            this.tenDanhMuc = item["tenDanhMuc"].ToString();
        }

        public int _ID
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string TenDanhMuc
        {
            get
            {
                return tenDanhMuc;
            }

            set
            {
                tenDanhMuc = value;
            }
        }
    }
}
