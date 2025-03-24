using DTO;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DAL
{
    public class ExcelExport
    {
        private QL_RAPPHIMDataContext qlrapphim;
        private const string TMP_ROW = "TMP";

        public ExcelExport(QL_RAPPHIMDataContext context)
        {
            qlrapphim = context;
        }
        //public void ExportDoanhThu(List<DoanhThuDTO> doanhThuList, ref string fileName, bool isPrintPreview, string tenNV)
        //{
        //    // Kiểm tra danh sách doanhThuList có dữ liệu không
        //    if (doanhThuList == null || doanhThuList.Count == 0)
        //    {
        //        throw new InvalidOperationException("Danh sách doanh thu không có dữ liệu.");
        //    }

        //    // Lấy tháng và năm từ danh sách doanh thu (sử dụng tháng và năm của hóa đơn đầu tiên)
        //    int month = doanhThuList.FirstOrDefault()?.NgayBan?.Month ?? DateTime.Now.Month;
        //    int year = doanhThuList.FirstOrDefault()?.NgayBan?.Year ?? DateTime.Now.Year;
        //    string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template", "DoanhThu.xlsx");

        //    // Xây dựng dictionary để thay thế các từ khóa với dữ liệu thực tế
        //    Dictionary<string, string> replacer = new Dictionary<string, string>
        //    {
        //        { "%HoaDon.STT", doanhThuList.FirstOrDefault()?.STT.ToString() ?? "Không có thông tin" },
        //        { "%HoaDon.MAHOADON", doanhThuList.FirstOrDefault()?.MaHD ?? "Không có thông tin" },
        //        { "%HoaDon.NGAYBAN", doanhThuList.FirstOrDefault()?.NgayBan?.ToString("dd/MM/yyyy") ?? "Không có thông tin" },
        //        { "%HoaDon.TONGTIEN", doanhThuList.FirstOrDefault()?.TongTien?.ToString("0,0.00") ?? "Không có thông tin" },
        //        { "%HoaDon.MAKHUYENMAI", doanhThuList.FirstOrDefault()?.MaKM?? "Không có thông tin" },
        //        { "%THANG", month.ToString() },
        //        { "%NAM", year.ToString() },
        //        { "%TENNHANVIEN", tenNV }
        //    };

        //    // Tải file mẫu từ đường dẫn
        //    using (MemoryStream stream = LoadTemplate(relativePath))
        //    {
        //        if (stream != null)
        //        {
        //            // Khởi tạo Excel Engine và mở workbook
        //            using (ExcelEngine engine = new ExcelEngine())
        //            {
        //                IWorkbook workBook = engine.Excel.Workbooks.Open(stream);
        //                IWorksheet workSheet = workBook.Worksheets[0];

        //                // Áp dụng các giá trị thay thế vào worksheet
        //                foreach (KeyValuePair<string, string> repl in replacer)
        //                {
        //                    string key = repl.Key ?? "";
        //                    string value = repl.Value ?? "";
        //                    Replace(workSheet, key, value);
        //                }

        //                int startRow = 9; // Dòng bắt đầu ghi dữ liệu hóa đơn
        //                int colSTT = 1, colMaHD = 2, colNgayBan = 3, colTongTien = 4, colMaKhuyenMai = 5;

        //                // Số dòng cần chèn thêm (bằng số hóa đơn)
        //                int rowsToAdd = doanhThuList.Count;

        //                // Dòng bắt đầu có nội dung cố định cần dịch chuyển (ví dụ: dòng 26)
        //                int fixedContentStartRow = 26;

        //                // Chèn thêm dòng trống TRƯỚC dòng có nội dung cố định
        //                workSheet.InsertRow(fixedContentStartRow, rowsToAdd);

        //                foreach (DoanhThuDTO item in doanhThuList)
        //                {
        //                    workSheet[startRow, colSTT].Text = item.STT.ToString();
        //                    workSheet[startRow, colMaHD].Text = item.MaHD;
        //                    workSheet[startRow, colNgayBan].Text = item.NgayBan?.ToString("dd/MM/yyyy") ?? "";
        //                    workSheet[startRow, colTongTien].Text = item.TongTien?.ToString("0,0.00");
        //                    workSheet[startRow, colMaKhuyenMai].Text = item.MaKM;
        //                    startRow++;
        //                }

        //                // Dòng để ghi tổng tiền (sau dòng cuối cùng của dữ liệu hóa đơn)
        //                int totalRow = startRow + 1;

        //                // Dòng mới của nội dung cố định sau khi đã dịch chuyển
        //                int newFixedContentStartRow = fixedContentStartRow;

        //                // Ghi tổng tiền
        //                workSheet[totalRow, 5].Text = $"Tổng tiền: {doanhThuList.Sum(d => d.TongTien)?.ToString("0,0.00")}";

        //                // Di chuyển nộ dung "Người lập" từ dòng cũ (A26) xuống dòng mới
        //                workSheet.Range["A26"].MoveTo(workSheet.Range[newFixedContentStartRow, 1]);

        //                // Di chuyển nội dung "Ký tên" từ dòng cũ (A27) xuống dòng mới
        //                workSheet.Range["A27"].MoveTo(workSheet.Range[newFixedContentStartRow + 1, 1]);


        //                // Lưu file Excel
        //                string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template", $"DoanhThuRapPhim_export_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx");
        //                workBook.SaveAs(outputPath);
        //                fileName = outputPath;

        //                // Mở file Excel nếu yêu cầu
        //                if (isPrintPreview)
        //                {
        //                    System.Diagnostics.Process.Start(outputPath);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            throw new FileNotFoundException("Không tìm thấy file mẫu Excel.");
        //        }
        //    }
        //}


        public void ExportDoanhThu(List<DoanhThuDTO> doanhThuList, ref string fileName, bool isPrintPreview, string tenNV)
        {
            // Kiểm tra danh sách doanhThuList có dữ liệu không
            if (doanhThuList == null || doanhThuList.Count == 0)
            {
                throw new InvalidOperationException("Danh sách doanh thu không có dữ liệu.");
            }

            // Lấy tháng và năm từ danh sách doanh thu (sử dụng tháng và năm của hóa đơn đầu tiên)
            int month = doanhThuList.FirstOrDefault()?.NgayBan?.Month ?? DateTime.Now.Month;
            int year = doanhThuList.FirstOrDefault()?.NgayBan?.Year ?? DateTime.Now.Year;
            string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template", "DoanhThu.xlsx");

            // Xây dựng dictionary để thay thế các từ khóa với dữ liệu thực tế
            Dictionary<string, string> replacer = new Dictionary<string, string>
    {
        { "%HoaDon.STT", doanhThuList.FirstOrDefault()?.STT.ToString() ?? "Không có thông tin" },
        { "%HoaDon.MAHOADON", doanhThuList.FirstOrDefault()?.MaHD ?? "Không có thông tin" },
        { "%HoaDon.NGAYBAN", doanhThuList.FirstOrDefault()?.NgayBan?.ToString("dd/MM/yyyy") ?? "Không có thông tin" },
        { "%HoaDon.TONGTIEN", doanhThuList.FirstOrDefault()?.TongTien?.ToString("#,##0 VND") ?? "Không có thông tin" },
        { "%HoaDon.MAKHUYENMAI", doanhThuList.FirstOrDefault()?.MaKM?? "Không có thông tin" },
        { "%THANG", month.ToString() },
        { "%NAM", year.ToString() },
        { "%TENNHANVIEN", tenNV }
    };

            // Tải file mẫu từ đường dẫn
            using (MemoryStream stream = LoadTemplate(relativePath))
            {
                if (stream != null)
                {
                    // Khởi tạo Excel Engine và mở workbook
                    using (ExcelEngine engine = new ExcelEngine())
                    {
                        IWorkbook workBook = engine.Excel.Workbooks.Open(stream);
                        IWorksheet workSheet = workBook.Worksheets[0];

                        // Áp dụng các giá trị thay thế vào worksheet
                        foreach (KeyValuePair<string, string> repl in replacer)
                        {
                            string key = repl.Key ?? "";
                            string value = repl.Value ?? "";
                            Replace(workSheet, key, value);
                        }

                        int startRow = 9; // Dòng bắt đầu ghi dữ liệu hóa đơn
                        int colSTT = 1, colMaHD = 2, colNgayBan = 3, colTongTien = 4, colMaKhuyenMai = 5;

                        // Số dòng cần chèn thêm (bằng số hóa đơn)
                        int rowsToAdd = doanhThuList.Count;

                        // Dòng bắt đầu có nội dung cố định cần dịch chuyển (ví dụ: dòng 26)
                        int fixedContentStartRow = 26;

                        foreach (DoanhThuDTO item in doanhThuList)
                        {
                            workSheet[startRow, colSTT].Text = item.STT.ToString();
                            workSheet[startRow, colMaHD].Text = item.MaHD;
                            workSheet[startRow, colNgayBan].Text = item.NgayBan?.ToString("dd/MM/yyyy") ?? "";
                            workSheet[startRow, colTongTien].Number = item.TongTien.HasValue ? Convert.ToDouble(item.TongTien.Value) : 0;
                            workSheet[startRow, colTongTien].NumberFormat = "#,##0₫";
                            workSheet[startRow, colMaKhuyenMai].Text = item.MaKM;
                            startRow++;
                        }

                        // Dòng để ghi tổng tiền (sau dòng cuối cùng của dữ liệu hóa đơn)
                        int totalRow = startRow + 1;

                        double totalTien = Convert.ToDouble(doanhThuList.Sum(d => d.TongTien.HasValue ? d.TongTien.Value : 0));
                        workSheet[totalRow, 5].Number = totalTien;
                        workSheet[totalRow, 5].NumberFormat = "#,##0₫";
                        workSheet[totalRow, 5].Text = $"Tổng tiền: {totalTien.ToString("#,##0₫")}";

                        // Ghi nội dung "Người lập", "Ký tên", và "Tên nhân viên" dưới dòng tổng tiền
                        int nguoiLapRow = totalRow + 2; // Cách dòng trống

                        // Ghi nội dung "Người lập"
                        workSheet[nguoiLapRow, 1].Text = "Người lập";
                        workSheet[nguoiLapRow + 1, 1].Text = tenNV;

                        // Ghi nội dung "Ký tên"
                        workSheet[nguoiLapRow, 3].Text = "Ký tên";

                        // Lưu file Excel
                        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template", $"DoanhThuRapPhim_export_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx");
                        workBook.SaveAs(outputPath);
                        fileName = outputPath;

                        // Mở file Excel nếu yêu cầu
                        if (isPrintPreview)
                        {
                            System.Diagnostics.Process.Start(outputPath);
                        }
                    }
                }
                else
                {
                    throw new FileNotFoundException("Không tìm thấy file mẫu Excel.");
                }
            }
        }


        private MemoryStream LoadTemplate(string filePath)
        {
            try
            {
                byte[] templateBytes = File.ReadAllBytes(filePath);
                return new MemoryStream(templateBytes);
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException($"Không thể tải template: {ex.Message}");
            }
        }

        private void Replace(IWorksheet worksheet, string key, string value)
        {
            // Thay thế từ khóa trong toàn bộ worksheet
            worksheet.Replace(key, value);
        }
    }
}
