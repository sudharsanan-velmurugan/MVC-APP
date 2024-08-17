using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class SimpleInterestController : Controller
    {
        public IActionResult Index(SimpleInterestModel? si=null)
        {
            if(si==null)
            {
                si = new SimpleInterestModel()
                {
                    PrincipleAmount = 5000000,
                    RateOfInterest = 16,
                    YearsOfInvestment = 4,
                };
            }
            
            si.SimpleIntersest();

            return View(si);
        }
    }
}
