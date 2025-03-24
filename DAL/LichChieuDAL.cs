using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace DAL
{
    public class LichChieuDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();

        public LichChieuDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public DataTable getLichChieu()
        {
            var query = from lichChieu in db.LichChieus
                        join phim in db.Phims on lichChieu.maPhim equals phim.maPhim
                        join phongChieu in db.PhongChieus on lichChieu.maPhongChieu equals phongChieu.maPhongChieu
                        select new
                        {
                            lichChieu.maLichChieu,
                            phim.tenPhim,
                            phongChieu.tenPhongChieu,
                            lichChieu.ngayChieu,
                            lichChieu.gioBD,
                            lichChieu.gioKT
                        };

            // Chuyển đổi kết quả truy vấn LINQ thành DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("MaLichChieu");
            dt.Columns.Add("TenPhim");
            dt.Columns.Add("TenPhongChieu");
            dt.Columns.Add("NgayChieu");
            dt.Columns.Add("GioBD");
            dt.Columns.Add("GioKT");

            foreach (var item in query)
            {
                // Kiểm tra ngayChieu có giá trị null hay không
                string ngayChieuFormatted = item.ngayChieu.HasValue
                    ? item.ngayChieu.Value.ToString("dd/MM/yyyy")
                    : string.Empty; // Nếu null, trả về chuỗi rỗng

                dt.Rows.Add(item.maLichChieu, item.tenPhim, item.tenPhongChieu,
                            ngayChieuFormatted, // Định dạng lại ngayChieu
                            item.gioBD,
                            item.gioKT);
            }

            return dt;
        }

        //lấy danh sách lịch chiếu gồm giờ bắt đầu, giờ kết thúc theo mã phim
        public DataTable getLichChieuByMaPhim(string maPhim)
        {
            var query = from lichChieu in db.LichChieus
                        join phim in db.Phims on lichChieu.maPhim equals phim.maPhim
                        join phongChieu in db.PhongChieus on lichChieu.maPhongChieu equals phongChieu.maPhongChieu
                        where lichChieu.maPhim == maPhim
                        select new
                        {
                            lichChieu.maLichChieu,
                            phim.tenPhim,
                            phongChieu.tenPhongChieu,
                            lichChieu.ngayChieu,
                            lichChieu.gioBD,
                            lichChieu.gioKT
                        };

            // Chuyển đổi kết quả truy vấn LINQ thành DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("MaLichChieu");
            dt.Columns.Add("TenPhim");
            dt.Columns.Add("TenPhongChieu");
            dt.Columns.Add("NgayChieu");
            dt.Columns.Add("GioBD");
            dt.Columns.Add("GioKT");

            foreach (var item in query)
            {
                // Kiểm tra ngayChieu có giá trị null hay không
                string ngayChieuFormatted = item.ngayChieu.HasValue
                    ? item.ngayChieu.Value.ToString("dd/MM/yyyy")
                    : string.Empty; // Nếu null, trả về chuỗi rỗng

                dt.Rows.Add(item.maLichChieu, item.tenPhim, item.tenPhongChieu,
                            ngayChieuFormatted, // Định dạng lại ngayChieu
                            item.gioBD,
                            item.gioKT);
            }

            return dt;
        }
        public string layMaLichChieu()
        {
            SqlConnection conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "select top 1 maLichChieu from LichChieu order by maLichChieu desc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            if (dt.Rows.Count == 0)
                return "LC001";
            string ma = dt.Rows[0][0].ToString();
            int so = int.Parse(ma.Substring(2)) + 1;
            if (so < 10)
                return "LC00" + so;
            if (so < 100)
                return "LC0" + so;
            return "LC" + so;
        }

        //public bool themLichChieu(LichChieuDTO lichChieu)
        //{
        //    try
        //    {
        //        // Tạo đối tượng LichChieu mới từ DTO
        //        LichChieu newLichChieu = new LichChieu
        //        {
        //            maLichChieu = lichChieu.MaLichChieu,
        //            maPhim = lichChieu.MaPhim,
        //            maPhongChieu = lichChieu.MaPhongChieu,
        //            ngayChieu = lichChieu.NgayChieu,
        //            gioBD = lichChieu.GioBatDau,
        //            gioKT = lichChieu.GioKetThuc
        //        };

        //        // Thêm đối tượng LichChieu vào bảng
        //        db.LichChieus.InsertOnSubmit(newLichChieu);

        //        // Lưu thay đổi vào cơ sở dữ liệu
        //        db.SubmitChanges();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý lỗi nếu có
        //        Console.WriteLine(ex.Message);
        //        return false;
        //    }
        //}

        public bool themLichChieu(LichChieuDTO lichChieu, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                // Check for overlapping schedules in the same room
                IQueryable<LichChieu> overlappingSchedules = from lc in db.LichChieus
                                                             where lc.maPhongChieu == lichChieu.MaPhongChieu
                                                             && lc.ngayChieu == lichChieu.NgayChieu
                                                             && ((lc.gioBD < lichChieu.GioKetThuc && lc.gioKT > lichChieu.GioBatDau)
                                                                 || (lc.gioBD < lichChieu.GioBatDau && lc.gioKT > lichChieu.GioBatDau)
                                                                 || (lc.gioBD < lichChieu.GioKetThuc && lc.gioKT > lichChieu.GioKetThuc))
                                                             select lc;

                if (overlappingSchedules.Any())
                {
                    errorMessage = "Lịch chiếu bị trùng thời gian với lịch chiếu khác trong cùng phòng.";
                    return false;
                }

                // Create a new LichChieu object from the DTO
                LichChieu newLichChieu = new LichChieu
                {
                    maLichChieu = lichChieu.MaLichChieu,
                    maPhim = lichChieu.MaPhim,
                    maPhongChieu = lichChieu.MaPhongChieu,
                    ngayChieu = lichChieu.NgayChieu,
                    gioBD = lichChieu.GioBatDau,
                    gioKT = lichChieu.GioKetThuc
                };

                // Add the LichChieu object to the table
                db.LichChieus.InsertOnSubmit(newLichChieu);

                // Save changes to the database
                db.SubmitChanges();

                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                {
                    errorMessage = "Ngày chiếu của lịch chiếu phải nằm trong khoảng ngày khởi chiếu và ngày kết thúc của phim.";
                }
                else
                {
                    errorMessage = $"Database error: {ex.Message}";
                }
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = $"Unexpected error: {ex.Message}";
                return false;
            }
        }


        public bool suaLichChieu(LichChieuDTO lichChieu, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                // Find the LichChieu record to update by its ID
                LichChieu updateLichChieu = db.LichChieus.SingleOrDefault(lc => lc.maLichChieu == lichChieu.MaLichChieu);

                if (updateLichChieu != null)
                {
                    // Check for overlapping schedules in the same room, excluding the current schedule being updated
                    IQueryable<LichChieu> overlappingSchedules = from lc in db.LichChieus
                                                                 where lc.maPhongChieu == lichChieu.MaPhongChieu
                                                                 && lc.ngayChieu == lichChieu.NgayChieu
                                                                 && lc.maLichChieu != lichChieu.MaLichChieu
                                                                 && ((lc.gioBD < lichChieu.GioKetThuc && lc.gioKT > lichChieu.GioBatDau)
                                                                     || (lc.gioBD < lichChieu.GioBatDau && lc.gioKT > lichChieu.GioBatDau)
                                                                     || (lc.gioBD < lichChieu.GioKetThuc && lc.gioKT > lichChieu.GioKetThuc))
                                                                 select lc;

                    if (overlappingSchedules.Any())
                    {
                        errorMessage = "Lịch chiếu bị trùng thời gian với lịch chiếu khác trong cùng phòng.";
                        return false;
                    }

                    // Update the record with new data
                    updateLichChieu.maPhim = lichChieu.MaPhim;
                    updateLichChieu.maPhongChieu = lichChieu.MaPhongChieu;
                    updateLichChieu.ngayChieu = lichChieu.NgayChieu;
                    updateLichChieu.gioBD = lichChieu.GioBatDau;
                    updateLichChieu.gioKT = lichChieu.GioKetThuc;

                    // Save changes to the database
                    db.SubmitChanges();

                    return true;
                }
                else
                {
                    errorMessage = "Lịch chiếu không tồn tại.";
                    return false;
                }
            }
            catch (SqlException ex)
            {
                // Handle trigger error raised via RAISERROR (custom error number)
                if (ex.Number == 50000) // Custom error raised by the trigger
                {
                    errorMessage = "Ngày chiếu của lịch chiếu phải nằm trong khoảng ngày khởi chiếu và ngày kết thúc của phim.";
                }
                else
                {
                    errorMessage = $"Database error: {ex.Message}";
                }
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = $"Unexpected error: {ex.Message}";
                return false;
            }
        }



        public bool xoaLichChieu(string maLichChieu)
        {
            try
            {
                // Tìm LichChieu cần xóa theo mã
                LichChieu deleteLichChieu = db.LichChieus.SingleOrDefault(lc => lc.maLichChieu == maLichChieu);

                // Xóa LichChieu khỏi bảng
                db.LichChieus.DeleteOnSubmit(deleteLichChieu);

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public LichChieuDetailDTO layThongTinLichChieuTheoMa(string maLichChieu)
        {
            IQueryable<LichChieuDetailDTO> query = from lichChieu in db.LichChieus
                                                   join phim in db.Phims on lichChieu.maPhim equals phim.maPhim
                                                   join phongChieu in db.PhongChieus on lichChieu.maPhongChieu equals phongChieu.maPhongChieu
                                                   where lichChieu.maLichChieu == maLichChieu
                                                   select new LichChieuDetailDTO
                                                   {
                                                       MaLichChieu = lichChieu.maLichChieu,
                                                       MaPhim = lichChieu.maPhim,
                                                       MaPhongChieu = lichChieu.maPhongChieu,
                                                       NgayChieu = lichChieu.ngayChieu,
                                                       GioBatDau = lichChieu.gioBD,
                                                       GioKetThuc = lichChieu.gioKT,
                                                       TenPhim = phim.tenPhim,
                                                       TenPhongChieu = phongChieu.tenPhongChieu
                                                   };

            return query.SingleOrDefault();
        }


        // Phương thức lấy thời gian chiếu theo mã phim
        public List<Tuple<TimeSpan, TimeSpan>> GetThoiGianChieuByMaPhim(string maPhim)
        {
            var query = from lc in db.LichChieus
                        where lc.maPhim == maPhim
                        select new
                        {
                            lc.gioBD,
                            lc.gioKT
                        };

            List<Tuple<TimeSpan, TimeSpan>> result = query.ToList()
                .Select(x => new Tuple<TimeSpan, TimeSpan>(
                    x.gioBD ?? TimeSpan.Zero,
                    x.gioKT ?? TimeSpan.Zero
                ))
                .Distinct()
                .ToList();

            return result;
        }

        //lấy danh sách lịch chiếu theo mã phim
        //public List<LichChieuDTO> layLichChieuByMaPhim(string maPhim)
        //{
        //    IQueryable<LichChieuDTO> query = from lichChieu in db.LichChieus
        //                                     where lichChieu.maPhim == maPhim
        //                                     select new LichChieuDTO
        //                                     {
        //                                         MaLichChieu = lichChieu.maLichChieu,
        //                                         MaPhim = lichChieu.maPhim,
        //                                         MaPhongChieu = lichChieu.maPhongChieu,
        //                                         NgayChieu = lichChieu.ngayChieu,
        //                                         GioBatDau = lichChieu.gioBD,
        //                                         GioKetThuc = lichChieu.gioKT
        //                                     };

        //    return query.ToList();
        //}

        //public List<LichChieuDTO> layLichChieuByMaPhim(string maPhim)
        //{
        //    IQueryable<LichChieuDTO> query = from lichChieu in db.LichChieus
        //                                     where lichChieu.maPhim == maPhim
        //                                     group lichChieu by new { lichChieu.ngayChieu, lichChieu.gioBD, lichChieu.gioKT } into g
        //                                     select new LichChieuDTO
        //                                     {
        //                                         NgayChieu = g.Key.ngayChieu,
        //                                         GioBatDau = g.Key.gioBD,
        //                                         GioKetThuc = g.Key.gioKT,
        //                                         PhongChieu = string.Join(", ", g.Select(x => x.maPhongChieu)),
        //                                         MaLichChieuAgg = string.Join(", ", g.Select(x => x.maLichChieu))
        //                                     };

        //    return query.ToList();
        //}

        public List<LichChieuDTO> layLichChieuByMaPhim(string maPhim)
        {
            var query = from lichChieu in db.LichChieus
                        where lichChieu.maPhim == maPhim
                        group lichChieu by new { lichChieu.ngayChieu, lichChieu.gioBD, lichChieu.gioKT } into g
                        select new
                        {
                            NgayChieu = g.Key.ngayChieu,
                            GioBatDau = g.Key.gioBD,
                            GioKetThuc = g.Key.gioKT,
                            PhongChieu = string.Join(", ", g.Select(x => x.maPhongChieu)),
                            MaLichChieuAgg = string.Join(", ", g.Select(x => x.maLichChieu)),
                            LichChieuGroup = g.ToList()
                        };

            var result = query.ToList();

            // Perform the dictionary creation in memory
            List<LichChieuDTO> lichChieuDTOList = result.Select(item => new LichChieuDTO
            {
                NgayChieu = item.NgayChieu,
                GioBatDau = item.GioBatDau,
                GioKetThuc = item.GioKetThuc,
                PhongChieu = item.PhongChieu,
                MaLichChieuAgg = item.MaLichChieuAgg,
                PhongChieuToMaLichChieu = item.LichChieuGroup.ToDictionary(x => x.maPhongChieu, x => x.maLichChieu)
            }).ToList();

            return lichChieuDTOList;
        }
    }
}
