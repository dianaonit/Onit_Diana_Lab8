using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Onit_Diana_Lab8.Data;
using Onit_Diana_Lab8.Models;

namespace Onit_Diana_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Onit_Diana_Lab8.Data.Onit_Diana_Lab8Context _context;

        public IndexModel(Onit_Diana_Lab8.Data.Onit_Diana_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
        }
    }
}
