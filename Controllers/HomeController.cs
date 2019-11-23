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

        FoodBasket food = new FoodBasket();
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

            food = dbContext.ContactYemekSepeti.Where(b => b.Food_Id.Equals(GelenId)).FirstOrDefault();

            if (food == null) food = new FoodBasket();

            return Json(food, JsonRequestBehavior.AllowGet);
        }
   
    }
}
