using GanjinehStore.Data;
using GanjinehStore.Models;
using GanjinehStore.Services.Interfaces;
using GanjinehStore.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace GanjinehStore.Services
{
    public class BookService : Service<Book>, IBookService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<Service<Book>> _logger;

        public BookService(ApplicationDbContext context, ILogger<Service<Book>> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public int BooksCount(string title) 
        {
            if (!string.IsNullOrEmpty(title))
            {
                return _context.Books.Count(b => b.Title.Contains(title));
            }

            return _context.Books.Count();
        }

        public BookPagingViewModel GetPaginatedBooks(string title = null, 
            int pageNumber = 1, 
            int pageSize = 32)
        {
            // list of books
            IQueryable<Book> books = _context.Books;

            var take = pageSize;
            var skip = (pageNumber - 1) * pageSize;
            var booksCount = BooksCount(title);

            var pagesCount = (int)Math.Ceiling(Decimal.Divide(booksCount, pageSize));

            return new BookPagingViewModel
            {
                Books = books
                .OrderByDescending(b => b.BookId)
                .Skip(skip)
                .Take(take)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
    }
}
