using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DAL
{
    public class AccountDAL
    {
        DataProvider data = new DataProvider();
        public bool DangNhap(string username, string password)
        {
            string query = "SELECT * FROM WHERE username = '" + username + "' AND password='" + password + "'";
            DataTable result = data.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Account LayTaiKhoanDangNhap(string name)
        {
            DataTable duLieu = data.ExecuteQuery("SELECT * from Account WHERE username = '" + name + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
