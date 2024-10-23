using HousesOfTheFuture_Dapper_Api.Dtos.CategoryDtos;
using HousesOfTheFuture_Dapper_Api.Models.DapperContext;
using Dapper;
namespace HousesOfTheFuture_Dapper_Api.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName, CategoryStatus) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName",categoryDto.)
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * From Category ";
            using (var connection = _context.CreateConnection()) {
                var values =await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
        }
        }
    }
}