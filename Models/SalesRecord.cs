using Sales_ASPNET_Core.Models.enums;
using System;

namespace Sales_ASPNET_Core.Models
{
    public class SalesRecord
    {
        public SalesRecord() { }

        public SalesRecord(DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }
    }
}
