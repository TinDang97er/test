using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNMCNPM_QuanLyThuVien.DAL
{
    class ChiTietMuonSach_DAL
    {
        public ChiTietMuonSach_DAL()
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

        public bool Insert(ChiTietMuonSach_DTO ctmuonsach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"insert into CHITIETMUON values ('" + ctmuonsach.MaPhieuMuon + "', '" + ctmuonsach.MaSach + "',N'" + ctmuonsach.ChuThich + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true; // muon thanh cong
            }
            catch
            {              
                return false; // muon that bai;
            }
        }

        public bool Delete(ChiTietMuonSach_DTO ctMuonSach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @" Delete CHITIETMUON where MaPhieuMuon = '" + ctMuonSach.MaPhieuMuon + "' and MaSach = '" + ctMuonSach.MaSach + "'";
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

        public bool UpdateTTSach(ChiTietMuonSach_DTO ct)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"update CUONSACH SET TinhTrang = 'Y', ChuThich = N'"+ct.ChuThich+"' WHERE  MaSach= '" + ct.MaSach + "'";
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
    }
}
