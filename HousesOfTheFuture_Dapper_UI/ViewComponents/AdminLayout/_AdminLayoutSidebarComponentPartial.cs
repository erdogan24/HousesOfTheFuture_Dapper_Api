using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
