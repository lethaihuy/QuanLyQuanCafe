using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DTO
{
    class DoUong
    {
        private int iD;
        private string tenDoUong;
        private int iDDanhMuc;
        private float giaTien;

        public DoUong(int id, string ten, int idDanhMuc, float gia)
        {
            this.iD = id;
            this.tenDoUong = ten;
            this.iDDanhMuc = idDanhMuc;
            this.giaTien = gia;
        }

        public DoUong(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.tenDoUong = row["tenThucUong"].ToString();
            this.iDDanhMuc = (int)row["IDDanhMuc"];
            this.giaTien = (float)Convert.ToDouble(row["gia"].ToString());
        }

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string TenDoUong
        {
            get
            {
                return tenDoUong;
            }

            set
            {
                tenDoUong = value;
            }
        }

        public int IDDanhMuc
        {
            get
            {
                return iDDanhMuc;
            }

            set
            {
                iDDanhMuc = value;
            }
        }

        public float GiaTien
        {
            get
            {
                return giaTien;
            }

            set
            {
                giaTien = value;
            }
        }
    }
}
