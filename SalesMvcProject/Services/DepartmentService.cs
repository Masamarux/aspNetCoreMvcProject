using SalesMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvcProject.Services
{
    public class DepartmentService
    {
        private readonly SalesMvcProjectContext _context;

        public DepartmentService(SalesMvcProjectContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
