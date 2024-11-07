using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {   
        private readonly IHttpClientFactory _httpClientFactory;
        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task< IActionResult> Index()
        {

            #region İstatistik1
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44314/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region İstatistik2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44314/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData2;
            #endregion

            #region İstatistik3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44314/api/Statistics/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = jsonData3;
            #endregion

            #region İstatistik4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44314/api/Statistics/AverageProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceByRent = jsonData4;
            #endregion

            #region İstatistik5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44314/api/Statistics/AverageProductPriceBySale");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData5;
            #endregion

            #region İstatistik6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44314/api/Statistics/AverageRoomCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsonData6;
            #endregion

            #region İstatistik7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44314/api/Statistics/CategoryCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData7;
            #endregion

            #region İstatistik4
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44314/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData8;
            #endregion


            return View();
        }
    }
}
