using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tuan1314.Models;

namespace Tuan1314.Controllers
{
    public class BaiHatAPIController : ApiController
    {
        [HttpGet]
        public List<tbl_BaiHat> GetBaiHatLists()
        {
            dbBaiHatDataContext db = new dbBaiHatDataContext();
            return db.tbl_BaiHats.ToList();
        }
        [HttpGet]
        public tbl_BaiHat GetBaiHat(int id)
        {
            dbBaiHatDataContext db = new dbBaiHatDataContext();
            return db.tbl_BaiHats.FirstOrDefault(s => s.MaBH == id);
        }
        [HttpPost]
        public int InsertNewBaiHat(string TenBH, int MaTL, int MaNS)
        {
            try
            {
                dbBaiHatDataContext db = new dbBaiHatDataContext();
                tbl_BaiHat s = new tbl_BaiHat();

                bool kt = db.tbl_BaiHats.Any(song => song.TenBH.Equals(TenBH));
                if(kt == true)
                {
                    return 0;
                }
                s.TenBH = TenBH;
                s.MaTL = MaTL;
                s.MaNS = MaNS;
                db.tbl_BaiHats.InsertOnSubmit(s);
                db.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        [HttpPut]
        public bool UpdateBaiHat(int MaBH, string TenBH, int MaTL, int MaNS)
        {
            try
            {
                dbBaiHatDataContext db = new dbBaiHatDataContext();
                tbl_BaiHat song = db.tbl_BaiHats.FirstOrDefault(s => s.MaBH == MaBH);
                if (song == null) return false;
                song.TenBH = TenBH;
                song.MaTL = MaTL;
                song.MaNS = MaNS;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpDelete]
        public bool DeleteBaiHat(int Ma)
        {
            dbBaiHatDataContext db = new dbBaiHatDataContext();
            tbl_BaiHat song = db.tbl_BaiHats.FirstOrDefault(s => s.MaBH == Ma);
            if (song == null) return false;
            db.tbl_BaiHats.DeleteOnSubmit(song);
            db.SubmitChanges();
            return true;
        }
    }
}
