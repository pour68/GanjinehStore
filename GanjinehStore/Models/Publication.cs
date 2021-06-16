using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GanjinehStore.Models
{
    public class Publication
    {
        public Publication()
        {
            Books = new List<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "ناشر")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [MaxLength(128, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Name { get; set; }

        [Display(Name = "تاریخ تاسیس")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "تلفن های تماس")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "شماره های فکس")]
        [MaxLength(32, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Fax { get; set; }
        [Display(Name = "شماره های موبایل")]
        [MaxLength(32, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Mobile { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
