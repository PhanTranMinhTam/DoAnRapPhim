using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class DichVuDAL
    {
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();

        //Lấy danh sách dịch vụ có trạng thái 1
        public DataTable getDichVu()
        {
            var query = from dv in db.DoAns
                        where dv.trangThai == 1
                        select new
                        {
                            MaDoAn = dv.maDoAn,
                            TenDoAn = dv.tenDoAn,
                            DonGia = dv.donGia,
                            HinhAnh = dv.hinhAnh,
                            SoLuong = dv.soLuong,
                            TrangThai = dv.trangThai

                        };

            // Chuyển đổi kết quả truy vấn LINQ thành DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDoAn");
            dt.Columns.Add("TenDoAn");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("HinhAnh");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("TrangThai");

            foreach (var item in query)
            {
                dt.Rows.Add(item.MaDoAn, item.TenDoAn, item.DonGia, item.HinhAnh, item.SoLuong, item.TrangThai);
            }

            return dt;
        }

        public string taoMaDoAn()
        {
            string maDoAn = "DA";
            DoAn query = db.DoAns.OrderByDescending(x => x.maDoAn).FirstOrDefault();
            if (query != null)
            {
                int so = int.Parse(query.maDoAn.Substring(2)) + 1;
                if (so < 10)
                {
                    maDoAn += "00" + so;
                }
                else if (so < 100)
                {
                    maDoAn += "0" + so;
                }
                else
                {
                    maDoAn += so;
                }
            }
            else
            {
                maDoAn += "001";
            }
            return maDoAn;
        }



        //public bool themDichVu(DichVuDTO dv, out string errorMessage)
        //{
        //    errorMessage = null;

        //    try
        //    {

        //        DoAn doAn = new DoAn
        //        {
        //            maDoAn = dv.MaDoAn,
        //            tenDoAn = dv.TenDoAn,
        //            donGia = decimal.Parse(dv.DonGia.ToString()),
        //            hinhAnh = dv.HinhAnh,
        //            soLuong = dv.SoLuong,
        //            trangThai = dv.TrangThai
        //        };

        //        db.DoAns.InsertOnSubmit(doAn);
        //        db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
        //        errorMessage = string.Empty; // Không có lỗi
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        // Kiểm tra mã lỗi SQL
        //        if (ex.Number == 547) // Mã lỗi cho vi phạm ràng buộc CHECK
        //        {
        //            errorMessage = "Số lượng món không hợp lệ. Vui lòng kiểm tra lại.";
        //        }
        //        else
        //        {
        //            errorMessage = $"Lỗi cơ sở dữ liệu: {ex.Message}";
        //        }
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        errorMessage = $"Lỗi không xác định: {ex.Message}";
        //        return false;
        //    }
        //}


        public bool themDichVu(DichVuDTO dv, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                DoAn doAn = new DoAn
                {
                    maDoAn = dv.MaDoAn,
                    tenDoAn = dv.TenDoAn,
                    donGia = decimal.Parse(dv.DonGia.ToString()),
                    hinhAnh = dv.HinhAnh,
                    soLuong = dv.SoLuong,
                    trangThai = dv.TrangThai
                };

                db.DoAns.InsertOnSubmit(doAn);
                db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                errorMessage = string.Empty; // Không có lỗi
                return true;
            }
            catch (SqlException ex)
            {
                // Kiểm tra mã lỗi SQL
                if (ex.Number == 547) // Mã lỗi cho vi phạm ràng buộc CHECK
                {
                    errorMessage = "Số lượng món không hợp lệ. Vui lòng kiểm tra lại.";
                }
                else
                {
                    errorMessage = $"Lỗi cơ sở dữ liệu: {ex.Message}";
                }
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi không xác định: {ex.Message}";
                return false;
            }
        }




        //Xóa là update trạng thái thành 0

        public bool xoaDichVu(string maDoAn)
        {
            try
            {
                DoAn doAn = db.DoAns.Where(x => x.maDoAn == maDoAn).FirstOrDefault();
                doAn.trangThai = 0;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DichVuDTO layThongTinDVTheoMa(string maDoAn)
        {
            DoAn query = db.DoAns.Where(x => x.maDoAn == maDoAn).FirstOrDefault();
            DichVuDTO dv = new DichVuDTO();
            dv.MaDoAn = query.maDoAn;
            dv.TenDoAn = query.tenDoAn;
            dv.DonGia = double.Parse(query.donGia.ToString());
            dv.HinhAnh = query.hinhAnh;
            dv.SoLuong = query.soLuong;
            dv.TrangThai = query.trangThai;
            return dv;
        }

        public bool suaDichVu(DichVuDTO dv, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                // Tìm dịch vụ theo mã
                DoAn doAn = db.DoAns.SingleOrDefault(x => x.maDoAn == dv.MaDoAn);

                // Kiểm tra nếu không tìm thấy dịch vụ
                if (doAn == null)
                {
                    errorMessage = "Dịch vụ không tồn tại.";
                    return false;
                }

                // Cập nhật thông tin dịch vụ
                doAn.tenDoAn = dv.TenDoAn;
                doAn.donGia = decimal.Parse(dv.DonGia.ToString());
                doAn.hinhAnh = dv.HinhAnh;
                doAn.soLuong = dv.SoLuong; // Đảm bảo cập nhật cả số lượng nếu có
                doAn.trangThai = dv.TrangThai; // Cập nhật trạng thái nếu cần

                // Lưu thay đổi
                db.SubmitChanges();
                errorMessage = string.Empty; // Không có lỗi
                return true;
            }
            catch (SqlException sqlEx)
            {
                // Kiểm tra mã lỗi SQL
                //if (sqlEx.Number == 547) // Mã lỗi cho vi phạm ràng buộc CHECK hoặc FK
                //{
                //    errorMessage = "Số lượng món không hợp lệ hoặc vi phạm ràng buộc cơ sở dữ liệu.";
                //}
                //else 
                if (sqlEx.Message.Contains("CK_SoLuong_GT0")) // Ràng buộc cụ thể
                {
                    errorMessage = "Số lượng món phải lớn hơn 0.";
                }
                else
                {
                    errorMessage = $"Lỗi cơ sở dữ liệu: {sqlEx.Message}";
                }
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi không xác định: {ex.Message}";
                return false;
            }
        }



        public int laySoLuongMon(string maDoAn)
        {
            DoAn query = db.DoAns.Where(x => x.maDoAn == maDoAn).FirstOrDefault();
            return query.soLuong.Value;
        }

        //câp nhật số lượng món ăn
        public bool capNhatSoLuongMon(string maDoAn, int soLuong)
        {
            try
            {
                DoAn doAn = db.DoAns.Where(x => x.maDoAn == maDoAn).FirstOrDefault();
                doAn.soLuong = soLuong;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
