using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        #region CTOR
        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }
        #endregion

        #region FindAll
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
        #endregion
    }
}
