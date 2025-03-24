using DTO;
using System;
using System.Data;
using System.Linq;

namespace DAL
{
    public class KhuyenMaiDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public KhuyenMaiDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public DataTable layDSKhuyenMai()
        {
            var query = from km in db.KhuyenMais
                        select new
                        {
                            MaKM = km.maKhuyenMai,
                            TenKM = km.tenKM,
                            ThoiGianBD = km.thoiGianBD,
                            ThoiGianKT = km.thoiGianKT,
                            PhanTramKM = km.phanTramKhuyenMai,
                            TrangThai = km.trangThai
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("MaKM");
            dt.Columns.Add("TenKM");
            dt.Columns.Add("ThoiGianBD");
            dt.Columns.Add("ThoiGianKT");
            dt.Columns.Add("PhanTramKM");
            dt.Columns.Add("TrangThai");
            foreach (var item in query)
            {
                dt.Rows.Add(item.MaKM, item.TenKM, item.ThoiGianBD, item.ThoiGianKT, item.PhanTramKM, item.TrangThai);
            }
            return dt;
        }

        //lấy % khuyến mãi theo mã khuyến mãi
        public decimal? layPhanTramKMTheoMaKM(string maKM)
        {
            IQueryable<decimal?> query = from km in db.KhuyenMais
                                         where km.maKhuyenMai == maKM
                                         select km.phanTramKhuyenMai;
            return query.FirstOrDefault();
        }


        public int getMaxMaKhuyenMai()
        {
            System.Collections.Generic.List<string> maKhuyenMais = db.KhuyenMais
                .Select(km => km.maKhuyenMai)
                .ToList();
            int maxMakhuyenmai = maKhuyenMais
                .Where(kmai => !string.IsNullOrEmpty(kmai) && kmai.Length > 2)
                .Select(kmai => int.Parse(kmai.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();
            return maxMakhuyenmai;
        }
        public DataTable getKhuyenMai()
        {
            // Querying LoaiPhim using LINQ
            var query = from khuyenmai in db.KhuyenMais
                        select new
                        {
                            khuyenmai.maKhuyenMai,
                            khuyenmai.tenKM,
                            khuyenmai.thoiGianBD,
                            khuyenmai.thoiGianKT,
                            khuyenmai.phanTramKhuyenMai
                        };

            // Converting the LINQ query results to a DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maKhuyenMai");
            dt.Columns.Add("tenKM");
            dt.Columns.Add("thoiGianBD");
            dt.Columns.Add("thoiGianKT");
            dt.Columns.Add("phanTramKhuyenMai");

            foreach (var item in query)
            {
                dt.Rows.Add(item.maKhuyenMai, item.tenKM, item.thoiGianBD, item.thoiGianKT, item.phanTramKhuyenMai);
            }

            return dt;
        }

        public bool themKhuyenMai(KhuyenMaiDTO khuyenMai)
        {
            KhuyenMai newKhuyenMai = new KhuyenMai
            {
                maKhuyenMai = khuyenMai.MaKM,
                tenKM = khuyenMai.TenKM,
                thoiGianBD = khuyenMai.ThoiGianBD,
                thoiGianKT = khuyenMai.ThoiGianKT,
                phanTramKhuyenMai = khuyenMai.PhanTramKM,
                trangThai = khuyenMai.TrangThai
            };

            // Thêm nhân viên vào ngữ cảnh
            db.KhuyenMais.InsertOnSubmit(newKhuyenMai);

            try
            {
                db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                return true; // Trả về true nếu thành công
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có (ghi log, thông báo, v.v.)
                Console.WriteLine("Lỗi khi thêm khuyến mãi: " + ex.Message);
                return false; // Trả về false nếu có lỗi
            }
        }
        public bool xoaKhuyenMai(string maKhuyenMai)
        {
            try
            {
                // Tìm nhân viên trong cơ sở dữ liệu dựa trên mã 
                KhuyenMai km = db.KhuyenMais.SingleOrDefault(kmai => kmai.maKhuyenMai == maKhuyenMai);

                if (km != null)
                {

                    db.KhuyenMais.DeleteOnSubmit(km);
                    db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    return true; // Trả về true nếu xóa thành công
                }
                return false; // Trả về false nếu không tìm thấy 
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (ghi log, thông báo lỗi, v.v.)
                Console.WriteLine("Lỗi khi xóa khuyến mãi: " + ex.Message);
                return false;
            }
        }
    }
}
