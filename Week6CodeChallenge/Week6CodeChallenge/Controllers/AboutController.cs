using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        [HttpGet]
        public ActionResult Index()
        {
            return PartialView("Index");
        }
        [HttpGet]
        public ActionResult Who()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult What()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult Why()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult How()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult Where()
        {
            return PartialView();
        }
    }
}
