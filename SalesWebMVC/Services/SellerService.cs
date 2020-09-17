using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        #region CTOR
        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }
        #endregion

        #region FindAll
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        #endregion

        #region Insert
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        #endregion

        #region FindById
        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }
        #endregion

        #region Remove
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
        #endregion
    }
}
