using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcAjaxHelpers.Models
{
    public class Nesne
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public HttpPostedFileBase Ozgecmis { get; set; }
    }
}