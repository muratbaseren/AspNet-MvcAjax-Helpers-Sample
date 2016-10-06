using AspNetMvcAjaxHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcAjaxHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Index2()
        {
            return View(new Nesne());
        }

        [HttpPost]
        public ActionResult Index2(Nesne model)
        {
            //model.Ozgecmis.SaveAs()

            return View(model);
        }



        public PartialViewResult GetUrunler()
        {
            List<string> veriler = new List<string>() { "Kadir", "Murat", "Başeren" };

            System.Threading.Thread.Sleep(3000);

            return PartialView("_UrunlerPartial", veriler);
        }
    }
}