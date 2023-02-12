using Microsoft.AspNetCore.Mvc;
using RentierSuperApp.Data;
using RentierSuperApp.Models;

namespace RentierSuperApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
    