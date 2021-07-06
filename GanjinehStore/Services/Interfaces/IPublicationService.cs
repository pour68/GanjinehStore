using GanjinehStore.Models;
using GanjinehStore.ViewModels;

namespace GanjinehStore.Services.Interfaces
{
    public interface IPublicationService : IService<Publication>
    {
        ItemPagingViewModel<Publication> GetPaginatedPublications(string publihserName = null, int pageNumber = 1, int pageSize = 32);

        int PublicationsCount(string publihserName);
    }
}
