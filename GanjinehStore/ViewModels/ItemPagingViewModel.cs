using System.Collections.Generic;

namespace GanjinehStore.ViewModels
{
    public class ItemPagingViewModel<T> where T : class
    {
        public List<T> Items { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
