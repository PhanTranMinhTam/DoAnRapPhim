using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class PhimBUL
    {
        PhimDAL phimDAL;

        public PhimBUL()
        {
            phimDAL = new PhimDAL();
        }

        public List<PhimDTO> getPhim()
        {
            List<PhimDTO> list = new List<PhimDTO>();

            DataTable dt = phimDAL.getPhim();
            foreach (DataRow dr in dt.Rows)
            {
                PhimDTO phim = new PhimDTO
                {
                    MaPhim = dr["maPhim"].ToString(),
                    TenPhim = dr["tenPhim"].ToString(),
                    TenLoaiPhim = dr["tenLoai"].ToString(),
                    ThoiLuong = int.Parse(dr["thoiLuong"].ToString()),
                    DaoDien = dr["daoDien"].ToString(),
                    QuocGia = dr["quocGia"].ToString(),
                    NoiDung = dr["noiDung"].ToString(),
                    HinhAnh = dr["hinhAnh"].ToString(),
                    NgayChieu = DateTime.Parse(dr["ngayChieu"].ToString()),
                    NgayKT = DateTime.Parse(dr["ngayKT"].ToString()),
                    TrangThai = int.Parse(dr["trangThai"].ToString())
                };
                list.Add(phim);
            }
            return list;
        }
        public List<PhimDTO> getLoaiPhim()
        {
            List<PhimDTO> loaiPhimList = new List<PhimDTO>();
            DataTable dt = phimDAL.getLoaiPhim();

            foreach (DataRow dr in dt.Rows)
            {
                PhimDTO loaiPhim = new PhimDTO
                {
                    MaLoaiPhim = dr["maLoai"].ToString(),
                    TenLoaiPhim = dr["tenLoai"].ToString()
                };
                loaiPhimList.Add(loaiPhim);
            }

            return loaiPhimList;
        }
        public List<PhimDTO> getPhimByLoai(string maLoai)
        {
            // Giả sử phimDAL có phương thức getPhimByLoai
            DataTable dt = phimDAL.getPhimByLoai(maLoai);
            List<PhimDTO> list = new List<PhimDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                PhimDTO phim = new PhimDTO
                {
                    MaPhim = dr["maPhim"].ToString(),
                    TenPhim = dr["tenPhim"].ToString(),
                    TenLoaiPhim = dr["tenLoai"].ToString(),
                    ThoiLuong = int.Parse(dr["thoiLuong"].ToString()),
                    DaoDien = dr["daoDien"].ToString(),
                    QuocGia = dr["quocGia"].ToString(),
                    NoiDung = dr["noiDung"].ToString(),
                    HinhAnh = dr["hinhAnh"].ToString(),
                    NgayChieu = DateTime.Parse(dr["ngayChieu"].ToString()),
                    NgayKT = DateTime.Parse(dr["ngayKT"].ToString()),
                    TrangThai = int.Parse(dr["trangThai"].ToString())
                };
                list.Add(phim);
            }
            return list;
        }

        public PhimDTO getPhimByMaPhim(string maPhim)
        {
            DataTable dt = phimDAL.getPhimByMaPhim(maPhim);
            DataRow dr = dt.Rows[0];
            PhimDTO phim = new PhimDTO
            {
                MaPhim = dr["maPhim"].ToString(),
                TenPhim = dr["tenPhim"].ToString(),
                TenLoaiPhim = dr["tenLoai"].ToString(),
                ThoiLuong = int.Parse(dr["thoiLuong"].ToString()),
                DaoDien = dr["daoDien"].ToString(),
                QuocGia = dr["quocGia"].ToString(),
                NoiDung = dr["noiDung"].ToString(),
                HinhAnh = dr["hinhAnh"].ToString(),
                NgayChieu = DateTime.Parse(dr["ngayChieu"].ToString()),
                NgayKT = DateTime.Parse(dr["ngayKT"].ToString()),
                TrangThai = int.Parse(dr["trangThai"].ToString())
            };
            return phim;
        }

        public int GetMaxMaPhim()
        {
            return phimDAL.getMaxMaPhim();
        }

        public bool ThemPhim(PhimDTO phim)
        {
            return phimDAL.insertPhim(phim);
        }
        public bool SuaPhim(PhimDTO phim)
        {
            return phimDAL.UpdatePhim(phim);
        }
        public bool xoaPhim(string maPhim)
        {

            return phimDAL.XoaPhim(maPhim);
        }
        public List<PhimDTO> GetLoaiPhimCombo()
        {
            return phimDAL.getLoaiPhimCombo();
        }


        public DataTable LayTatCaPhim()
        {
            return phimDAL.layTatCaPhim();
        }




    }
}
