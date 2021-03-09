using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Common;
using WebApiService.Model;

namespace WebApiService.Controllers
{
    
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employeeData;

        public EmployeesController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployees());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployeesId(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);
            if(employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee with id {id} is not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddEmployee(Employee emp)
        {
            var employee = _employeeData.AddEmployee(emp);
          
            return Created(HttpContext.Request.Scheme+"://"+
                HttpContext.Request.Host+HttpContext.Request.Path+"/"
                +employee.id,employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {           
            var employee = _employeeData.GetEmployee(id);
            if (employee != null)
            {
                _employeeData.DeleteEmployee(employee);
                return Ok();
                
            }
            return NotFound($"Employee with id {id} is not found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditEmployee(Guid id,Employee emp)
        {
            var existingemployee = _employeeData.GetEmployee(id);
            if (existingemployee != null)
            {
                emp.id = existingemployee.id;               
                _employeeData.EditEmployee(emp);
                return Ok(emp);

            }
            return NotFound($"Employee with id {id} is not found");
        }
    }
}
