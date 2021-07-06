using GanjinehStore.Utilities;
using GanjinehStore.Data;
using GanjinehStore.Models;
using GanjinehStore.Services.Interfaces;
using GanjinehStore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace GanjinehStore.Services
{
    public class AuthorService : Service<Author>, IAuthorService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<Service<Author>> _logger;

        public AuthorService(ApplicationDbContext context, ILogger<Service<Author>> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public ItemPagingViewModel<Author> GetPaginatedAuthors(string authorName = null,
        int pageNumber = 1,
        int pageSize = 32)
        {
            IQueryable<Author> authors = _context.Authors;

            var take = pageSize;
            var skip = (pageNumber - 1) * pageSize;
            var authorsCount = AuthorsCount(authorName);

            var pagesCount = (int)Math.Ceiling(Decimal.Divide(authorsCount, pageSize));

            return new ItemPagingViewModel<Author>
            {
                Items = authors
                .OrderByDescending(b => b.AuthorId)
                .Skip(skip)
                .Take(take)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public int AuthorsCount(string authorName)
        {
            if (!string.IsNullOrEmpty(authorName))
            {
                return _context.Authors.Count(b => b.FullName.Contains(authorName));
            }

            return _context.Authors.Count();
        }
    }
}
