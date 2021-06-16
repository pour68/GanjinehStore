using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GanjinehStore.Models
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        [Key]
        public int AuthorId { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [MaxLength(128, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string FullName { get; set; }

        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [MaxLength(11, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Mobile { get; set; }

        [Display(Name = "پست الکترونیک")]
        [MaxLength(128, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Email { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
