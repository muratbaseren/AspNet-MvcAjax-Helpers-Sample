using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcAjaxHelpers.Controllers
{
    public class Home2Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult GetUrunler()
        {
            List<string> liste = new List<string>() { "Kadir", "Murat", "Başeren" };

            System.Threading.Thread.Sleep(3000);

            return PartialView("_UrunlerPartial", liste);
        }


        public JsonResult GetUrunlerJson(string veri = "")
        {
            List<string> liste = new List<string>() { "Kadir", "Murat", "Başeren" };

            if(string.IsNullOrEmpty(veri) == false)
            {
                liste.Add(veri);
            }

            System.Threading.Thread.Sleep(3000);

            return Json(liste, JsonRequestBehavior.AllowGet);
        }

    }
}