using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasGlobalTest.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MasGlobalTest.View.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;
        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await BusinessLayer.EmployeeBl.GetEmployeesAsync();
        }
        [HttpGet("{id}")]
        public async Task<IEnumerable<Employee>> Get(int id)
        {
            return await BusinessLayer.EmployeeBl.GetEmployeesAsync(id);
        }
    }
}
