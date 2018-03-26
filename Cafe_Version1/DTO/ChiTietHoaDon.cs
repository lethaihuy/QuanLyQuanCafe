using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DTO
{
    class ChiTietHoaDon
    {
        private int ID, IDBan, IDDoUong, soLuong;
 
        public ChiTietHoaDon(int id, int idBan, int idDoUong, int sl)
        {
            this.ID = id;
            this.IDBan = idBan;
            this.IDDoUong = idDoUong;
            this.soLuong = sl;
        }

        public ChiTietHoaDon(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDBan = (int)row["IDBan"];
            this.IDDoUong = (int)row["IDDoUong"];
            this.soLuong = (int)row["soLuong"];
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

        public int _IDDoUong
        {
            get
            {
                return IDDoUong;
            }

            set
            {
                IDDoUong = value;
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
    }
}
