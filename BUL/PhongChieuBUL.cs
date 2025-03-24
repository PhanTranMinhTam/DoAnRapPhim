using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class PhongChieuBUL
    {
        PhongChieuDAL phongChieuDAL;

        public PhongChieuBUL()
        {
            phongChieuDAL = new PhongChieuDAL();
        }

        public List<PhongChieuDTO> getPhongChieu()
        {
            List<PhongChieuDTO> list = new List<PhongChieuDTO>();

            DataTable dt = phongChieuDAL.getPhongChieu();
            foreach (DataRow dr in dt.Rows)
            {
                PhongChieuDTO phongChieu = new PhongChieuDTO();
                phongChieu.MaPhongChieu = dr["maPhongChieu"].ToString();
                phongChieu.TenPhongChieu = dr["tenPhongChieu"].ToString();
                phongChieu.SoLuongGhe = Convert.ToInt32(dr["soLuongGhe"]);
                list.Add(phongChieu);
            }
            return list;
        }
        public DataTable LayTatCaPhongChieu()
        {
            return phongChieuDAL.LayTatCaPhongChieu();
        }
        public string layMaTuDong()
        {
            return phongChieuDAL.layMaTuDong(); // Gọi phương thức từ DAL để lấy mã tự động
        }

        public bool ThemPhongChieu(string tenPhongChieu, int soLuongGhe)
        {
            string maPhongChieu = phongChieuDAL.layMaTuDong(); // Lấy mã khách hàng tự động
            PhongChieuDTO PhongChieuMoi = new PhongChieuDTO(maPhongChieu, tenPhongChieu, soLuongGhe);
            return phongChieuDAL.ThemPhongChieu(PhongChieuMoi);
        }
        public bool SuaPhongChieu(PhongChieuDTO PhongChieu)
        {
            // Kiểm tra mã khách hàng có tồn tại không
            if (!phongChieuDAL.CheckMaPhongChieu(PhongChieu.MaPhongChieu))
            {
                throw new Exception("Mã phòng chiếu không tồn tại");
            }
            return phongChieuDAL.SuaPhongChieu(PhongChieu);
        }
        public bool XoaPhongChieu(string maPhongChieu)
        {
            return phongChieuDAL.XoaPhongChieu(maPhongChieu);
        }

        // Phương thức lấy danh sách phòng chiếu theo gioBD và gioKT
        //public List<string> GetPhongChieuByThoiGian(TimeSpan gioBD, TimeSpan gioKT)
        //{
        //    return phongChieuDAL.GetPhongChieuByThoiGian(gioBD, gioKT);
        //}

        public List<PhongChieuDTO> GetPhongChieuByThoiGian(TimeSpan gioBD, TimeSpan gioKT)
        {
            return phongChieuDAL.GetPhongChieuByThoiGian(gioBD, gioKT);
        }

        public List<PhongChieuDTO> layDSPhongChieu(string maPhim, string maLichChieu)
        {
            return phongChieuDAL.layDanhSachPhongChieu(maPhim, maLichChieu);
        }

    }
}
