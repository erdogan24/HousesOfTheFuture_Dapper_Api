﻿using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultOurClientsComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
               return View();
        }
    }
}
