using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryManagment.Models
{
    public class BookEntity
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Required")]
        public int BookNo { get; set; }

        [Required(ErrorMessage = "Required")]
        public string PublishDate { get; set; }


    }
}
