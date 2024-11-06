using HousesOfTheFuture_Dapper_Api.Dtos.CategoryDtos;
using HousesOfTheFuture_Dapper_Api.Dtos.EmployeeDtos;
using HousesOfTheFuture_Dapper_Api.Repositories.CategoryRepository;
using HousesOfTheFuture_Dapper_Api.Repositories.EmployeeRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployeeAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            _employeeRepository.CreateEmployee(createEmployeeDto);
            return Ok("Personel Başarılı Bir Şekilde Eklendi ");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeey(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok("Personel başarılı bir şekilde Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDto);
            return Ok("Personel Başarıyla Güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = await  _employeeRepository.GetEmployee(id);
            return Ok(value);
        }
    }
}
