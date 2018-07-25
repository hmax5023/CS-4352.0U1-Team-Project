using CyberMinerSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberMinerSearch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchText)
        {
            SearchModel searchModel = new SearchModel();
            searchModel.searchtext = "Search.";

            return View(searchModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "We're a bunch of scrubs making some web page thingy.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Search()
        {
            ViewBag.Message = "Search here";

            return View();
        }
    }
}