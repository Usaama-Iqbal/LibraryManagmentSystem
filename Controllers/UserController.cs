using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolLibraryManagment.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLibraryManagment.Controllers
{
    public class UserController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly LibraryDbContext _Db;

        public UserController(LibraryDbContext Db)
        {
            _Db = Db;

        }

        public IActionResult UserList()
        {
            return View(_Db.tblUser.ToList());
        }

        public async Task<IActionResult> AddUser(UserEntity obj)
        {
            return View(obj);
        }

        public async Task<IActionResult> SaveUser(UserEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.UserId == 0)
                    {
                        _Db.tblUser.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("UserList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("UserList");
            }
        }

        public async Task<IActionResult> DeleteUser(int UserId)
        {
            try
            {
                var item = await _Db.tblUser.FindAsync(UserId);
                if (item != null)
                {
                    _Db.tblUser.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("UserList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("UserList");
            }
        }
    }
}
