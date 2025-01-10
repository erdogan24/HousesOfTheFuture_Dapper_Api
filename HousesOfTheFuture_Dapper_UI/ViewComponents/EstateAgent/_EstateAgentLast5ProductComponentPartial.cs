using HousesOfTheFuture_Dapper_UI.DTOS.EstateAgentDtos;
using HousesOfTheFuture_Dapper_UI.DTOS.ProductDtos;
using HousesOfTheFuture_Dapper_UI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HousesOfTheFuture_Dapper_UI.ViewComponents.EstateAgent
{
    public class _EstateAgentLast5ProductComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;

        public _EstateAgentLast5ProductComponentPartial(IHttpClientFactory httpClientFactory, ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserId;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44314/api/EstateAgentLastProducts?id="+ id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5ProductWithCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
