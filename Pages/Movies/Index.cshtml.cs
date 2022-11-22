using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razerpagemovie.Data;
using razerpagemovie.Models;

namespace razerpagemovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly razerpagemovie.Data.razerpagemovieContext _context;

        public IndexModel(razerpagemovie.Data.razerpagemovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
