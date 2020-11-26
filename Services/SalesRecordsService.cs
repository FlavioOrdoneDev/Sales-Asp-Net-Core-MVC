using Sales_ASPNET_Core.Data;
using Sales_ASPNET_Core.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales_ASPNET_Core.Services
{
    public class SalesRecordsService
    {
        private readonly SalesContext _context;

        public SalesRecordsService(SalesContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
                result = result.Where(x => x.Date >= minDate.Value);
            if (maxDate.HasValue)
                result = result.Where(x => x.Date <= maxDate.Value);

            return await result
                        .Include(x => x.Seller)
                        .Include(x => x.Seller.Department)
                        .OrderByDescending(x => x.Date)
                        .ToListAsync();
        }
    }
}
