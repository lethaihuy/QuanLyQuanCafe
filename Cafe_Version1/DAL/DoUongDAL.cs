using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DAL
{
    class DoUongDAL
    {
        private static DoUongDAL instance;
        internal static DoUongDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoUongDAL();
                }
                return DoUongDAL.instance;
            }

            set
            {
                DoUongDAL.instance = value;
            }
        }

        public List<DoUong> LayDanhSachDoUong()
        {
            List<DoUong> ds = new List<DoUong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM DoUong ORDER BY tenThucUong");
            foreach (DataRow item in data.Rows)
            {
                DoUong nuoc = new DoUong(item);
                ds.Add(nuoc);
            }
            return ds;
        }

        public List<DoUong> LayDanhSachDoUongTheoID(int id)
        {
            List<DoUong> ds = new List<DoUong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM DoUong WHERE IDDanhMuc = " + id);
            foreach (DataRow item in data.Rows)
            {
                DoUong nuoc = new DoUong(item);
                ds.Add(nuoc);
            }
            return ds;
        }

        public bool ThemDoUong(string tenDoUong, int thuocDM, float giaTien)
        {
            string them = string.Format("INSERT DoUong(tenDoUong, IDDanhMuc, gia) VALUES(N'{0}', {1}, {2})", tenDoUong, thuocDM, giaTien);
            return DataProvider.Instance.ExecuteQuerySuccess(them) > 0;
        }

        public bool SuaDoUong(int id, string tenDoUong, int thuocDM, float giaTien)
        {
            string them = string.Format("UPDATE DoUong SET tenDoUong = N'{0}' , IDDanhMuc = {1} , giaTien = {2} WHERE ID = {3}", tenDoUong, thuocDM, giaTien, id);
            return DataProvider.Instance.ExecuteQuerySuccess(them) > 0;
        }

        public bool XoaDoUong(int id)
        {
            return DataProvider.Instance.ExecuteQuerySuccess("DELETE FROM DoUong WHERE ID = " + id) > 0;
        }
    }
}
