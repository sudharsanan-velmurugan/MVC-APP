using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class DepreciationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calculate(DepreciationModel dm)
        {
            if(dm == null)
            {
                return View("index",dm);
            }
            return View(dm);
        }
    }
}
