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
   public class DocGia_DAL
    {
        public DocGia_DAL()
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

        public bool Insert(DocGia_DTO docgia)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"INSERT INTO DOCGIA(MaDocGia,TenDocGia,GioiTinh,NgaySinh,DiaChi,Email) 
                VALUES (N'" + docgia.MaDocGia + "',N'" + docgia.HoTen + "',N'" + docgia.GioiTinh + "',N'" + docgia.NgaySinh + "',N'" + docgia.DiaChi + "',N'" + docgia.Email + "')";

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
            string sqlQuery = "Select *from DOCGIA";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            aDapter.Fill(table);
            con.Close();
            return table;
        }

        public bool Update(DocGia_DTO docgia)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd;
                string sqlQuyery1 = " select count(*) from DocGia WHERE MaDocGia = N'" + docgia.MaDocGia + "'";
                cmd = new SqlCommand(sqlQuyery1, con);
                var i = cmd.ExecuteScalar();
                if (int.Parse(i.ToString()) == 0)
                    return false;
                else
                {
                    string sqlQuery = @"Update DocGia set TenDocGia = N'" + docgia.HoTen + "',GioiTinh = N'" + docgia.GioiTinh + "', NgaySinh = N'" + docgia.NgaySinh + "', DiaChi = N'" + docgia.DiaChi + "', Email = N'" + docgia.Email + "' WHERE MaDocGia = N'" + docgia.MaDocGia + "' ";

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

        public bool Delete(DocGia_DTO docgia)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "delete from DOCGIA where MaDocGia= '" + docgia.MaDocGia + "'";
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
            string sqlQuery = @"select * from DOCGIA where [dbo].[fuChuyenCoDauThanhKhongDau](" + loai + ") like N'%' + [dbo].[fuChuyenCoDauThanhKhongDau](N'" + tucantim + "')+N'%'";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            aDapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
