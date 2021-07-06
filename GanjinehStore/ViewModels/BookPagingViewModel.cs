using GanjinehStore.Models;
using System.Collections.Generic;

namespace GanjinehStore.ViewModels
{
    public class BookPagingViewModel
    {
        public List<Book> Books { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
