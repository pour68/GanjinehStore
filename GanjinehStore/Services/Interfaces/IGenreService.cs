using GanjinehStore.Models;
using GanjinehStore.ViewModels;

namespace GanjinehStore.Services.Interfaces
{
    public interface IGenreService : IService<Genre>
    {
        ItemPagingViewModel<Genre> GetPaginatedGenres(int pageNumber = 1, int pageSize = 32);

        int GenresCount();
    }
}
