using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
