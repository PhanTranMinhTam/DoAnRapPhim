using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class KhuyenMaiBUL
    {
        KhuyenMaiDAL kmDAL = new KhuyenMaiDAL();
        public DataTable layDSKhuyenMai()
        {
            return kmDAL.layDSKhuyenMai();
        }

        public int GetMaxMaKhuyenMai()
        {
            return kmDAL.getMaxMaKhuyenMai();
        }
        public bool ThemKhuyenMai(KhuyenMaiDTO khuyenMai)
        {
            return kmDAL.themKhuyenMai(khuyenMai);
        }
        public bool xoaKhuyenMai(string maKhuyenMai)
        {
            return kmDAL.xoaKhuyenMai(maKhuyenMai);
        }
        public List<KhuyenMaiDTO> GetKhuyenMai()
        {
            List<KhuyenMaiDTO> list = new List<KhuyenMaiDTO>();
            DataTable dt = kmDAL.getKhuyenMai();

            if (dt == null || dt.Rows.Count == 0)
            {
                return list; // Trả về danh sách rỗng nếu không có dữ liệu
            }

            foreach (DataRow dr in dt.Rows)
            {
                KhuyenMaiDTO khuyenmai = new KhuyenMaiDTO
                {
                    MaKM = dr["maKhuyenMai"]?.ToString() ?? string.Empty,
                    TenKM = dr["tenKM"]?.ToString() ?? string.Empty,
                    ThoiGianBD = dr["thoiGianBD"] != DBNull.Value
                        ? Convert.ToDateTime(dr["thoiGianBD"])
                        : (DateTime?)null,
                    ThoiGianKT = dr["thoiGianKT"] != DBNull.Value
                        ? Convert.ToDateTime(dr["thoiGianKT"])
                        : (DateTime?)null,
                    PhanTramKM = dr["phanTramKhuyenMai"] != DBNull.Value
                        ? Convert.ToDecimal(dr["phanTramKhuyenMai"])
                        : (decimal?)null,
                };

                list.Add(khuyenmai);
            }

            return list;
        }

        public decimal? layPhanTramKMTheoMaKM(string maKM)
        {
            return kmDAL.layPhanTramKMTheoMaKM(maKM);
        }
    }
}
