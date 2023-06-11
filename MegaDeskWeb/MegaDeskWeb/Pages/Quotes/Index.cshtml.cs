using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Data;
using MegaDeskWeb.Modelos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskWeb.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWeb.Data.MegaDeskWebContext _context;

        public IndexModel(MegaDeskWeb.Data.MegaDeskWebContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            var quote = from q in _context.Quote select q;
            if (!string.IsNullOrEmpty(SearchString))
            {
                quote = quote.Where(s => s.customerName.Contains(SearchString));
            }
            Quote = await quote.ToListAsync();
            /*if (_context.Quote != null)
            {
                Quote = await _context.Quote.ToListAsync();
            }*/
        }
    }
}
