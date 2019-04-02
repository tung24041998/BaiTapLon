using BaiTapLon.Dao;
using BaiTapLon.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Dao
{

    public class BaihatDAO
    {
        private Online_Music dbContext = new Online_Music();

        public IQueryable<BaiHat> GetAllBaiHat()
        {
            return dbContext.BaiHats;
        }
        //lay ra bai hat theo id
        public BaiHat Detail(string id)
        {
            //x-> BaiHats , 
            return dbContext.BaiHats.FirstOrDefault(x => x.MaBH == id);
        }

        public void UpLike(string id)
        {
            var baiHat = dbContext.BaiHats.Where(x => x.MaBH == id).First();
            baiHat.LuotNghe += 1;
            dbContext.SaveChanges();
        }
    }
}