using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DoAnNMCNPM_QuanLyThuVien.DTO;

namespace DoAnNMCNPM_QuanLyThuVien.DAL
{
    public class TheDocGia_DAL
    {
        public TheDocGia_DAL()
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

        public bool Insert(TheDocGia_DTO thedocgia)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"INSERT INTO THEDOCGIA(MaThe, MaDocGia, LoaiThe, NgayLamThe, HanThe ) 
                VALUES (N'" + thedocgia.MaThe + "', N'" + thedocgia.MaDocGia + "', N'" + thedocgia.LoaiThe + "'" +
                ",N'" + thedocgia.NgayLamThe + "',N'" + thedocgia.HanThe + "')";

                // thuc hien insert
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true; // them thanh cong

            }
            catch
            {
                return false; // them that bai;
            }
        }

        public DataTable Select()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable table = new DataTable();
            string sqlQuery = @"SELECT   THEDOCGIA.MaThe,DOCGIA.MaDocGia,DOCGIA.TenDocGia, DOCGIA.NgaySinh,THEDOCGIA.NgayLamThe, THEDOCGIA.HanThe,THEDOCGIA.LoaiThe
                             FROM   DOCGIA INNER JOIN
                             THEDOCGIA ON DOCGIA.MaDocGia = THEDOCGIA.MaDocGia";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            aDapter.Fill(table);
            con.Close();
            return table;
        }

        public bool UpDate(TheDocGia_DTO thedocgia)
        {
            // thuoc tinh ma thu thu khong duoc cap nhap lai
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd;
                string sqlQuyery1 = " select count(*) from  THEDOCGIA  where MaThe = N'" + thedocgia.MaThe + "'";
                cmd = new SqlCommand(sqlQuyery1, con);
                var i = cmd.ExecuteScalar();
                if (int.Parse(i.ToString()) == 0)
                    return false;
                else
                {
                    string sqlQuery = @"Update THEDOCGIA  set MaDocGia = N'" + thedocgia.MaDocGia + "', NgayLamThe  =N'" + thedocgia.NgayLamThe
                    + "', HanThe = N'" + thedocgia.HanThe + "', LoaiThe = N'" + thedocgia.LoaiThe
                    + "' where MaThe = N'" + thedocgia.MaThe + "'";

                     cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(TheDocGia_DTO thedocgia)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "delete from THEDOCGIA where MaThe= '" + thedocgia.MaThe + "'";
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

        public DataTable Search(string loai, string tucantim)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable table = new DataTable();
            string sqlQuery = @"select * from THEDOCGIA  where [dbo].[fuChuyenCoDauThanhKhongDau](" + loai + ") like N'%' + [dbo].[fuChuyenCoDauThanhKhongDau](N'" + tucantim + "')+N'%'";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            aDapter.Fill(table);
            con.Close();
            return table;

        }

        public DataTable TimTenNgaySinhDocGia(string MaDocGia)
        {
           
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"SELECT   TenDocGia, NgaySinh
                                FROM   DOCGIA
                                Where MaDocGia = '" + MaDocGia + "'";
                DataTable table = new DataTable();
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                aDapter.Fill(table);
                con.Close();
            return table;
            
           
        }

        public bool KTDocGiaCoTonTaiTrongDsThe(string maDocGia)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = @"SELECT  count(*)
                                FROM   THEDOCGIA
                                Where MaDocGia = '" + maDocGia + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            var i = cmd.ExecuteScalar();

            if (int.Parse(i.ToString()) > 0)
                return true;
            else
                return false;

        }

     
    }
}
