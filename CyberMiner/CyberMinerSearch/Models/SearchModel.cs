using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CyberMinerSearch.Models
{
    public class SearchModel
    {
        public List<URLModel> URLModels { get; set; }


        [Display(Name = "Search:")]
        public string searchtext { get; set; }

        [Display(Name = "Case Sensitive ")]
        public bool isCaseSensitive { get; set; }

    }
}