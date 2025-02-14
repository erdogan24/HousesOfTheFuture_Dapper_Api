﻿using HousesOfTheFuture_Dapper_UI.DTOS.AppUserDtos;
using HousesOfTheFuture_Dapper_UI.DTOS.PropertyImageDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HousesOfTheFuture_Dapper_UI.ViewComponents.PropertySingle
{
    public class _PropertyAppUserComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PropertyAppUserComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44314/api/AppUsers?id=1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetAppUserByProductIdDto>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
