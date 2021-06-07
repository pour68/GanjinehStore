using System.Collections.Generic;

namespace GanjinehStore.Models
{
    public class Genre
    {
        public Genre()
        {
            BookGenres = new List<BookGenre>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
    }
}
