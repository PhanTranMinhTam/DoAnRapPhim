using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace DAL
{
    public class PhimDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();
        public PhimDAL()
        {
            strConn = Settings.Default.strConn;
        }
        public DataTable getPhim()
        {
            var query = from p in db.Phims
                        join pl in db.Phim_LoaiPhims on p.maPhim equals pl.maPhim
                        join lp in db.LoaiPhims on pl.maLoai equals lp.maLoai
                        select new
                        {
                            p.maPhim,
                            p.tenPhim,
                            lp.tenLoai,
                            p.thoiLuong,
                            p.daoDien,
                            p.quocGia,
                            p.noiDung,
                            p.hinhAnh,
                            p.ngayChieu,
                            p.ngayKT,
                            p.trangThai
                        };
            // Tạo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maPhim");
            dt.Columns.Add("tenPhim");
            dt.Columns.Add("tenLoai");
            dt.Columns.Add("thoiLuong");
            dt.Columns.Add("daoDien");
            dt.Columns.Add("quocGia");
            dt.Columns.Add("noiDung");
            dt.Columns.Add("hinhAnh");
            dt.Columns.Add("ngayChieu");
            dt.Columns.Add("ngayKT");
            dt.Columns.Add("trangThai");

            // Duyệt qua kết quả và thêm vào DataTable
            foreach (var item in query.ToList())
            {
                dt.Rows.Add(item.maPhim, item.tenPhim, item.tenLoai, item.thoiLuong, item.daoDien, item.quocGia,
                            item.noiDung, item.hinhAnh, item.ngayChieu, item.ngayKT, item.trangThai);
            }

            return dt;
        }
        // Trong lớp phimDAL
        public DataTable getLoaiPhim()
        {
            var query = from lp in db.LoaiPhims
                        select new
                        {
                            lp.maLoai,
                            lp.tenLoai
                        };

            // Tạo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maLoai");
            dt.Columns.Add("tenLoai");

            // Duyệt qua kết quả và thêm vào DataTable
            foreach (var item in query.ToList())
            {
                dt.Rows.Add(item.maLoai, item.tenLoai);
            }

            return dt;
        }
        public DataTable getPhimByLoai(string maLoai)
        {
            var query = from p in db.Phims
                        join pl in db.Phim_LoaiPhims on p.maPhim equals pl.maPhim
                        join lp in db.LoaiPhims on pl.maLoai equals lp.maLoai
                        where pl.maLoai == maLoai
                        select new
                        {
                            p.maPhim,
                            p.tenPhim,
                            lp.tenLoai,
                            p.thoiLuong,
                            p.daoDien,
                            p.quocGia,
                            p.noiDung,
                            p.hinhAnh,
                            p.ngayChieu,
                            p.ngayKT,
                            p.trangThai
                        };

            // Tạo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maPhim");
            dt.Columns.Add("tenPhim");
            dt.Columns.Add("tenLoai");
            dt.Columns.Add("thoiLuong");
            dt.Columns.Add("daoDien");
            dt.Columns.Add("quocGia");
            dt.Columns.Add("noiDung");
            dt.Columns.Add("hinhAnh");
            dt.Columns.Add("ngayChieu");
            dt.Columns.Add("ngayKT");
            dt.Columns.Add("trangThai");

            // Duyệt qua kết quả và thêm vào DataTable
            foreach (var item in query.ToList())
            {
                dt.Rows.Add(item.maPhim, item.tenPhim, item.tenLoai, item.thoiLuong, item.daoDien, item.quocGia,
                            item.noiDung, item.hinhAnh, item.ngayChieu, item.ngayKT, item.trangThai);
            }

            return dt;
        }

        public DataTable getPhimByMaPhim(string maPhim)
        {
            var query = from p in db.Phims
                        join pl in db.Phim_LoaiPhims on p.maPhim equals pl.maPhim
                        join lp in db.LoaiPhims on pl.maLoai equals lp.maLoai
                        where p.maPhim == maPhim
                        select new
                        {
                            p.maPhim,
                            p.tenPhim,
                            lp.tenLoai,
                            p.thoiLuong,
                            p.daoDien,
                            p.quocGia,
                            p.noiDung,
                            p.hinhAnh,
                            p.ngayChieu,
                            p.ngayKT,
                            p.trangThai
                        };

            // Tạo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maPhim");
            dt.Columns.Add("tenPhim");
            dt.Columns.Add("tenLoai");
            dt.Columns.Add("thoiLuong");
            dt.Columns.Add("daoDien");
            dt.Columns.Add("quocGia");
            dt.Columns.Add("noiDung");
            dt.Columns.Add("hinhAnh");
            dt.Columns.Add("ngayChieu");
            dt.Columns.Add("ngayKT");
            dt.Columns.Add("trangThai");

            // Duyệt qua kết quả và thêm vào DataTable
            foreach (var item in query.ToList())
            {
                dt.Rows.Add(item.maPhim, item.tenPhim, item.tenLoai, item.thoiLuong, item.daoDien, item.quocGia,
                            item.noiDung, item.hinhAnh, item.ngayChieu, item.ngayKT, item.trangThai);
            }

            return dt;
        }

        public bool insertPhim(PhimDTO phim)
        {
            // Chuyển đổi từ PhimDTO sang Phim (entity)
            Phim newPhim = new Phim
            {
                maPhim = phim.MaPhim,
                tenPhim = phim.TenPhim,
                thoiLuong = phim.ThoiLuong,
                daoDien = phim.DaoDien,
                quocGia = phim.QuocGia,
                noiDung = phim.NoiDung,
                hinhAnh = phim.HinhAnh,
                ngayChieu = phim.NgayChieu,
                ngayKT = phim.NgayKT,
                trangThai = phim.TrangThai
            };

            // Thêm phim vào ngữ cảnh
            db.Phims.InsertOnSubmit(newPhim);

            try
            {
                // Lưu thay đổi cho bảng Phim
                db.SubmitChanges();

                // Thêm vào bảng Phim_LoaiPhim
                if (!string.IsNullOrEmpty(phim.MaLoaiPhim)) // Kiểm tra nếu maLoaiPhim không rỗng
                {
                    Phim_LoaiPhim phimLoaiPhim = new Phim_LoaiPhim
                    {
                        maPhim = newPhim.maPhim, // Lấy maPhim vừa thêm
                        maLoai = phim.MaLoaiPhim // Sử dụng mã loại phim từ DTO
                    };
                    db.Phim_LoaiPhims.InsertOnSubmit(phimLoaiPhim);
                    db.SubmitChanges(); // Lưu thay đổi cho bảng Phim_LoaiPhim
                }

                return true; // Trả về true nếu thành công
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có (ghi log, thông báo, v.v.)
                Console.WriteLine("Lỗi khi thêm phim: " + ex.Message);
                return false; // Trả về false nếu có lỗi
            }
        }
        public int getMaxMaPhim()
        {
            List<string> maPhims = db.Phims
                .Select(nv => nv.maPhim)
                .ToList();
            int maxMaPhim = maPhims
                .Where(mp => !string.IsNullOrEmpty(mp) && mp.Length > 2)
                .Select(mp => int.Parse(mp.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();
            return maxMaPhim;
        }
        public bool UpdatePhim(PhimDTO phim)
        {
            try
            {
                // Tìm phim trong cơ sở dữ liệu theo mã phim
                Phim existingPhim = db.Phims.SingleOrDefault(p => p.maPhim == phim.MaPhim);

                if (existingPhim == null)
                {
                    Console.WriteLine("Phim không tồn tại.");
                    return false; // Trả về false nếu không tìm thấy phim
                }

                // Cập nhật thông tin của phim
                existingPhim.tenPhim = phim.TenPhim;
                existingPhim.thoiLuong = phim.ThoiLuong;
                existingPhim.daoDien = phim.DaoDien;
                existingPhim.quocGia = phim.QuocGia;
                existingPhim.noiDung = phim.NoiDung;
                existingPhim.hinhAnh = phim.HinhAnh;
                existingPhim.ngayChieu = phim.NgayChieu;
                existingPhim.ngayKT = phim.NgayKT;
                existingPhim.trangThai = phim.TrangThai;

                db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                return true; // Trả về true nếu thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật phim: " + ex.Message);
                return false; // Trả về false nếu có lỗi
            }
        }
        public bool XoaPhim(string maphim)
        {
            try
            {
                // Tìm phim theo mã phim
                Phim phim = db.Phims.SingleOrDefault(p => p.maPhim == maphim);

                if (phim != null)
                {
                    // Xóa các mối quan hệ trong bảng Phim_Loai_Phim trước
                    IQueryable<Phim_LoaiPhim> phimLoaiPhim = db.Phim_LoaiPhims.Where(pl => pl.maPhim == maphim);
                    db.Phim_LoaiPhims.DeleteAllOnSubmit(phimLoaiPhim);

                    // Sau đó xóa phim khỏi bảng Phim
                    db.Phims.DeleteOnSubmit(phim);
                    db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    return true; // Trả về true nếu xóa thành công
                }

                return false; // Trả về false nếu không tìm thấy phim
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (ghi log, thông báo lỗi, v.v.)
                Console.WriteLine("Lỗi khi xóa phim: " + ex.Message);
                return false;
            }
        }

        public List<PhimDTO> getLoaiPhimCombo()
        {
            List<PhimDTO> dsLoaiPhim = (from lp in db.LoaiPhims
                                        select new PhimDTO
                                        {
                                            MaLoaiPhim = lp.maLoai,
                                            TenLoaiPhim = lp.tenLoai
                                        }).ToList();

            return dsLoaiPhim;
        }
        public DataTable layTatCaPhim()
        {
            var query = from p in db.Phims
                        join pl in db.Phim_LoaiPhims on p.maPhim equals pl.maPhim
                        join lp in db.LoaiPhims on pl.maLoai equals lp.maLoai
                        select new
                        {
                            p.maPhim,
                            p.tenPhim,
                            lp.tenLoai,
                            p.thoiLuong,
                            p.daoDien,
                            p.quocGia,
                            p.noiDung,
                            p.hinhAnh,
                            p.ngayChieu,
                            p.ngayKT,
                            p.trangThai
                        };

            // Tạo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("maPhim");
            dt.Columns.Add("tenPhim");
            dt.Columns.Add("tenLoai");
            dt.Columns.Add("thoiLuong");
            dt.Columns.Add("daoDien");
            dt.Columns.Add("quocGia");
            dt.Columns.Add("noiDung");
            dt.Columns.Add("hinhAnh");
            dt.Columns.Add("ngayChieu");
            dt.Columns.Add("ngayKT");
            dt.Columns.Add("trangThai");

            // Duyệt qua kết quả và thêm vào DataTable
            foreach (var item in query.ToList())
            {
                dt.Rows.Add(item.maPhim, item.tenPhim, item.tenLoai, item.thoiLuong, item.daoDien, item.quocGia,
                            item.noiDung, item.hinhAnh, item.ngayChieu, item.ngayKT, item.trangThai);
            }

            return dt;
        }

    }
}
