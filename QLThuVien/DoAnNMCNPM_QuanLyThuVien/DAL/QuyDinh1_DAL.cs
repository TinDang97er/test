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
  public  class QuyDinh1_DAL
    {
        public QuyDinh1_DAL()
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

        public bool Update (QuyDinh1_DTO qd)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery = "Update QUYDINH1 set TuoiMin = " + qd.TuoiMin + ",TuoiMax = " + qd.TuoiMax + ", HanThe = " + qd.HanThe + " Where ID = 1";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

        }

        public DataTable Select ()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sqlQuery = "Select TuoiMin, TuoiMax, HanThe from QUYDINH1";
            SqlDataAdapter aDApter = new SqlDataAdapter(sqlQuery, con);
            DataTable table = new DataTable();
            aDApter.Fill(table);       
            con.Close();
            return table;
        }
    }
}
