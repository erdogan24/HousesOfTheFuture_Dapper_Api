using Dapper;
using HousesOfTheFuture_Dapper_Api.Dtos.ContactDtos;
using HousesOfTheFuture_Dapper_Api.Models.DapperContext;

namespace HousesOfTheFuture_Dapper_Api.Repositories.ContactRepositories
{
    public class ContactRepository : IContactRepository
    {   
        private readonly  Context _context;
        public ContactRepository(Context context)
        {
            _context = context;
        }
        public void CreateContact(CreateContactDto createContactDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultContactDto>> GetAllContactAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIDContactDto> GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Last4ContactResultDto>> GetLast4Contact()
        {
            string query = "Select * From Contact ";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactResultDto>(query);
                return values.ToList();
            }
        }
    }
}
