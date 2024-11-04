using HousesOfTheFuture_Dapper_Api.Dtos.BottomGridDtos;
using HousesOfTheFuture_Dapper_Api.Dtos.ServiceDtos;

namespace HousesOfTheFuture_Dapper_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
