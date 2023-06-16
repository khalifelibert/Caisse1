using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Caisse1.Data;
using Caisse1.Models;

namespace Caisse1.Pages.Commandes
{
    public class DetailsModel : PageModel
    {
        private readonly Caisse1.Data.CaisseContext _context;

        public DetailsModel(Caisse1.Data.CaisseContext context)
        {
            _context = context;
        }

      public Command Command { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Commands == null)
            {
                return NotFound();
            }

            var command = await _context.Commands.FirstOrDefaultAsync(m => m.Id == id);
            if (command == null)
            {
                return NotFound();
            }
            else 
            {
                Command = command;
            }
            return Page();
        }
    }
}
