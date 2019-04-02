using BaiTapLon.EF;
using BaiTapLon.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Dao
{
    public class Updates_DAO
    {
        private Online_Music dbContext = new Online_Music();
        public bool Updates(BaiHat entity)
        {
            try
            {
                var MaBH = dbContext.BaiHats.Find(entity.MaBH);
                MaBH.MaBH = entity.MaBH;
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
        public BaiHat GetById(string MaBH)
        {
            return dbContext.BaiHats.SingleOrDefault(x => x.MaBH == MaBH);
        }
    }
}