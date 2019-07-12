using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Web.App.App_Start;

namespace Web.App.Controllers
{
    [CamelCaseJsonOutput]
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _EmployeeService;

        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetEmployees()
        {
            var list = await _EmployeeService.GetEmployeesAsync();

            return Ok(list);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetEmployees(int id)
        {
            var employee = await _EmployeeService.GetEmployeeAsync(id);

            return Ok(employee);
        }
    }
}
