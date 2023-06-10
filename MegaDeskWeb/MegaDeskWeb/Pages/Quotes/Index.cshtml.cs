﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Data;
using MegaDeskWeb.Modelos;

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

        public async Task OnGetAsync()
        {
            if (_context.Quote != null)
            {
                Quote = await _context.Quote.ToListAsync();
            }
        }
    }
}
