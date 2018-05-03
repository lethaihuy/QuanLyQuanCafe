using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DAL
{
    class ChiTietHoaDonDAL
    {
        private static ChiTietHoaDonDAL instance;

        public ChiTietHoaDonDAL() { }

        public int LayIDDoUongTuIDHoaDon(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT IDDoUong FROM ThongTinHoaDon WHERE IDHoaDon = '" + id + "'");
            if (data.Rows.Count > 0)
            {
                DoUong du = new DoUong(data.Rows[2]);
                return du.ID;
            }
            return -1;
        }

        public List<ChiTietHoaDon> LaydanhSachChiTietHoaDon(int idHoaDon)
        {
            List<ChiTietHoaDon> danhSach = new List<ChiTietHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ThongTinHoaDon WHERE IDHoaDon = " + idHoaDon);
            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon(item);
                danhSach.Add(cthd);
            }
            return danhSach;
        }

        public void ThemChiTietHoaDon(int idHoaDon, int idDoUong, int sl)
        {
            DataProvider.Instance.ExecuteQuerySuccess("EXEC USP_ThemChiTietHaDon @idHoaDon , @idDoUong , @sl", new object[] { idHoaDon, idDoUong, sl });
        }


        internal static ChiTietHoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonDAL();
                }
                return ChiTietHoaDonDAL.instance;
            }

            set
            {
                ChiTietHoaDonDAL.instance = value;
            }
        }
    }
}
