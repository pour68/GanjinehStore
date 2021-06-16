using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GanjinehStore.Models
{
    public class Genre
    {
        public Genre()
        {
            BookGenres = new List<BookGenre>();
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "ژانر")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [MaxLength(256, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Title { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
    }
}
