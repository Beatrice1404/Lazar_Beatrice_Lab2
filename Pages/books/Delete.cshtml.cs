﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lazar_Beatrice_Lab2.Data;
using Lazar_Beatrice_Lab2.Models;

namespace Lazar_Beatrice_Lab2.Pages.books
{
    public class DeleteModel : PageModel
    {
        private readonly Lazar_Beatrice_Lab2.Data.Lazar_Beatrice_Lab2Context _context;

        public DeleteModel(Lazar_Beatrice_Lab2.Data.Lazar_Beatrice_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public book book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                book = book;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }
            var book = await _context.Book.FindAsync(id);

            if (book != null)
            {
                book = book;
                _context.Book.Remove(book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
