using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryManagment.Models
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Age { get; set; }

        public string Contact { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }

    }
}
