using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

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
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
        #endregion
    }
}
