using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Caisse1.Data;
using Caisse1.Models;

namespace Caisse1.Pages.Commandes
{
    public class CreateModel : PageModel
    {
        private readonly Caisse1.Data.CaisseContext _context;

        public CreateModel(Caisse1.Data.CaisseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
         ViewData["ProduitId"] = new SelectList(_context.Produits, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Command Command { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Commands == null || Command == null)
            {
                return Page();
            }

            _context.Commands.Add(Command);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
