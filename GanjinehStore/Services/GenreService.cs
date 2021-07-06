using GanjinehStore.Data;
using GanjinehStore.Models;
using GanjinehStore.Services.Interfaces;
using GanjinehStore.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace GanjinehStore.Services
{
    public class GenreService : Service<Genre>, IGenreService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<Service<Genre>> _logger;

        public GenreService(ApplicationDbContext context, ILogger<Service<Genre>> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public ItemPagingViewModel<Genre> GetPaginatedGenres(int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<Genre> genres = _context.Genres;

            var take = pageSize;
            var skip = (pageNumber - 1) * pageSize;
            var genresCount = GenresCount();

            var pagesCount = (int)Math.Ceiling(Decimal.Divide(genresCount, pageSize));

            return new ItemPagingViewModel<Genre>
            {
                Items = genres
                .OrderByDescending(b => b.Id)
                .Skip(skip)
                .Take(take)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public int GenresCount() =>  _context.Genres.Count();
    }
}
