using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales_ASPNET_Core.Models
{
    public class Department
    {
        private ICollection<Seller> _sellers = new List<Seller>();

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void AddSeller(Seller seller)
        {
            _sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return _sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
