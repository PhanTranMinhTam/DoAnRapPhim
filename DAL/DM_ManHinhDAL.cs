using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DM_ManHinhDAL
    {
        string strConn;
        QL_RAPPHIMDataContext db = new QL_RAPPHIMDataContext();

        public DM_ManHinhDAL()
        {
            strConn = Settings.Default.strConn;
        }

        public List<DM_ManHinhDTO> LoadManHinh()
        {
            List<DM_ManHinhDTO> lstManHinh = new List<DM_ManHinhDTO>();
            IQueryable<DM_ManHinhDTO> query = from mh in db.DM_ManHinhs
                                              select new DM_ManHinhDTO
                                              {
                                                  MaManHinh = mh.maManHinh,
                                                  TenManHinh = mh.tenManHinh
                                              };
            lstManHinh = query.ToList();
            return lstManHinh;
        }

        public string taoMaManHinh()
        {
            string maManHinh = "";
            string query = (from dm in db.DM_ManHinhs
                            orderby dm.maManHinh descending
                            select dm.maManHinh).FirstOrDefault();
            if (query != null)
            {
                int so = int.Parse(query.Substring(2)) + 1;
                if (so < 10)
                {
                    maManHinh = "MH00" + so;
                }
                else
                {
                    maManHinh = "MH0" + so;
                }
            }
            else
            {
                maManHinh = "MH001";
            }
            return maManHinh;
        }

        public bool themManHinh(DM_ManHinhDTO manHinh)
        {
            try
            {
                DM_ManHinh mh = new DM_ManHinh();
                mh.maManHinh = manHinh.MaManHinh;
                mh.tenManHinh = manHinh.TenManHinh;
                db.DM_ManHinhs.InsertOnSubmit(mh);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaManHinh(string maManHinh)
        {
            try
            {
                DM_ManHinh mh = db.DM_ManHinhs.Where(t => t.maManHinh == maManHinh).FirstOrDefault();
                db.DM_ManHinhs.DeleteOnSubmit(mh);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaManHinh(DM_ManHinhDTO manHinh)
        {
            try
            {
                DM_ManHinh mh = db.DM_ManHinhs.Where(t => t.maManHinh == manHinh.MaManHinh).FirstOrDefault();
                mh.tenManHinh = manHinh.TenManHinh;
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
