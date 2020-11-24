using Sales_ASPNET_Core.Data;
using Sales_ASPNET_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return _context.Seller.ToList();
        }
    }
}
