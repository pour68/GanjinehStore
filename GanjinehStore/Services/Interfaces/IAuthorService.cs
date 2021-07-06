using GanjinehStore.Models;
using GanjinehStore.ViewModels;

namespace GanjinehStore.Services.Interfaces
{
    public interface IAuthorService : IService<Author>
    {
        ItemPagingViewModel<Author> GetPaginatedAuthors(string authorName = null, int pageNumber = 1, int pageSize = 32);

        int AuthorsCount(string authorName);
    }
}
