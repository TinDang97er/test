using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using System.Windows.Forms;


namespace DoAnNMCNPM_QuanLyThuVien.DAL
{
   public class CuonSach_DAL
    {
        public CuonSach_DAL ()
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

        public bool Insert(CuonSach_DTO cuonSach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"insert into CUONSACH (MaSach, MaDauSach, TinhTrang, NgayNhap, ChuThich) values(N'" + cuonSach.MaSach + "',N'" + cuonSach.MaDauSach + "',N'" + cuonSach.TinhTrang + "',N'" + cuonSach.NgayNhap + "',N'" + cuonSach.ChuThich + "') ";
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

        public bool Delete(CuonSach_DTO cuonSach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd;
                string sqlQuyery1 = " select count(*) from CUONSACH where MaSach = '" + cuonSach.MaSach + "'";
                cmd = new SqlCommand(sqlQuyery1, con);
                var i = cmd.ExecuteScalar();
                if (int.Parse(i.ToString()) == 0)
                    return false;
                {
                    string sqlQuery = @"Delete CUONSACH where MaSach = '" + cuonSach.MaSach + "'";
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

        public DataTable Select ()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuuery = @" SELECT  MaSach, TenDauSach, TacGia, TenTheLoai, NgayNhap,TinhTrang,ChuThich                        
                                  FROM  CUONSACH INNER JOIN
                                  DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;
            }
            catch
            {             
                return null;
            }        
        }

        public DataTable SelectCTClick( string maDauSach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuuery = @" SELECT  NamSanXuat,NhaSanXuat,Gia                        
                                  FROM  DAUSACH
                                   WHERE MaDauSach = '"+maDauSach+"'";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;
            }
            catch
            {            
                return null;

            }
        }

        public DataTable SelectCTEnter(string madausach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuuery = @" SELECT TenDauSach, TacGia, TenTheLoai, NamSanXuat,NhaSanXuat,Gia                        
                                  FROM  DAUSACH
                                   WHERE MaDauSach = '" + madausach + "'";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;
            }
            catch
            {
                return null;
            }
        }

        public DataTable  SelectMaDauSach(string maSach)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuuery = @" SELECT  MaDauSach                      
                                  FROM  CUONSACH 
                                   WHERE MaSach = '" + maSach + "'";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;
            }
            catch
            {
                return null;
            }
        }

        public bool Update(CuonSach_DTO cuonsach )
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd;
                string sqlQuyery1 = " select count(*) from CUONSACH where MaSach = '" + cuonsach.MaSach + "'";
                cmd = new SqlCommand(sqlQuyery1, con);
                var i = cmd.ExecuteScalar();
                if (int.Parse(i.ToString()) == 0)
                    return false;
                else
                {
                    string sqlQuery = @" Update CUONSACH set MaDauSach = '" + cuonsach.MaDauSach + "',ChuThich = N'" + cuonsach.ChuThich + "',NgayNhap = '" + cuonsach.NgayNhap + "' where MaSach = '" + cuonsach.MaSach + "'";
                    cmd  = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                          
            }
            catch( Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
         
        }
       
        public DataTable Search (string loai, string tuCanTim)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();

                string sqlQuery = @"SELECT  MaSach, TenDauSach, TacGia, TenTheLoai, NgayNhap,TinhTrang,ChuThich                        
                                  FROM  CUONSACH INNER JOIN
                                  DAUSACH ON CUONSACH.MaDauSach = DAUSACH.MaDauSach
                                 where  [dbo].[fuChuyenCoDauThanhKhongDau](" + loai + ") like N'%' + [dbo].[fuChuyenCoDauThanhKhongDau](N'" + tuCanTim + "')+N'%'";
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

        public DataTable SelectListMaDauSach ()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = "select  MaDauSach from DAUSACH ";
            DataTable table = new DataTable();
            SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
            aDapter.Fill(table);
            return table;

        }
    }
}
