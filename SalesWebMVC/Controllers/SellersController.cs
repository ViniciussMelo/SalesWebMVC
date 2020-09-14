using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
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

        #region Create
        public IActionResult Create()
        {
            return View();
        }
        #endregion

        #region Create (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]// Prevent atacks csrf
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
