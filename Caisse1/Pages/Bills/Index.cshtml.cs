using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Caisse1.Data;
using Caisse1.Models;

namespace Caisse1.Pages.Bills
{
    public class IndexModel : PageModel
    {
        private readonly Caisse1.Data.CaisseContext _context;

        public IndexModel(Caisse1.Data.CaisseContext context)
        {
            _context = context;
        }

        public IList<Bill> Bill { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Bills != null)
            {
                Bill = await _context.Bills.ToListAsync();
            }
        }
    }
}
