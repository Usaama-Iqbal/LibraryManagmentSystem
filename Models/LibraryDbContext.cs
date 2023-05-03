using Microsoft.EntityFrameworkCore;

namespace SchoolLibraryManagment.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

        public DbSet<StudentEntity> tblStudent { get; set; }

        public DbSet<BookEntity> tblBook { get; set; }

        public DbSet<UserEntity> tblUser { get; set; }

        public DbSet <BorrowerEntity> tblBorrows { get; set; }

        public DbSet<Login> tblLogin { get; set; }

    }
}
