using System.Collections.Generic;

namespace GanjinehStore.Models
{
    public class Book
    {
        public Book()
        {
            BookGenres = new List<BookGenre>();
        }

        public int BookId { get; set; }

        public string Title { get; set; }

        public string Abstraction { get; set; }

        public int PagesCount { get; set; }

        public string ISBN { get; set; }

        public int AuthorId { get; set; }

        public int PublicationId { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
    }
}
