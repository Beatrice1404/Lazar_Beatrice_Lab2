using System;
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
    public class IndexModel : PageModel
    {
        private readonly Lazar_Beatrice_Lab2.Data.Lazar_Beatrice_Lab2Context _context;

        public IndexModel(Lazar_Beatrice_Lab2.Data.Lazar_Beatrice_Lab2Context context)
        {
            _context = context;
        }

        public IList<book> book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            book = await _context.book
            .Include(b => b.Publisher)
            .ToListAsync();
            if (_context.book != null)
            {
                book = await _context.book.ToListAsync();
            }
        }
    }
}
