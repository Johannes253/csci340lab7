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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesCountry.Data.RazorPagesCountryContext _context;

        public DetailsModel(RazorPagesCountry.Data.RazorPagesCountryContext context)
        {
            _context = context;
        }

      public Country Country { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Country == null)
            {
                return NotFound();
            }

            var country = await _context.Country.FirstOrDefaultAsync(m => m.Id == id);
            if (country == null)
            {
                return NotFound();
            }
            else 
            {
                Country = country;
            }
            return Page();
        }
    }
}
