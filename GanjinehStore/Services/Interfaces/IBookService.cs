using GanjinehStore.Models;
using GanjinehStore.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace GanjinehStore.Services.Interfaces
{
    public interface IBookService : IService<Book>
    {
        IEnumerable<Book> GetAllBooks();

        ItemPagingViewModel<Book> GetPaginatedBooks(string title = null, int pageNumber = 1, int pageSize = 32);

        int BooksCount(string title);

        Book Add(Book book, IFormFile bookCover);

        Book Update(Book book, IFormFile bookCover);
    }
}
