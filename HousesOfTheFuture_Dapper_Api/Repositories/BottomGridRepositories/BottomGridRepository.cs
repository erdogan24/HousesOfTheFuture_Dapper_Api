using Dapper;
using HousesOfTheFuture_Dapper_Api.Dtos.BottomGridDtos;
using HousesOfTheFuture_Dapper_Api.Dtos.ProductDtos;
using HousesOfTheFuture_Dapper_Api.Dtos.ServiceDtos;
using HousesOfTheFuture_Dapper_Api.Models.DapperContext;

namespace HousesOfTheFuture_Dapper_Api.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {

        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }
      
        public async void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            string query = "insert into BottomGrid (Icon , Title, Description) values (@Icon,@Title, @Description)";
            var parameters = new DynamicParameters();

            parameters.Add("@Icon", createBottomGridDto.Icon);
            parameters.Add("@Title", createBottomGridDto.Title);
            parameters.Add("@Description", createBottomGridDto.Description);


            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGrid(int id)
        {
            string query = "Delete From BottomGrid Where BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            string query = "Select * From BottomGrid Where BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, parameters);
                return values;
            }
        }

        public void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}
