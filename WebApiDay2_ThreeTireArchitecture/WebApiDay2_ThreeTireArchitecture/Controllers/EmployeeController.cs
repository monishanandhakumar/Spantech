using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDay2_ThreeTireArchitecture.Services;
namespace WebApiDay2_ThreeTireArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository dbemployeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            dbemployeeRepository = employeeRepository;
        }

        /*   [HttpGet("{empid}")]
           public IActionResult GetEmpName(int empid)
           {
               var result = dbemployeeRepository.GetEmployeeById(empid);
               return Ok(result);
           }*/

        [HttpGet("{empid}")]
        public async Task<IActionResult> GetEmployeeName(int empid)
        {
            dynamic employee = await dbemployeeRepository.GetEmployeeByIdA(empid);

            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                //return NotFound(" No Employee data found !!!");
                return Ok(" No Employee data found !!!");
            }

        }


    }
}
