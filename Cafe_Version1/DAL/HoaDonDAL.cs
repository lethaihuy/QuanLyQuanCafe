using Cafe_Version1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DAL
{
    class HoaDonDAL
    {
        private static HoaDonDAL instance;

        //Lấy hóa đơn chưa thanh toán của bàn
        public int LayIDHoaDonTuIDBan(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE IDBan = '" + id + "' AND trangThai = 0");
            if (data.Rows.Count > 0)
            {
                HoaDon hd = new HoaDon(data.Rows[0]);
                return hd._ID;
            }
            return -1;
        }



        public DataTable LayDanhSachHoaDonDaThanhToan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT B.tenBan, A.tongTien, A.ngayVao, A.nguoiTao FROM HoaDon AS A, Ban AS B WHERE A.trangThai = 1 AND A.IDBan = B.ID");
        }
        public void ThemHoaDon(int id, string user)
        {
            DataProvider.Instance.ExecuteQuerySuccess("EXEC USP_ThemHoaDon @idBan , @nguoitao", new object[] { id, user });
        }

        public int MAXIDHoaDon()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM HoaDon");
            }
            catch (Exception)
            {

                return -1;
            }
        }

        public void ThanhToan(int id, float tongTien)
        {
            string query = "UPDATE HoaDon SET ngayVao = GETDATE(), trangThai = 1 , tongTien = '" + tongTien + "' WHERE ID = " + id;
            DataProvider.Instance.ExecuteQuerySuccess(query);
        }

        public int SoLuongHoaDonDaThanhToan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE trangThai = 1").Rows.Count;
        }

        public int SoLuongHoaDonChuaThanhToan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE trangThai = 0").Rows.Count;
        }

        //Dang sua
        public DataTable XemHoaDonTheoNgay(string ngay)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_LayDanhHoaDonTheoNgay @ngayVao", new object[] { ngay });
        }

        public DataTable XemHoaDonTheoThang(int thang)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_LayDanhHoaDonTheoThang @thang", new object[] { thang });
        }

        public object TongTienTatCaHoaDon()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT SUM(tongTien) FROM HoaDon");
        }
        public object TongTienTheoNgay(string ngay)
        {
            string query = string.Format("SELECT SUM(tongTien) FROM HoaDon WHERE ngayVao = '{0}'", ngay);
            return DataProvider.Instance.ExecuteScalar(query);
        }

        public object TongTienTheoThang(int thang)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT SUM(tongTien) FROM HoaDon WHERE MONTH(ngayVao) = '" + thang + "'");
        }

        public DataTable InHoaDon(int idBan)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_InHoaDon @idBan", new object[] { idBan });
        }

        internal static HoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAL();
                }
                return HoaDonDAL.instance;
            }

            set
            {
                instance = value;
            }
        }
    }
}
