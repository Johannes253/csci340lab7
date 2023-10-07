using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCountry.Data;
using RazorPagesCountry.Models;

namespace RazorPagesCountry.Pages_Country
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCountry.Data.RazorPagesCountryContext _context;

        public IndexModel(RazorPagesCountry.Data.RazorPagesCountryContext context)
        {
            _context = context;
        }

        public IList<Country> Country { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Country != null)
            {
                Country = await _context.Country.ToListAsync();
            }
        }
    }
}
