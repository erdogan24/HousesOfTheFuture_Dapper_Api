using Dapper;
using HousesOfTheFuture_Dapper_Api.Dtos.LoginDtos;
using HousesOfTheFuture_Dapper_Api.Models.DapperContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(CreateLoginDto loginDto)
        {

            string query = "Select * From AppUser Where Username=@username and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@username", loginDto.Username);
            parameters.Add("@password", loginDto.Password);
            using (var connection = _context.CreateConnection())
            {
                var values =await connection.QueryFirstOrDefaultAsync<CreateLoginDto>(query,parameters);
                if (values != null) {

                    return Ok("Başarılı");
                }
                else
                {
                    return Ok("Başarısız");
                }
            
            }
        }
    }
}
