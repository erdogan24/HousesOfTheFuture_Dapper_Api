﻿using HousesOfTheFuture_Dapper_Api.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousesOfTheFuture_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        [HttpGet]
        public async Task< IActionResult> GetServiceList()
        { 
            var value = await _serviceRepository.GetAllServiceAsync();
            return Ok(value);
        }
    }
}