using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime BithDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        #region CTOR
        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime bithDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            this.email = email;
            BithDate = bithDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        #endregion

        #region AddSales
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        #endregion

        #region RemoveSales
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        #endregion

        #region TotalSales
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
        #endregion
    }
}
