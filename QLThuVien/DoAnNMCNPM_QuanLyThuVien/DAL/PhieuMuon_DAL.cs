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
    public class PhieuMuon_DAL
    {

        public PhieuMuon_DAL()
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

        public DataTable Select()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable table = new DataTable();
            string sqlQuery = @"SELECT  CUONSACH.MaSach, TenDauSach, TenTheLoai, TacGia, TinhTrang, ChuThich
                               FROM dbo.DAUSACH INNER JOIN
                         CUONSACH ON DAUSACH.MaDauSach = CUONSACH.MaDauSach";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            aDapter.Fill(table);
            con.Close();
            return table;
        }

        public bool Insert(PhieuMuon_DTO muonsach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sqlQuery = @"INSERT INTO PhieuMuon(MaPhieuMuon,MaThuThu,MaThe,NgayMuon, NgayDuKienTra, SoLuong) VALUES (  '" + muonsach.MaPhieuMuon + "', '" + muonsach.MaThuThu + "', '" + muonsach.MaThe + "', '" + muonsach.NgayMuon + "','" + muonsach.NgayDuKienTra + "'," + muonsach.SoLuong + ")";
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

        public DataTable SelectTTSach()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = @"SELECT  MaSach, TenDauSach, TenTheLoai, TacGia, TinhTrang, ChuThich
                                    FROM CUONSACH INNER JOIN
                                    DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            DataTable table = new DataTable();
            aDapter.Fill(table);
            return table;
        }

        public string TimTen(string maThe)
        {
            try
            {
                // Tạo connection
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuery = @"select DOCGIA.TenDocGia from THEDOCGIA,DOCGIA where THEDOCGIA.MaDocGia=DOCGIA.MaDocGia and THEDOCGIA.MaThe='" + maThe + "'";
                //string sqlQuery = @"select DOCGIA.TenDocGia ,NgayMuon + 5 as ngaytra from THEDOCGIA, DOCGIA, PHIEUMUON where PHIEUMUON.MaThe = THEDOCGIA.MaThe AND THEDOCGIA.MaDocGia = DOCGIA.MaDocGia and THEDOCGIA.MaThe = '" + muonsach.MaThe.ToString() + "' AND MaPhieuMuon = '" + muonsach.MaPhieuMuon.ToString() + "'";
                // SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                // aDapter.Fill(table);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                var name = cmd.ExecuteScalar();
                con.Close();
                return name.ToString();
            }
            catch
            {
                return null;
            }
          
        }
        // lấy ra giá trị hạn thẻ
        public string  HanThe(string maThe)
        {
            // Tạo connection
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable table = new DataTable();

            string sqlQuery = @"select HanThe from THEDOCGIA where MaThe='" + maThe + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            var time = cmd.ExecuteScalar();
            con.Close();
            return time.ToString();
        }
    
        public DataTable TimKiem(string TimKiemTheo, string tucantim)
        {         
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();

                string sqlQuery = @"SELECT  MaSach, TenDauSach, TenTheLoai, TacGia, TinhTrang, ChuThich
                                    FROM CUONSACH INNER JOIN
                                    DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach
                                   where [dbo].[fuChuyenCoDauThanhKhongDau](" + TimKiemTheo+ ") like N'%' + [dbo].[fuChuyenCoDauThanhKhongDau](N'" + tucantim + "')+N'%'";    
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;        
        }

        public string   SoLuongSachMuonTuTruoc(string maThe)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuery =@"SELECT count(*)
                          FROM   CHITIETMUON INNER JOIN
                         CUONSACH ON CHITIETMUON.MaSach = CUONSACH.MaSach INNER JOIN
                         DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach INNER JOIN
                         PHIEUMUON ON CHITIETMUON.MaPhieuMuon = PHIEUMUON.MaPhieuMuon and  PHIEUMUON.MaThe = '" + maThe + "'";

                string sqlQuery1 = @"where NOT EXISTS ( select *
											from PHIEUTRA inner join CHITIETTRA on PHIEUTRA.MaPhieuTra = CHITIETTRA.MaPhieuTra
											where CHITIETMUON.MaPhieuMuon = CHITIETTRA.MaPhieuMuon and CHITIETMUON.MaSach = CHITIETTRA.MaSach and PHIEUTRA.MaThe = '" + maThe + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery+sqlQuery1, con);
                var i = cmd.ExecuteScalar();
                return i.ToString();
            }
            catch( Exception e)
            {
                MessageBox.Show(e.ToString());
                return "0";
            }
            
        }

        public string SelectMaPhieuMuonCuoi()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "Select *from PHIEUMUON";
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

        public DataTable SelectTTPMkhongTonTaiTrongMaPhieuTra()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = @"SELECT  distinct CHITIETMUON.MaPhieuMuon , TheDocGia.MaThe,TenDocGia, PHIEUMUON.NgayMuon, NgayDuKienTra
                          FROM   CHITIETMUON INNER JOIN
                         CUONSACH ON CHITIETMUON.MaSach = CUONSACH.MaSach INNER JOIN
                         DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach INNER JOIN
                         PHIEUMUON ON CHITIETMUON.MaPhieuMuon = PHIEUMUON.MaPhieuMuon  INNER join 
						THEDOCGIA on THEDOCGIA.MaThe = PHIEUMUON.MaThe Inner join 
						DOCGIA on DOCGIA.MaDocGia = THEDOCGIA.MaDocGia				
					    where NOT EXISTS ( select *
											from PHIEUTRA inner join CHITIETTRA on PHIEUTRA.MaPhieuTra = CHITIETTRA.MaPhieuTra
											where CHITIETMUON.MaPhieuMuon = CHITIETTRA.MaPhieuMuon and CHITIETMUON.MaSach = CHITIETTRA.MaSach )";
            DataTable table = new DataTable();
            SqlDataAdapter aDaprer = new SqlDataAdapter(sqlQuery, con);
            aDaprer.Fill(table);
            con.Close();
            return table;

        }

        public DataTable SearchTTSachChuaTra(string loai, string tuCanTim)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = @"SELECT  distinct CHITIETMUON.MaPhieuMuon , TheDocGia.MaThe,TenDocGia, PHIEUMUON.NgayMuon, NgayDuKienTra
                          FROM   CHITIETMUON INNER JOIN
                         CUONSACH ON CHITIETMUON.MaSach = CUONSACH.MaSach INNER JOIN
                         DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach INNER JOIN
                         PHIEUMUON ON CHITIETMUON.MaPhieuMuon = PHIEUMUON.MaPhieuMuon  INNER join 
						THEDOCGIA on THEDOCGIA.MaThe = PHIEUMUON.MaThe Inner join 
						DOCGIA on DOCGIA.MaDocGia = THEDOCGIA.MaDocGia
					
					where NOT EXISTS ( select *
											from PHIEUTRA inner join CHITIETTRA on PHIEUTRA.MaPhieuTra = CHITIETTRA.MaPhieuTra
											where CHITIETMUON.MaPhieuMuon = CHITIETTRA.MaPhieuMuon and CHITIETMUON.MaSach = CHITIETTRA.MaSach ) and  [dbo].[fuChuyenCoDauThanhKhongDau]("+loai+") like N'%' + [dbo].[fuChuyenCoDauThanhKhongDau](N'"+tuCanTim+"')+N'%'";
            DataTable table = new DataTable();
            SqlDataAdapter aDaprer = new SqlDataAdapter(sqlQuery, con);
            aDaprer.Fill(table);
            con.Close();
            return table;
        }
        public DataTable SelectTTCTSachChuaTra(string maPhieuMuon)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = @"SELECT    CuonSach.MaSach,TenDauSach, TacGia, TenTheLoai,CHITIETMUON.ChuThich
                          FROM   CHITIETMUON INNER JOIN
                         CUONSACH ON CHITIETMUON.MaSach = CUONSACH.MaSach INNER JOIN
                         DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach INNER JOIN
                         PHIEUMUON ON CHITIETMUON.MaPhieuMuon = PHIEUMUON.MaPhieuMuon and CHITIETMUON.MaPhieuMuon='" + maPhieuMuon + "'	";								
			string   sqlQuery1 =   @"where NOT EXISTS ( select *
											from PHIEUTRA inner join CHITIETTRA on PHIEUTRA.MaPhieuTra = CHITIETTRA.MaPhieuTra
											where CHITIETMUON.MaPhieuMuon = CHITIETTRA.MaPhieuMuon and CHITIETMUON.MaSach = CHITIETTRA.MaSach )";
            DataTable table = new DataTable();
            SqlDataAdapter aDaprer = new SqlDataAdapter(sqlQuery + sqlQuery1, con);
            aDaprer.Fill(table);
            con.Close();
            return table;
        }

    }
}
