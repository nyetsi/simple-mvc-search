using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchEngine.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {

            return View("Search");
        }

        public JsonResult Search(string searchTerm)
        {
            return Json(true);
        }
    }
}