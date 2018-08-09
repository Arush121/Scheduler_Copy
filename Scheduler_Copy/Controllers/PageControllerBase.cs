using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scheduler_Copy.Controllers
{
    public class PageControllerBase : Controller
    {
        // GET: PageControllerBase
        public ActionResult Index()
        {
            return View();
        }
    }
}