using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryManagment.Models
{
    public class StudentEntity
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Required")]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Address { get; set; }

       
    }
}
