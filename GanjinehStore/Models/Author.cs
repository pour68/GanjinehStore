using System.Collections.Generic;

namespace GanjinehStore.Models
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
