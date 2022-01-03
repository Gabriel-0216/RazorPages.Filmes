#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPages.Filmes.WebApp.Data;
using RazorPages.Filmes.WebApp.Models;

namespace RazorPages.Filmes.WebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages.Filmes.WebApp.Data.RazorPagesFilmesWebAppContext _context;

        public IndexModel(RazorPages.Filmes.WebApp.Data.RazorPagesFilmesWebAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieCategory { get; set; }
        public SelectList Categories { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie select m;

            if (!string.IsNullOrWhiteSpace(SearchFilter))
            {
                movies = movies.Where(p=> p.Title.Contains(SearchFilter) || p.Category.Contains(SearchFilter));
            }
            if (!string.IsNullOrWhiteSpace(MovieCategory))
            {
                movies = movies.Where(p=> p.Category == MovieCategory);
            }

            Categories = new SelectList(await _context.Movie.Select(p => p.Category).Distinct().ToListAsync());

            Movie = await movies.ToListAsync();
        }
    }
}
