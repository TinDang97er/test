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
   public class ChiTietTraSach_DAL
    {
        public ChiTietTraSach_DAL()
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

        public bool Insert(ChiTietTraSach_DTO ct)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"Insert into CHITIETTRA (MaPhieuTra,MaPhieuMuon,MaSach,SoNgayTraMuon,ChuThich) values
                                    (N'" + ct.MaPhieuTra+"',N'"+ct.MaPhieuMuon+"',N'"+ct.MaSach+"',"+ct.SoNgayTraMuon+", '"+ct.ChuThich+"')";
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

        public DataTable SelectTTSachTra(ChiTietTraSach_DTO ct)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();

                string sqlQuery = @"  SELECT  PHIEUMUON.MaPhieuMuon, CHITIETTRA.MaSach,.DAUSACH.TenDauSach,  DAUSACH.TenTheLoai,DAUSACH.TacGia, PHIEUMUON.NgayMuon,CHITIETTRA.SoNgayTraMuon,CHITIETTRA.ChuThich
                           FROM    CHITIETTRA INNER JOIN
                         CUONSACH ON CHITIETTRA.MaSach = CUONSACH.MaSach INNER JOIN
                         DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach INNER JOIN
                         PHIEUMUON ON CHITIETTRA.MaPhieuMuon = PHIEUMUON.MaPhieuMuon and CHITIETTRA.MaPhieuMuon = '"+ct.MaPhieuMuon+"' and CHITIETTRA.MaSach = '"+ct.MaSach+"'";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                aDapter.Fill(table);
                con.Close();

                   return table;
            }
            catch           
            {               
                return null;
            }
        }

        public bool Delete (ChiTietTraSach_DTO ct)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "Delete from CHITIETTRA where MaPhieuTra = '" + ct.MaPhieuTra + "' and MaSach= '" + ct.MaSach + "'";
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

        public bool Updtate(ChiTietTraSach_DTO ct)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "Update CHITIETTRA  Set GhiChu = N'" + ct.ChuThich + "' where MaPhieuMuon = '" + ct.MaPhieuMuon + "' and MaSach = '" + ct.MaSach + "'";
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

        public bool UpdateTTSach(ChiTietTraSach_DTO ct)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "Update CUONSACH  Set  TinhTrang ='N', ChuThich = N'"+ct.ChuThich+"'where MaSach = '"+ct.MaSach+"'";
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
