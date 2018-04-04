using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DAL
{
    public class BanDAL
    {
        private static BanDAL instance;

        public static int dai = 100;
        public static int rong = 100;
        public static BanDAL Instance
        {
            get
            {
                if (BanDAL.instance == null)
                {
                    instance = new BanDAL();
                }
                return BanDAL.instance;
            }

            set
            {
                instance = value;
            }
        }

        public List<Ban> LayDanhSachBan()
        {
            List<Ban> dsBan = new List<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDanhSachBan");
            foreach (DataRow item in data.Rows)
            {
                Ban b = new Ban(item);
                dsBan.Add(b);
            }
            return dsBan;
        }

        public bool ThemBan(string tenBan)
        {
            int a = DataProvider.Instance.ExecuteQuerySuccess("INSERT Ban(tenBan) VALUES(N'" + tenBan + "')");
            return a > 0;
        }

        public bool SuaBan(int ID, string tenBan)
        {
            string query = "UPDATE Ban SET tenBan = N'" + tenBan + "' WHERE ID = " + ID;
            int a = DataProvider.Instance.ExecuteQuerySuccess(query);
            return a > 0;
        }
        public bool XoaBan(int id)
        {
            return DataProvider.Instance.ExecuteQuerySuccess("DELETE FROM Ban WHERE ID = " + id) > 0;
        }
    }
}
