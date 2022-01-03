#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Filmes.WebApp.Data;
using RazorPages.Filmes.WebApp.Models;

namespace RazorPages.Filmes.WebApp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPages.Filmes.WebApp.Data.RazorPagesFilmesWebAppContext _context;

        public DetailsModel(RazorPages.Filmes.WebApp.Data.RazorPagesFilmesWebAppContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
