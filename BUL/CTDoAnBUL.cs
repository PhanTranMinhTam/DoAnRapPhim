using DAL;
using DTO;

namespace BUL
{
    public class CTDoAnBUL
    {
        CTDoAnDAL ctDoAnDAL = new CTDoAnDAL();

        public string taoMaHoaDon()
        {
            return ctDoAnDAL.taoMaHoaDon();
        }

        public bool themCTDoAn(CTDoAnDTO ct)
        {
            return ctDoAnDAL.themCTDoAn(ct);
        }
    }
}
