using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales_ASPNET_Core.Models
{
    public class Seller
    {
        private ICollection<SalesRecord> _salesRecord = new List<SalesRecord>();

        public Seller() { }

        public Seller(string name, string email, DateTime birthDay, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
            BaseSalary = baseSalary;
            Department = department;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public double BaseSalary { get; set; }

        //public int DepartmentId { get; set; }
        public Department Department { get; set; }

        

        public void AddSales(SalesRecord salesRecord)
        {
            _salesRecord.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            _salesRecord.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return _salesRecord.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }
    }
}
