using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales_ASPNET_Core.Models
{
    public class Department
    {
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
