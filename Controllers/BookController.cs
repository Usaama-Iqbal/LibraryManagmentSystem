using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolLibraryManagment.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLibraryManagment.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly LibraryDbContext _Db;

        public BookController(LibraryDbContext Db)
        {
            _Db = Db;

        }

        public IActionResult BookList()
        {
            return View(_Db.tblBook.ToList());
        }

        public async Task<IActionResult> AddBook(BookEntity obj)
        {
            return View(obj);
        }

        public async Task<IActionResult> SaveBook(BookEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.BookId == 0)
                    {
                        _Db.tblBook.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("BookList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("BookList");
            }
        }

        public async Task<IActionResult> DeleteBook(int BookId)
        {
            try
            {
                var item = await _Db.tblBook.FindAsync(BookId);
                if (item != null)
                {
                    _Db.tblBook.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("BookList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("BookList");
            }
        }
    }
}
