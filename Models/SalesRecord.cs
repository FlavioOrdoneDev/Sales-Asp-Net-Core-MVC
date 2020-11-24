using Sales_ASPNET_Core.Models.enums;
using System;

namespace Sales_ASPNET_Core.Models
{
    public class SalesRecord
    {
        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, int amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }
    }
}
