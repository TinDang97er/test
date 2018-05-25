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
    public class PhieuTra_DAL
    {
        public PhieuTra_DAL()
        {
            Connect();
        }

        SqlConnection con;
        strConnecting connect;

        void Connect()
        {
            connect = new strConnecting();
            con = new SqlConnection(connect.strConnect); ;
        }

        public DataTable Select()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuery = "Select * from PHIEUTRA";
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

        public bool Insert(PhieuTra_DTO t)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @" Insert into PHIEUTRA (MaPhieuTra, MaThe, MaThuThu,NgayTra, SoLuong) values 
                                    (N'" + t.MaPhieuTra + "',N'" + t.MaThe + "',N'" + t.MaThuThu + "',N'" + t.NgayTra + "',0 )";

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
        // Select co dieu kien
        public DataTable SelectTen(string maThe)
        {
              if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuery = "Select  TenDocGia  from DOCGIA , THEDOCGIA where THEDOCGIA.MaDocGia = DOCGIA.MaDocGia and MaThe='" + maThe + "'";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                aDapter.Fill(table);

                con.Close();
                return table;       
        }

        public DataTable SelectCTMuon(string maThe)
        {           
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuery = @" SELECT CHITIETMUON.MaPhieuMuon,CHITIETMUON.MaSach, DAUSACH.TenDauSach, TacGia, TenTheLoai, PHIEUMUON.NgayMuon, NgayDuKienTra, CHITIETMUON.ChuThich
                          FROM   CHITIETMUON INNER JOIN
                         CUONSACH ON CHITIETMUON.MaSach = CUONSACH.MaSach INNER JOIN
                         DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach INNER JOIN
                         PHIEUMUON ON CHITIETMUON.MaPhieuMuon = PHIEUMUON.MaPhieuMuon and  PHIEUMUON.MaThe = '"+maThe+"'";
					
					string sqlQuery1 = 	 @"where NOT EXISTS ( select *
											from PHIEUTRA inner join CHITIETTRA on PHIEUTRA.MaPhieuTra = CHITIETTRA.MaPhieuTra
											where CHITIETMUON.MaPhieuMuon = CHITIETTRA.MaPhieuMuon and CHITIETMUON.MaSach = CHITIETTRA.MaSach and PHIEUTRA.MaThe = '"+maThe+"')";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery + sqlQuery1, con);
                aDapter.Fill(table);
                con.Close();
                return table;
        }

        public string SelectMaPhieuTraCuoi()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "Select *from PHIEUTRA";
                SqlDataAdapter aDqpter = new SqlDataAdapter(sqlQuery, con);
                DataTable table = new DataTable();
                aDqpter.Fill(table);
                var i = table.Rows[table.Rows.Count - 1];
                string s = i[0].ToString();
                return s;
            }
            catch
            {
                return "";
            }


        }
    }
}
