﻿using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
