using HousesOfTheFuture_Dapper_Api.Dtos.ChartDtos;

namespace HousesOfTheFuture_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public interface IChartRepository
    {
      Task<List<ResultChartDto>> Get5CityForChart();
    }
}
