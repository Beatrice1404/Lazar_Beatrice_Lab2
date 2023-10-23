using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lazar_Beatrice_Lab2.Data;
using Lazar_Beatrice_Lab2.Models;

namespace Lazar_Beatrice_Lab2.Pages.books
{
    public class CreateModel : PageModel
    {
        private readonly Lazar_Beatrice_Lab2.Data.Lazar_Beatrice_Lab2Context _context;

        public CreateModel(Lazar_Beatrice_Lab2.Data.Lazar_Beatrice_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
            "PublisherName");

            return Page();
        }

        [BindProperty]
        public book book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.book == null || book == null)
            {
                return Page();
            }

            _context.book.Add(book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
