using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
