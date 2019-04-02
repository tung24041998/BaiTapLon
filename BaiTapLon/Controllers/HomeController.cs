using BaiTapLon.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTapLon.Controllers
{
    public class HomeController : Controller
    {
        private AlbumDAO alBumDAO = new AlbumDAO();
        private BaihatDAO baiHatDAO = new BaihatDAO();
        private Gan_day_DAO gan_Day_DAO = new Gan_day_DAO();
        private NgheSi_DAO NgheSi_DAO = new NgheSi_DAO();
        private TheloaiDAO TheloaiDAO = new TheloaiDAO();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult AlBum(string id)
        {
            var model = alBumDAO.GetAllAlBums().ToList();
            return View(model);
        }
        public ActionResult BaiHat(String id)
        {
            var models = baiHatDAO.Detail(id);
            var model = baiHatDAO.GetAllBaiHat().ToList();
            return View(model);
        }
        public ActionResult Gan_Day()
        {
            var model = gan_Day_DAO.GetAllBaiHat().OrderByDescending(x => x.LuotNghe).ToList();
            return View(model);
        }
        public ActionResult TheLoai()
        {
            var model = TheloaiDAO.GetallTheLoai().ToList();
            return View(model);
        }
        public ActionResult Nghe_Si()
        {
            var model = NgheSi_DAO.GetNgheSis().ToList();
            return View(model);
        }
        public ActionResult Update(string MaBH)
        {
            var BaiHat = new Updates_DAO().GetById(MaBH);
            return View(BaiHat);
        }

        [HttpPost]
        public ActionResult Uplike(string id)
        {
            baiHatDAO.UpLike(id);
            return Json("true", JsonRequestBehavior.AllowGet);
        }

    }
}