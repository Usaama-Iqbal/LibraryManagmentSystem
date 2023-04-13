using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolLibraryManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLibraryManagment.Controllers
{
    public class BorrowerController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}



        //Method to Load Categories in Add Item View Page

        private void loadBook()
        {
            try
            {
                List<BookEntity> BookList = new List<BookEntity>();
                BookList = _Db.tblBook.ToList();

                BookList.Insert(0, new BookEntity { BookId = 0, Title = "Please Select" });

                ViewBag.BookList = BookList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadStudent()
        {
            try
            {
                List<StudentEntity> Student = new List<StudentEntity>();
                Student = _Db.tblStudent.ToList();

                Student.Insert(0, new StudentEntity { StudentId = 0, Name = "Please Select" });

                ViewBag.Student = Student;

            }
            catch (Exception ex)
            {


            }
        }


        private readonly LibraryDbContext _Db;

        public BorrowerController(LibraryDbContext Db)
        {
            _Db = Db;

        }



        public IActionResult BorrowList()
        {

            try
            {


                var BorrowList = from a in _Db.tblBorrows
                                 join b in _Db.tblBook on a.BookId equals b.BookId
                                 join c in _Db.tblStudent on a.StudentId equals c.StudentId
                                 //into Book
                                 //from b in Book.DefaultIfEmpty()
                                 



                                 select new BorrowerEntity
                                 {


                                     DateBorrowed = a.DateBorrowed,
                                     ReturnDate = a.ReturnDate,
                                     BookId = a.BookId,
                                     Title = b == null ? "" : b.Title,
                                     StudentId = a.StudentId,
                                     StudentName = c == null ? "" : c.Name
                                     

                                 };


                return View(BorrowList);
            }
            catch (Exception ex)
            {
                return View();

            }

        }



        public async Task<IActionResult> AddBorrower(BorrowerEntity obj)
        {
            loadBook();
            loadStudent();
            return View(obj);
        }

        public async Task<IActionResult> SaveBorrower(BorrowerEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.BorrowerId == 0)
                    {
                        _Db.tblBorrows.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("BorrowList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("BorrowList");
            }
        }

        public async Task<IActionResult> DeleteBorrower(int BorrowerId)
        {
            try
            {
                var item = await _Db.tblBorrows.FindAsync(BorrowerId);
                if (item != null)
                {
                    _Db.tblBorrows.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("BorrowList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("BorrowList");
            }
        }
    }
}
