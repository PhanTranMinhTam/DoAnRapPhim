using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class LoaiPhimBUL
    {
        LoaiPhimDAL loaiPhimDAL;
        public LoaiPhimBUL()
        {
            loaiPhimDAL = new LoaiPhimDAL();
        }
        public List<LoaiPhimDTO> getLoaiPhim()
        {
            List<LoaiPhimDTO> list = new List<LoaiPhimDTO>();

            DataTable dt = loaiPhimDAL.getLoaiPhim();
            foreach (DataRow dr in dt.Rows)
            {
                LoaiPhimDTO loaiphim = new LoaiPhimDTO(
                    dr["maLoai"].ToString(),
                    dr["tenLoai"].ToString(),
                    dr["moTa"].ToString()
                );
                list.Add(loaiphim);
            }
            return list;
        }
        public DataTable LayTatCaLoaiPhim()
        {
            return loaiPhimDAL.LayTatCaLoaiPhim();
        }
        public string layMaTuDong()
        {
            return loaiPhimDAL.layMaTuDong(); // Gọi phương thức từ DAL để lấy mã tự động
        }
        public bool ThemLoaiPhim(string TenLoai, string moTa)
        {
            string maLoai = loaiPhimDAL.layMaTuDong(); // Lấy mã khách hàng tự động
            LoaiPhimDTO LoaiPhimMoi = new LoaiPhimDTO(maLoai, TenLoai, moTa);
            return loaiPhimDAL.ThemLoaiPhim(LoaiPhimMoi);
        }
        public bool SuaLoaiPhim(LoaiPhimDTO LoaiPhim)
        {
            // Kiểm tra mã khách hàng có tồn tại không
            if (!loaiPhimDAL.CheckMaLoaiPhim(LoaiPhim.MaLoaiPhim))
            {
                throw new Exception("Mã loại phim không tồn tại");
            }
            return loaiPhimDAL.SuaLoaiPhim(LoaiPhim);
        }
        public bool XoaLoaiPhim(string MaLoai)
        {
            return loaiPhimDAL.XoaLoaiPhim(MaLoai);
        }
    }
}
