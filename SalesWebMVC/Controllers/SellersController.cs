using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        #region CTOR
        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
        #endregion
    }
}
