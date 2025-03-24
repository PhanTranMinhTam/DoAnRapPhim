using DAL;
using DTO;
using System.Collections.Generic;

namespace BUL
{
    public class DoanhThuBUL
    {
        private DoanhThuDAL _doanhThuDAL;

        public DoanhThuBUL(QL_RAPPHIMDataContext context)
        {
            _doanhThuDAL = new DoanhThuDAL(context);
        }

        public List<DoanhThuDTO> GetDoanhThuByMonth(int month, int year)
        {
            List<HoaDoninfoDTO> hoaDons = _doanhThuDAL.GetHoaDonByMonth(month, year);
            List<DoanhThuDTO> doanhThuDTOList = new List<DoanhThuDTO>();

            int stt = 1;
            foreach (HoaDoninfoDTO hoaDon in hoaDons)
            {
                DoanhThuDTO doanhThuDTO = new DoanhThuDTO(hoaDon, stt);
                doanhThuDTOList.Add(doanhThuDTO);
                stt++;
            }

            return doanhThuDTOList;
        }
    }
}
