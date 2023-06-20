using Caisse1.Data;
using Caisse1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Caisse1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        CaisseContext _context;

        public BillController(CaisseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Bill> Get()
        {
            return _context.Bills
                .AsNoTracking()
                .ToList();
        }
    }
}
