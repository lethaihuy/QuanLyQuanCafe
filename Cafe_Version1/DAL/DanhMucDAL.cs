using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DAL
{
    class DanhMucDAL
    {
        private static DanhMucDAL instance;

        public List<DanhMuc> LayDanhSachDanhMuc()
        {
            List<DanhMuc> dsDanhMuc = new List<DanhMuc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM DanhMuc");
            foreach (DataRow item in data.Rows)
            {
                DanhMuc dm = new DanhMuc(item);
                dsDanhMuc.Add(dm);
            }
            return dsDanhMuc;
        }

        public DanhMuc LayDanhSachDanhMucTheoID(int id)
        {
            DanhMuc dm = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELCT * FROM DanhMuc WHERE ID = " + id);
            foreach (DataRow item in data.Rows)
            {
                dm = new DanhMuc(item);
            }
            return dm;
        }
        internal static DanhMucDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DanhMucDAL();
                }
                return DanhMucDAL.instance;
            }

            set
            {
                instance = value;
            }
        }
    }
}
