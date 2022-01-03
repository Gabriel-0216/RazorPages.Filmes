#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPages.Filmes.WebApp.Data;
using RazorPages.Filmes.WebApp.Models;

namespace RazorPages.Filmes.WebApp.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPages.Filmes.WebApp.Data.RazorPagesFilmesWebAppContext _context;

        public CreateModel(RazorPages.Filmes.WebApp.Data.RazorPagesFilmesWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
