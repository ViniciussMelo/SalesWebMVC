using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region SimpleSearch
        public IActionResult SimpleSearch()
        {
            return View();
        }
        #endregion

        #region GroupingSearch
        public IActionResult GroupingSearch()
        {
            return View();
        }
        #endregion
    }
}
