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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM DoUong");
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

        
    }
}
