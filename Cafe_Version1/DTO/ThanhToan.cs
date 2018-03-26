using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DTO
{
    class ThanhToan
    {
        private string tenDoUong;
        private int soLuong;
        private float giaTien, tongTien;

        public ThanhToan(string ten, int soLuong, float gia, float tongTien = 0)
        {
            this.tenDoUong = ten;
            this.soLuong = soLuong;
            this.giaTien = gia;
            this.tongTien = tongTien;
        }

        public ThanhToan(DataRow row)
        {
            this.tenDoUong = row["tenThucUong"].ToString();
            this.soLuong = (int)row["soLuong"];
            this.giaTien = (float)Convert.ToDouble(row["gia"]);
            this.tongTien = (float)Convert.ToDouble(row["tongTien"]);
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

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
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

        public float TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }
    }
}
