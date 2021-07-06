using GanjinehStore.Models;
using GanjinehStore.ViewModels;

namespace GanjinehStore.Services.Interfaces
{
    public interface IBookService : IService<Book>
    {
        BookPagingViewModel GetPaginatedBooks(string title = null, int pageNumber = 1, int pageSize = 32);

        int BooksCount(string title);
    }
}
