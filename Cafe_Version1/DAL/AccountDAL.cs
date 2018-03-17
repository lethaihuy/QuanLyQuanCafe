using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DAL
{
    class AccountDAL
    {
        private static AccountDAL instance;

        internal static AccountDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAL();
                }
                return AccountDAL.instance;
            }

            set
            {
                instance = value;
            }
        }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM Account WHERE username = '" + username + "' AND password='" + password + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Account LayTaiKhoanDangNhap(string name)
        {
            DataTable duLieu = DataProvider.Instance.ExecuteQuery("SELECT * from Account WHERE username = '" + name + "'");

            foreach (DataRow item in duLieu.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
