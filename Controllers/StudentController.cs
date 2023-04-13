using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolLibraryManagment.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLibraryManagment.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly LibraryDbContext _Db;

        public StudentController(LibraryDbContext Db)
        {
            _Db = Db;

        }

        public IActionResult StudentList()
        {
            return View(_Db.tblStudent.ToList());
        }

        public async Task<IActionResult> AddStudent(StudentEntity obj)
        {
            return View(obj);
        }

        public async Task<IActionResult> SaveStudent(StudentEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.StudentId == 0)
                    {
                        _Db.tblStudent.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("StudentList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("StudentList");
            }
        }

        public async Task<IActionResult> DeleteStudent(int StudentId)
        {
            try
            {
                var item = await _Db.tblStudent.FindAsync(StudentId);
                if (item != null)
                {
                    _Db.tblStudent.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("StudentList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("StudentList");
            }
        }

    }
}
