using Dapper;
using HousesOfTheFuture_Dapper_Api.Dtos.MessageDtos;
using HousesOfTheFuture_Dapper_Api.Models.DapperContext;

namespace HousesOfTheFuture_Dapper_Api.Repositories.MessageRepositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id)
        {
            string query = "Select Top(3) * From Message Where Receiver=@receiverId order by MessageId Desc ";
            var parameters = new DynamicParameters();
            parameters.Add("@receiverId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultInBoxMessageDto>(query, parameters);
                return values.ToList();
            }

        }
    }
}
