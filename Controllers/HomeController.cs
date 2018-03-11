using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Search.Models;

namespace Search.Controllers
{
    public class HomeController : Controller
    {

        YemekSepeti yemek = new YemekSepeti();
        databaseContext dbContext = new databaseContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(object id)
        {
            if (id == null || id == "") id = 0;

            int GelenId = Convert.ToInt32(id);

            yemek = dbContext.ContactYemekSepeti.Where(b => b.Yemek_Id.Equals(GelenId)).FirstOrDefault();

            if (yemek == null) yemek = new YemekSepeti();

            return Json(yemek, JsonRequestBehavior.AllowGet);
        }
   
    }
}