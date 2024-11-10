using HousesOfTheFuture_Dapper_Api.Dtos.BottomGridDtos;
using HousesOfTheFuture_Dapper_Api.Dtos.PopularLocationDtos;
using HousesOfTheFuture_Dapper_Api.Dtos.PopularLocationDtos;

namespace HousesOfTheFuture_Dapper_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();

        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIDPopularLocationDto> GetPopularLocation(int id);

    }
}
