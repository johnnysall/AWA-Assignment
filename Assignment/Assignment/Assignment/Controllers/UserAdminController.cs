using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAA.Services.Models;
using NAA.Services.IService;
using NAA.Services.Service;
using System.Data.Entity;
using NAA.Data.DAO;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using NAA.Controllers;

namespace NAA.Controllers
{
    public class UserAdminController : Controller
    {
        IUserService userService;
        public UserAdminController()
        {
            userService = new UserService();
        }

        // GET: UserAdmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserAdmin/Create
        public ActionResult AddUser()
        {
            return View();
        }

        // POST: UserAdmin/Create
        [HttpPost]
        public ActionResult AddUser(UserProfile userProfile)
        {
            try
            {
                userService.AddUser(userProfile);
                return RedirectToAction("GetUser", "User",
                new { userId = "john" });
            }
            catch
            {
                return View();
            }
        }

        // GET: UserAdmin/Edit/5
        public ActionResult UpdateUser(string userId)
        {
            UserProfile userProfile = new UserProfile();
            User user = userService.GetUser(userId);

            userProfile.Name = user.Name;
            userProfile.Address = user.Address;
            userProfile.Phone = user.Phone;
            userProfile.Email = user.Email;

            return View(userProfile);
        }

        // POST: UserAdmin/Edit/5
        [HttpPost]
        public ActionResult UpdateUser(string userId, UserProfile userProfile)
        {
            try
            {
                userService.UpdateUser(userProfile, "john");
                return RedirectToAction("GetUser", "User",
                new { userId = "john" });
            }
            catch
            {
                return View();
            }
        }

        // GET: UserAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
