using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnNMCNPM_QuanLyThuVien.DTO;

namespace DoAnNMCNPM_QuanLyThuVien.DAL
{
   public class QuyDinh2_DAL
    {
        public QuyDinh2_DAL()
        {
            Connect();
        }

        SqlConnection con;
        strConnecting connect;

        void Connect()
        {
            connect = new strConnecting();
            con = new SqlConnection(connect.strConnect);
        }

        public bool Update(QuyDinh2_DTO qd)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "Update QUYDINH2 set SoTheLoai = " + qd.SoTheLoai + ",HanThoiGianNhanSach = " + qd.HanNhanSach + " Where ID = 1";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;

            }
            catch
            {
                return false;
            }

        }

        public DataTable Select()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = "Select SoTheLoai, HanThoiGianNhanSach from QUYDINH2";
            SqlDataAdapter aDApter = new SqlDataAdapter(sqlQuery, con);
            DataTable table = new DataTable();
            aDApter.Fill(table);
            con.Close();
            return table;
        }
    }
}
