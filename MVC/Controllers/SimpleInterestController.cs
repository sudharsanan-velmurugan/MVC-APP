using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class SimpleInterestController : Controller
    {
        public IActionResult Index(SimpleInterestModel? si=null)
        {
            try
            {
                if (si == null)
                    si = new SimpleInterestModel();
                   
                si.SimpleIntersest();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;              
            }

            return View(si);
        }
    }
}
