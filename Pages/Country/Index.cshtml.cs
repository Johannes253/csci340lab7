using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

         public SelectList? BestFoods { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? BestFood { get; set; }

    public async Task OnGetAsync()
{
    IQueryable<string> bestFoodQuery = from c in _context.Country
                                    orderby c.BestFood
                                    select c.BestFood;

    var countries = from c in _context.Country
                 select c;

    if (!string.IsNullOrEmpty(SearchString))
    {
        countries = countries.Where(s => s.Name.Contains(SearchString));
    }

    if (!string.IsNullOrEmpty(BestFood))
    {
        countries = countries.Where(x => x.BestFood == BestFood);
    }
    BestFoods = new SelectList(await bestFoodQuery.Distinct().ToListAsync());
    Country = await countries.ToListAsync();
}
    }
}
