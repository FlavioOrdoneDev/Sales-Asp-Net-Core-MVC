using Microsoft.EntityFrameworkCore;
using Sales_ASPNET_Core.Data;
using Sales_ASPNET_Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sales_ASPNET_Core.Services
{
    public class SellerService
    {
        private readonly SalesContext _context;

        public SellerService(SalesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.Include(x => x.Department).ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
