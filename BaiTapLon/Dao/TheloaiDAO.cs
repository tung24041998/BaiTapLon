using BaiTapLon.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Dao
{
    
    public class TheloaiDAO
    {
        private Online_Music dbContext = new Online_Music(); 
        public IQueryable<TheLoai> GetallTheLoai()
        {
            return dbContext.TheLoais;
        }
    }
}