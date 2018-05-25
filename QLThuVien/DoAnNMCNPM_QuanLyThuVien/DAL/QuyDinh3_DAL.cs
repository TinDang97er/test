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
   public class QuyDinh3_DAL
    {
        public QuyDinh3_DAL()
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

        public bool Update(QuyDinh3_DTO qd)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
              
                string sqlQuery = "Update  QUYDINH3 set SoSachMuonToiDa = "+qd.SoLuongSachToiDa+",ThoiGianMuonToiDa = "+qd.SoNgayMuonToiDa+" where ID = 1 ";
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
            DataTable table = new DataTable();
            string sqlQuery = "Select SoSachMuonToiDa , ThoiGianMuonToiDa from QUYDINH3";
            SqlDataAdapter aDapter  = new SqlDataAdapter(sqlQuery, con);
            aDapter.Fill(table);
            return table;
     
        }
    }
}
