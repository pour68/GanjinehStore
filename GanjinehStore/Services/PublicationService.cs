using GanjinehStore.Data;
using GanjinehStore.Models;
using GanjinehStore.Services.Interfaces;
using GanjinehStore.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace GanjinehStore.Services
{
    public class PublicationService : Service<Publication>, IPublicationService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<Service<Publication>> _logger;

        public PublicationService(ApplicationDbContext context, ILogger<Service<Publication>> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public ItemPagingViewModel<Publication> GetPaginatedPublications(string publihserName = null,
        int pageNumber = 1,
        int pageSize = 32)
        {
            IQueryable<Publication> publications = _context.Publications;

            var take = pageSize;
            var skip = (pageNumber - 1) * pageSize;
            var publicationsCount = PublicationsCount(publihserName);

            var pagesCount = (int)Math.Ceiling(Decimal.Divide(publicationsCount, pageSize));

            return new ItemPagingViewModel<Publication>
            {
                Items = publications
                .OrderByDescending(b => b.Id)
                .Skip(skip)
                .Take(take)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public int PublicationsCount(string publisherName)
        {
            if (!string.IsNullOrEmpty(publisherName))
            {
                return _context.Publications.Count(b => b.Name.Contains(publisherName));
            }

            return _context.Publications.Count();
        }
    }
}
