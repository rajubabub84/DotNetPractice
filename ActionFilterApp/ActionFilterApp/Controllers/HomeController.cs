using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterApp.Controllers
{
    public class HomeController : Controller
    { 
        [Authorize(Roles ="admin,admin1",Users ="raju,babu")]       
        [OutputCache(Duration =120)]
        [HandleError(View="error.cshtml")]        
        // GET: Home
        public string Index()
        {
            return "Heelo World";
        }
    }
}