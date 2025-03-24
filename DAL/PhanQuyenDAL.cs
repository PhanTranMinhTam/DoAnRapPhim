using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PhanQuyenDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public PhanQuyenDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public DataTable layDanhSachQuyen(string maChucVu)
        {
            SqlConnection conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "Select DM_ManHinh.maManHinh, tenManHinh, coQuyen from PhanQuyen, DM_ManHinh where PhanQuyen.maManHinh = DM_ManHinh.maManHinh and PhanQuyen.maChucVu = '" + maChucVu + "' ORDER BY DM_ManHinh.maManHinh ASC";
            //string sql = "Select tenManHinh, coQuyen from PhanQuyen, DM_ManHinh where PhanQuyen.maManHinh = DM_ManHinh.maManHinh and PhanQuyen.maChucVu = '" + maChucVu + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getDSQuyen()
        {
            SqlConnection conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "Select * from PhanQuyen";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return dt;
        }

        public bool themQuyen(PhanQuyenDTO phanQuyen)
        {
            SqlConnection conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "Insert into PhanQuyen values('" + phanQuyen.MaChucVu + "', '" + phanQuyen.MaManHinh + "', '" + phanQuyen.CoQuyen + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (kq > 0)
            {
                return true;
            }
            return false;
        }

        public bool suaQuyen(PhanQuyenDTO phanQuyen)
        {
            SqlConnection conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "Update PhanQuyen set coQuyen = '" + phanQuyen.CoQuyen + "' where maChucVu = '" + phanQuyen.MaChucVu + "' and maManHinh = '" + phanQuyen.MaManHinh + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (kq > 0)
            {
                return true;
            }
            return false;
        }

        public bool xoaQuyen(string maChucVu, string maManHinh)
        {
            SqlConnection conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "Delete PhanQuyen where maChucVu = '" + maChucVu + "' and maManHinh = '" + maManHinh + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
    }
}
