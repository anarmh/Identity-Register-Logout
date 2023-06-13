using Microsoft.AspNetCore.Mvc;
using Molla_Register.Models;
using System.Diagnostics;

namespace Molla_Register.Controllers
{
    public class HomeController : Controller
    {
      

        public HomeController()
        {
          
        }

        public IActionResult Index()
        {
            return View();
        }

       
    }
}