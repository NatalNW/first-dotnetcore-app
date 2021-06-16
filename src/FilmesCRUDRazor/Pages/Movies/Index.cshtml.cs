using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmesCRUDRazor.Models;

namespace FilmesCRUDRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FilmesCRUDRazor.Models.MovieContext _context;

        public IndexModel(FilmesCRUDRazor.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public SelectList Genres { get; set; }

        public string FilteredByGenre { get; set; }

        public async Task OnGetAsync(string searchByTitle, string filteredByGenre)
        {
            IQueryable<string> queryGenre = from m in _context.Movie orderby m.Genre select m.Genre;

            var movies = from m in _context.Movie select m;

            if(!String.IsNullOrEmpty(searchByTitle)){
                movies = movies.Where(search => search.Title.Contains(searchByTitle));
            }

            if(!String.IsNullOrEmpty(filteredByGenre)){
                movies = movies.Where(filtered => filtered.Genre == filteredByGenre);
            }

            Genres = new SelectList(await queryGenre.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
