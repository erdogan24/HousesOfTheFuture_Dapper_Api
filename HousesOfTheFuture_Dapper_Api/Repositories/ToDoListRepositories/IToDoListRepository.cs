using HousesOfTheFuture_Dapper_Api.Dtos.ToDoListDtos;

namespace HousesOfTheFuture_Dapper_Api.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        void CreateToDoList(CreateToDoListDto toDoListDto);
        void DeleteToDoList(int id); 
        void UpdateToDoList(UpdateToDoListDto ToDoListDto);
        Task<GetByIDToDoListDto> GetToDoList(int id);
    }
}
