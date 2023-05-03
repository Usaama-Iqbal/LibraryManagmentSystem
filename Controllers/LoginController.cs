using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolLibraryManagment.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLibraryManagment.Controllers
{
    public class LoginController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}


        private readonly LibraryDbContext _Db;

        public LoginController(LibraryDbContext Db)
        {
            _Db = Db;

        }

        public IActionResult LoginList()
        {
            return View(_Db.tblLogin.ToList());
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Validate the username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError(string.Empty, "Username and password are required.");
                return View();
            }

            // Authenticate the user
            if (AuthenticateUser(username, password))
            {
                // Redirect to the dashboard if the user is authenticated
                return RedirectToAction("BookList", "Book");
            }

            // Display an error message if the authentication failed
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return RedirectToAction("LoginList", "Login");
            //return View();
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Replace this with your actual authentication logic
            var user = _Db.tblLogin.FirstOrDefault(u => u.UserName == username && u.Passward == password);
            if (user != null)
            {
                // Authentication succeeded
                return true;
            }

            // Authentication failed
            return false;
        }




        public async Task<IActionResult> AddLogin(Login obj)
        {
            return View(obj);
        }

        public async Task<IActionResult> SaveLogin(Login obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.UserId == 0)
                    {
                        _Db.tblLogin.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("LoginList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("LoginList");
            }
        }

        public async Task<IActionResult> DeleteLogin(int UserId)
        {
            try
            {
                var item = await _Db.tblLogin.FindAsync(UserId);
                if (item != null)
                {
                    _Db.tblLogin.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("LoginList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("LoginList");
            }
        }

    }
}
