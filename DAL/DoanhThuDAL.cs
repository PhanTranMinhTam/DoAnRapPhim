using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DoanhThuDAL
    {
        private QL_RAPPHIMDataContext _context;

        public DoanhThuDAL(QL_RAPPHIMDataContext context)
        {
            _context = context;
        }

        public List<HoaDoninfoDTO> GetHoaDonByMonth(int month, int year)
        {
            IQueryable<HoaDoninfoDTO> query = from hd in _context.HoaDons
                                              where hd.ngayBan.HasValue
                                              && hd.ngayBan.Value.Month == month
                                              && hd.ngayBan.Value.Year == year
                                              select new HoaDoninfoDTO
                                              {
                                                  MaHD = hd.maHD,
                                                  NgayBan = hd.ngayBan,
                                                  TongTien = hd.tongTien,
                                                  MaKM = hd.maKhuyenMai,
                                              };


            return query.ToList() ?? new List<HoaDoninfoDTO>();
        }

    }
}
