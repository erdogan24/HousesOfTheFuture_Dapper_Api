namespace HousesOfTheFuture_Dapper_UI.DTOS.AppUserDtos
{
    public class GetAppUserByProductIdDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserImageUrl { get; set; }
    }
}
