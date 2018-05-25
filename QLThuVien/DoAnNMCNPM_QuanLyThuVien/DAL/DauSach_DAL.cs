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
     public class DauSach_DAL
    {
        public DauSach_DAL()
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

        public bool Insert(DauSach_DTO dausach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"INSERT INTO DAUSACH(MaDauSach, TenDauSach, TacGia, TenTheLoai, NamSanXuat, NhaSanXuat, Gia, SoLuong) VALUES (N'" + dausach.MaDauSach + "', N'" + dausach.TenDauSach + "', N'" + dausach.TacGia + "',N'" + dausach.TenTheLoai + "', " + dausach.NamSanXuat + ",N'" + dausach.NhaSanXuat + "'," + dausach.Gia + "," + dausach.SoLuong + ")";
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
            string sqlQuery = "Select * from DAUSACH";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            aDapter.Fill(table);
            con.Close();
            return table;
        }

        public bool UpDate(DauSach_DTO dausach)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd;
                string sqlQuyery1 = "select count(*) from DAUSACh  where MaDauSach = '"+dausach.MaDauSach+"'";
                cmd = new SqlCommand(sqlQuyery1, con);
                var i = cmd.ExecuteScalar();
                if (int.Parse(i.ToString()) == 0)
                    return false;
                else
                {
                    string sqlQuery = @"Update DAUSACH set TenDauSach = N'" + dausach.TenDauSach + "',TacGia = N'" + dausach.TacGia + "',TenTheLoai = N'" + dausach.TenTheLoai
                    + "',NamSanXuat = " + dausach.NamSanXuat + ",NhaSanXuat = N'" + dausach.NhaSanXuat + "',Gia = " + dausach.Gia + ",SoLuong = " + dausach.SoLuong + " where MaDauSach = '" + dausach.MaDauSach + "'";
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

        public bool Delete(DauSach_DTO dausach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "delete from DAUSACH where MaDauSach= '" + dausach.MaDauSach + "'";
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
            string sqlQuery = @"select * from DAUSACH  where [dbo].[fuChuyenCoDauThanhKhongDau](" + loai + ") like N'%' + [dbo].[fuChuyenCoDauThanhKhongDau](N'" + tucantim + "')+N'%'";
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;        
        }

    }
}
