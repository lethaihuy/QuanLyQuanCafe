using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<Account> LayDanhSachTaiKhoan()
        {
            List<Account> dsAcc = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account");
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                dsAcc.Add(acc);
            }
            return dsAcc;
        }

        public bool ThemTaiKhoan(string username, string password, string tenHienThi, string loaiTK, string anhDaiDien)
        {
            string query = string.Format("INSERT Account VALUES('{0}' , '{1}' , N'{2}' , N'{3}' , '{4}')", username, password, tenHienThi, loaiTK, anhDaiDien);
            return DataProvider.Instance.ExecuteQuerySuccess(query) > 0;
        }

        public bool SuaTaiKhoan(string username, string password, string tenHienThi, string anhDaiDien)
        {
            string query = string.Format("UPDATE Account SET tenHienThi = N'{0}' , anhDaiDien = '{1}' WHERE username = '{2}'  AND password = '{3}' ", tenHienThi, anhDaiDien, username, password);
            return DataProvider.Instance.ExecuteQuerySuccess(query) > 0;
        }

        public bool ThayDoiMatKhau(string username, string password, string tenHienThi)
        {
            string query = string.Format("UPDATE Account SET password = '{0}' , tenHienThi = N'{1}' WHERE username = '{2}'", password, tenHienThi, username);
            return DataProvider.Instance.ExecuteQuerySuccess(query) > 0;
        }

        public bool XoaTaiKhoan(string username)
        {
            return DataProvider.Instance.ExecuteQuerySuccess("DELETE FROM Account WHERE username = '" + username + "'") > 0;
        }
    }
}
