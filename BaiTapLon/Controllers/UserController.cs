using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTapLon.Dao;
using BaiTapLon.EF;

namespace BaiTapLon.Controllers
{
    public class UserController : Controller
    {
        private UserDAO dbuser = new UserDAO();
        //int page = 1, int pageSize = 1
        //    var bh = dbuser.LissAllPaping(page, pageSize);
        public ActionResult Index(int page = 1)
        {
            int pageSize = 5;
            var model = dbuser.ListAllPaping(page, pageSize);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserName user)
        {
            if (ModelState.IsValid)
            {
                var Email = dbuser.GetEmail(user.email);
                if (Email != null)
                {
                    ViewBag.id = "Email da ton tai";
                    return View();
                }
                else
                {
                    dbuser.Create(user);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var bh = dbuser.GetId(id);

            return View(bh);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult postDelete(int idUser)
        {

            if (ModelState.IsValid)
            {
                dbuser.Deletes(idUser);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var bh = dbuser.GetId(id);
            return View(bh);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String uname, int password)
        {
            var pw = dbuser.GetId(password);
            var name = dbuser.GetName(uname);
            if (name != null && pw != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.msg = "Đang nhập không đúng !";
                return View();
            }

        }

    }
}