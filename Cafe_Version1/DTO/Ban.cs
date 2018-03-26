using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DTO
{
    public class Ban
    {
        private int ID;
        private string tenBan;
        private string trangThai;

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

        public string TenBan
        {
            get
            {
                return tenBan;
            }

            set
            {
                tenBan = value;
            }
        }

        public string TrangThai
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

        public Ban(DataRow item)
        {
            this.ID = int.Parse(item["ID"].ToString());
            this.tenBan = item["tenBan"].ToString();
            this.trangThai = item["trangThai"].ToString();
        }

        public Ban(int id, string ten, string trangThai)
        {
            this.ID = id;
            this.tenBan = ten;
            this.trangThai = trangThai;
        }



    }
}
