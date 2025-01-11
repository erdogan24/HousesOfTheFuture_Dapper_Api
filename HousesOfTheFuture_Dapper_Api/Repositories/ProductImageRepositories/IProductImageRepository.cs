using HousesOfTheFuture_Dapper_Api.Dtos.ProductDetailDtos;
using HousesOfTheFuture_Dapper_Api.Dtos.ProductImageDtos;

namespace HousesOfTheFuture_Dapper_Api.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}
