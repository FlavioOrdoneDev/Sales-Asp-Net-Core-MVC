using Sales_ASPNET_Core.Data;
using Sales_ASPNET_Core.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales_ASPNET_Core.Services
{
    public class DepartmentService
    {
        private readonly SalesContext _context;

        public DepartmentService(SalesContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task InsertAsync(Department department)
        {
            _context.Add(department);
            await _context.SaveChangesAsync();
        }
    }
}
