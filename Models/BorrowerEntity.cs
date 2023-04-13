using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolLibraryManagment.Models
{
    public class BorrowerEntity
    {
        [Key]
        public int BorrowerId { get; set; }

        
        
        
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        public DateTime DateBorrowed { get; set; }



        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }



        [Required(ErrorMessage = "Required")]
        [Display(Name = "Book")]
        public int BookId { get; set; }


       


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Student")]
        public int StudentId { get; set; }

        
        [NotMapped]
        public String Title { get; set; }

        [NotMapped]
        public String StudentName { get; set; }





    }
}
