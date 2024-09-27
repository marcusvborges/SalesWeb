using SalesWeb.Data;
using SalesWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWeb.Services
{
    public class SellersService
    {
        private readonly SalesWebContext _context;

        public SellersService(SalesWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
