using BaiTapLon.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Dao
{
    public class NgheSi_DAO
    {
        private Online_Music dbContext = new Online_Music();
        public IQueryable<NgheSi> GetNgheSis()
        {
            return dbContext.NgheSis;
        }

    }
}