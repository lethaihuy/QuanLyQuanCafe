using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DTO
{
    public class Account
    {
        private string username, password, tenHienThi;
        private int loaiTaiKhoan;
        private static Account instance;

        public Account(string name, string password, string tenHienThi, int loaiTaiKhoan)
        {
            this.username = name;
            this.password = password;
            this.tenHienThi = tenHienThi;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }

        public Account(DataRow item)
        {
            this.username = item["username"].ToString();
            this.password = item["password"].ToString();
            this.tenHienThi = item["tenHienThi"].ToString();
            this.loaiTaiKhoan = int.Parse(item["loaiTaiKhoan"].ToString());
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string TenHienThi
        {
            get
            {
                return tenHienThi;
            }

            set
            {
                tenHienThi = value;
            }
        }

        public static Account Instance
        {
            get
            {
                return instance;
            }

            set
            {
                instance = value;
            }
        }
    }
}
