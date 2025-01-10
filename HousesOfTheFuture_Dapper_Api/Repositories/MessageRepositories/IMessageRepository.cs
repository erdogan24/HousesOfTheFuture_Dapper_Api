using HousesOfTheFuture_Dapper_Api.Dtos.MessageDtos;

namespace HousesOfTheFuture_Dapper_Api.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInBoxMessageDto>>GetInBoxLast3MessageListByReceiver(int id);
    }
}
