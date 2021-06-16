using System.ComponentModel.DataAnnotations;

namespace GanjinehStore.Models
{
    public class BookGenre
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "ژانر")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        public int GenreId { get; set; }

        [Display(Name = "کتاب")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        public int BookId { get; set; }
    }
}
