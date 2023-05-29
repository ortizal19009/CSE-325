using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cse325w6.Models;

namespace cse325w6.Data
{
    public class cse325w6Context : DbContext
    {
        public cse325w6Context (DbContextOptions<cse325w6Context> options)
            : base(options)
        {
        }

        public DbSet<cse325w6.Models.Movie> Movie { get; set; } = default!;
    }
}
