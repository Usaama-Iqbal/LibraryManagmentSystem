using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryManagment.Models
{
    public class Login
    {
        [Key]

        public int UserId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Required")]

        public string Passward { get; set; }

    }
}
