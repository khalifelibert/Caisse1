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
    public class DetailsModel : PageModel
    {
        private readonly Caisse1.Data.CaisseContext _context;

        public DetailsModel(Caisse1.Data.CaisseContext context)
        {
            _context = context;
        }

      public Bill Bill { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Bills == null)
            {
                return NotFound();
            }

            var bill = await _context.Bills.FirstOrDefaultAsync(m => m.Id == id);
            if (bill == null)
            {
                return NotFound();
            }
            else 
            {
                Bill = bill;
            }
            return Page();
        }
    }
}
