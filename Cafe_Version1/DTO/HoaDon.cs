using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DTO
{
    class HoaDon
    {
        private int ID, IDBan;
        private DateTime ngay;
        private int trangThai;
        private string nguoiTao;

        public HoaDon(int id, int idBan, DateTime ngay, int trangThai, string nguoiTao)
        {
            this.ID = id;
            this.IDBan = idBan;
            this.Ngay = ngay;
            this.TrangThai = trangThai;
            this.NguoiTao = nguoiTao;
        }

        public HoaDon (DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDBan = (int)row["IDBan"];
            this.ngay = (DateTime)row["ngayVao"];
            this.trangThai = (int)row["trangThai"];
            this.nguoiTao = row["nguoiTao"].ToString();
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

        public int _IDBan
        {
            get
            {
                return IDBan;
            }

            set
            {
                IDBan = value;
            }
        }

        public DateTime Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public int TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public string NguoiTao
        {
            get
            {
                return nguoiTao;
            }

            set
            {
                nguoiTao = value;
            }
        }
    }
}
