using Microsoft.EntityFrameworkCore;
using SalesWebApplication.Data;
using SalesWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApplication.Services
{
    public class DepartmentService
    {
        private readonly SalesWebApplicationContext _context;

        public DepartmentService(SalesWebApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
