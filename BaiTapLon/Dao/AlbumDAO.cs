using BaiTapLon.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Dao
{
    public class AlbumDAO
    {
        private Online_Music dbContext = new Online_Music();
        //Chuyen den cau lenh sql
        public IQueryable<AlBum> GetAllAlBums()
        {
            return dbContext.AlBums;
        }
    }
}