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
    public class ThuThu_DAL
    {

    public ThuThu_DAL()
    {
            Connect();
    }

      SqlConnection con;
      strConnecting conect;

     void Connect ()
     {
            conect = new strConnecting();       
            con  = new SqlConnection(conect.strConnect);
      }

     public bool Insert(ThuThu_DTO thuthu)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = @"INSERT INTO THUTHU(MaThuThu, TenThuThu, GioiTinh, NgaySinh,DiaChi,Email, ChucVu ) VALUES (N'"+thuthu.MaThuThu+"', N'"+thuthu.HoTen+"', N'"+thuthu.GioiTinh+"',N'"+thuthu.NgaySinh+"',N'"+thuthu.DiaChi+"',N'"+thuthu.Email+"',N'"+thuthu.ChucVu+"')";
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

     public  DataTable Select()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable table = new DataTable();
                string sqlQuery = "Select * from ThuThu ";
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

     public bool UpDate(ThuThu_DTO thuthu)
        {
            // thuoc tinh ma thu thu khong duoc cap nhap lai
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd;
                string sqlQuyery1 = " select count(*) from  ThuThu  where MaThuThu = N'" + thuthu.MaThuThu + "'";
                cmd = new SqlCommand(sqlQuyery1, con);
                var i = cmd.ExecuteScalar();
                if (int.Parse(i.ToString()) == 0)
                    return false;
                else
                {
                    string sqlQuery = @"Update ThuThu  set TenThuThu = N'" + thuthu.HoTen + "', NgaySinh =N'" + thuthu.NgaySinh
                    + "', GioiTinh = N'" + thuthu.GioiTinh + "', DiaChi = N'" + thuthu.DiaChi + "',Email =N'" + thuthu.Email + "',ChucVu =N'" + thuthu.ChucVu + "' where MaThuThu = '" + thuthu.MaThuThu + "'";
                    cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }catch
            {
                return false;
            }
        }

     public bool Delete(ThuThu_DTO thuthu)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "Delete from ThuThu where MaThuThu= '" + thuthu.MaThuThu + "'";
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

                string sqlQuery = @"select * from THUTHU where [dbo].[fuChuyenCoDauThanhKhongDau]("+loai+") like N'%' + [dbo].[fuChuyenCoDauThanhKhongDau](N'"+tucantim+"')+N'%'";
                SqlDataAdapter aDapter = new SqlDataAdapter(sqlQuery, con);
                aDapter.Fill(table);
                con.Close();
                return table;         
        }
    }
}
