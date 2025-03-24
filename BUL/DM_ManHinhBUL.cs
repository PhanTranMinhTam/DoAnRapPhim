using DAL;
using DTO;
using System.Collections.Generic;

namespace BUL
{
    public class DM_ManHinhBUL
    {
        DM_ManHinhDAL dM_ManHinhDAL;
        public DM_ManHinhBUL()
        {
            dM_ManHinhDAL = new DM_ManHinhDAL();
        }

        public List<DM_ManHinhDTO> LoadManHinh()
        {
            return dM_ManHinhDAL.LoadManHinh();
        }

        public string taoMaManHinh()
        {
            return dM_ManHinhDAL.taoMaManHinh();
        }

        public bool themManHinh(DM_ManHinhDTO manHinh)
        {
            return dM_ManHinhDAL.themManHinh(manHinh);
        }

        public bool xoaManHinh(string maManHinh)
        {
            return dM_ManHinhDAL.xoaManHinh(maManHinh);
        }

        public bool suaManHinh(DM_ManHinhDTO manHinh)
        {
            return dM_ManHinhDAL.suaManHinh(manHinh);
        }
    }
}
