using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using KonusarakOgrenExamProject.Data;
using KonusarakOgrenExamProject.Models;
using KonusarakOgrenExamProject.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgrenExamProject.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    dbContext.Database.EnsureCreated();

                    #region AddUser
                    

                    if (dbContext.UserModels.Where(x => x.Username.Equals("erdemkivanc") && x.Password.Equals("12345")).FirstOrDefault() == null)
                    {
                        dbContext.Add(new UserModel()
                        {
                            Username = "erdemkivanc",
                            Password = "12345",
                            IsActive = true,
                            IsAdmin = true,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            UpdatedUsername = "erdemkivanc"
                        });

                        dbContext.SaveChanges();
                    }
                    #endregion

                    UserModel user = dbContext.UserModels.
                   Where(x => x.Username.Equals(loginModel.Username)
                   && x.Password.Equals(loginModel.Password))
                   .FirstOrDefault();

                    if (user != null)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, loginModel.Username)
                        };

                        var claimsIdentity = new ClaimsIdentity(claims, "login");

                        ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(principal);

                        return RedirectToAction("List", "Exam");
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "Kullanıcı adı veya şifre yanlış!");
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}