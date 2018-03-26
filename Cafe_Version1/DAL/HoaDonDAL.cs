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

        public void ThanhToan(int id)
        {
            string query = "UPDATE HoaDon SET ngayVao = GETDATE(), trangThai = 1 WHERE ID = " + id;
            DataProvider.Instance.ExecuteQuerySuccess(query);
        }

        internal static HoaDonDAL Instance
        {
            get
            {
                if(instance == null)
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
