using CyberMinerSearch.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberMinerSearch.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Index(SearchModel model)
        {
            SearchModel searchModel = new SearchModel();
            searchModel.URLModels = new List<URLModel>();


            System.Data.SqlClient.SqlConnection sqlConnection1 =
new System.Data.SqlClient.SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sqlConnection1.Open();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT * FROM URLS", sqlConnection1);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var RowID = reader["ID"];
                    URLModel urlmodel = new URLModel();
                    urlmodel.Id = (Guid)RowID;
                    var RowURL = reader["URL"];
                    urlmodel.URL1 = ((string)RowURL);
                    var RowDesc = reader["Description"];
                    urlmodel.Description = ((string)RowDesc);
                    searchModel.URLModels.Add(urlmodel);
                }
            }

            if (!String.IsNullOrEmpty(model.searchtext))
            {

                var caseSensitivity = model.isCaseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

                    var filteredResults = searchModel.URLModels
                        .Where(u => u.Description.Contains(model.searchtext,
                        caseSensitivity));

                    searchModel.URLModels = filteredResults.ToList();
            }

            return View(searchModel);
        }

        public ActionResult Index()
        {
            SearchModel searchModel = new SearchModel();
            searchModel.URLModels = new List<URLModel>();


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
    public static class Helpers
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }
    }
 
}