using HousesOfTheFuture_Dapper_UI.DTOS.EstateAgentDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HousesOfTheFuture_Dapper_UI.ViewComponents.EstateAgent
{
    public class _EstateAgentDashboardChartComponentPartial:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;


        public _EstateAgentDashboardChartComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44314/api/EstateAgentChart");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultEstateAgentDashboardChartDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
