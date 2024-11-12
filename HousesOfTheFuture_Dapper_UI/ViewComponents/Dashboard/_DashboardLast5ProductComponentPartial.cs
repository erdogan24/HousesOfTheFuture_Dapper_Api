using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_UI.ViewComponents.Dashboard
{
    public class _DashboardLast5ProductComponentPartial:ViewComponent
    {
        public async  Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
