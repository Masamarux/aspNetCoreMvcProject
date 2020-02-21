using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvcProject.Models.Services
{
    public class SellerService
    {
        private readonly SalesMvcProjectContext _context;

        public SellerService(SalesMvcProjectContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
