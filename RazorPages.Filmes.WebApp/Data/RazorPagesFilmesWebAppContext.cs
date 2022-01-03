#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages.Filmes.WebApp.Models;

namespace RazorPages.Filmes.WebApp.Data
{
    public class RazorPagesFilmesWebAppContext : DbContext
    {
        public RazorPagesFilmesWebAppContext (DbContextOptions<RazorPagesFilmesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPages.Filmes.WebApp.Models.Movie> Movie { get; set; }
    }
}
