using BaiTapLon.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;

namespace BaiTapLon.Dao
{
    public class UserDAO
    {
        private Online_Music dbContext = new Online_Music();

        public IQueryable<UserName> GetAllUser()
        {
            return dbContext.UserNames;
        }
        public int Create(UserName user)
        {
            dbContext.UserNames.Add(user);
            dbContext.SaveChanges();
            return user.Id;
        }
        public UserName GetId(int id)
        { 
            return dbContext.UserNames.FirstOrDefault(x => x.Id == id);    
        }
        public UserName GetEmail(String Email)
        {
            return dbContext.UserNames.FirstOrDefault(x => x.email == Email);
        }
        public UserName GetName(String name)
        {
            return dbContext.UserNames.FirstOrDefault(x => x.Name == name);
        }

        public int Deletes(int id)
        {
            var Dl = dbContext.UserNames.FirstOrDefault(x => x.Id == id);
            dbContext.UserNames.Remove(Dl);
            dbContext.SaveChanges();
            return id;
        }

        public IEnumerable<UserName> ListAllPaping(int page , int pageSize)
        {
            return dbContext.UserNames.OrderByDescending(x => x.Id).ToPagedList(page, pageSize);
        }

    }
}