using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Version1.DTO
{
    class DataProvider
    {
        private string chuoiKetNoi = @"Data Source=HUY\SQLEXPRESS;Initial Catalog=CAFE_VERSION_1;Integrated Security=True";
        private static DataProvider instance;

        internal static DataProvider Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }

            set
            {
                instance = value;
            }
        }


        //Trả về bảng khi thực thi câu lệnh select
        public DataTable ExecuteQuery(string query, object[] thamSo = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(chuoiKetNoi))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (thamSo != null)
                {
                    string[] danhSachThamSo = query.Split(' ');
                    int i = 0;
                    foreach (string item in danhSachThamSo)
                    {
                        command.Parameters.AddWithValue(item, thamSo[i]);
                        i++;
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }

        //Trả về số dòng thực thi thành công
        public int ExecuteQuerySuccess(string query, object[] thamSo = null)
        {
            int soDong = 0;
            SqlConnection connect = new SqlConnection(chuoiKetNoi);
            connect.Open();

            SqlCommand command = new SqlCommand(query, connect);
            if (thamSo != null)
            {
                string[] danhSachThamSo = query.Split(' ');
                int i = 0;
                foreach (string item in danhSachThamSo)
                {
                    command.Parameters.AddWithValue(item, thamSo[i]);
                    i++;
                }
            }
            soDong = command.ExecuteNonQuery();
            connect.Close();

            return soDong;
        }

    }
}
