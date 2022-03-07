using BuyingHouseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuyingHouseApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            User auser = new User() {
            Id = 1,
            Name = "Jhone Doe",
            age = 35,
            Salary = 10000.0

            };
            return View(auser);
        }
    }
}