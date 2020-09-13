using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        #region CTOR
        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region AddSeller
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        #endregion

        #region TotalSales
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
        #endregion
    }
}
