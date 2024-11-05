using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
