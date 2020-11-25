using Sales_ASPNET_Core.Data;
using Sales_ASPNET_Core.Models;
using System;
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

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        public void Insert(Department department)
        {
            _context.Add(department);
            _context.SaveChanges();
        }
    }
}
