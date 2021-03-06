﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Sales_ASPNET_Core.Models
{
    public class Seller
    {
        public ICollection<SalesRecord> SalesRecord { get; set; } = new List<SalesRecord>();

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

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        

        public void AddSales(SalesRecord salesRecord)
        {
            SalesRecord.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            SalesRecord.Remove(salesRecord);
        }

        public double TotalSales()
        {
            return SalesRecord.Sum(x => x.Amount);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return SalesRecord.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }
    }
}
