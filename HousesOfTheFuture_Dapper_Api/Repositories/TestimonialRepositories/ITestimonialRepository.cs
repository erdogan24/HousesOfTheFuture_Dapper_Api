using HousesOfTheFuture_Dapper_Api.Dtos.TestimonialDtos;

namespace HousesOfTheFuture_Dapper_Api.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
       
    }
}
