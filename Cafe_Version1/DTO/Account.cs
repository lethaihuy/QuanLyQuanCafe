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
        private string username, password, tenHienThi, loaiTaiKhoan;

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

        public string LoaiTaiKhoan
        {
            get
            {
                return loaiTaiKhoan;
            }

            set
            {
                loaiTaiKhoan = value;
            }
        }

        public Account(string name, string password, string tenHienThi, string loaiTaiKhoan)
        {
            this.Username = name;
            this.Password = password;
            this.TenHienThi = tenHienThi;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }

        public Account(DataRow item)
        {
            this.Username = item["username"].ToString();
            this.Password = item["password"].ToString();
            this.TenHienThi = item["tenHienThi"].ToString();
            this.LoaiTaiKhoan = item["loaiTaiKhoan"].ToString();
        }

    }
}
