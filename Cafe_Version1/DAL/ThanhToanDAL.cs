using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DAL
{
    class ThanhToanDAL
    {
        private static ThanhToanDAL instance;

        public List<ThanhToan> LayDanhSachDoUongTheoIDBan(int id)
        {
            List<ThanhToan> danhSach = new List<ThanhToan>();
            string query = @"SELECT C.tenThucUong, B.soLuong, C.gia, (B.soLuong*c.gia) AS N'tongTien' 
                                FROM HoaDon AS A, ThongTinHoaDon AS B, DoUong AS C
                                WHERE A.ID = B.IDHoaDon AND B.IDDoUong = C.ID AND A.trangThai = 0 AND A.IDBan = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThanhToan menu = new ThanhToan(item);
                danhSach.Add(menu);
            }
            return danhSach;
        }

        internal static ThanhToanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThanhToanDAL();
                }
                return ThanhToanDAL.instance;
            }

            set
            {
                instance = value;
            }
        }
    }
}
