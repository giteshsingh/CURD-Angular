using Microsoft.AspNetCore.Cors;
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

    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentData _departmentdata;
        public DepartmentController(IDepartmentData department)
        {
            _departmentdata = department;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetDepartments()
        {
            return Ok(_departmentdata.GetDepartments());
        }



        [HttpGet]
        [Route("api/[controller]/{id}")]
        public ActionResult Details(int id)
        {
            var department = _departmentdata.GetDepartment(id);
            if (department != null)
            {
                return Ok(department);
            }
            return NotFound($"Department with id {id} is not found");
        }


        [HttpPost]
        [Route("api/[controller]")]
       
        public ActionResult Create(Department dep)
        {
            var department = _departmentdata.AddDepartment(dep);

            return Ok(department);
            //return Created(HttpContext.Request.Scheme + "://" +
            //    HttpContext.Request.Host + HttpContext.Request.Path + "/"
            //    + department.DepartmentId, department);
        }




        // POST: DepartmentController/Edit/5
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditDepartment(Department department)
        {
            var existingDepart = _departmentdata.GetDepartment(department.DepartmentId);
            if (existingDepart != null)
            {
                department.DepartmentId = existingDepart.DepartmentId;
                _departmentdata.EditDepartment(department);
                return Ok(department);

            }
            return NotFound($"Department with id {department.DepartmentId} is not found");
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
       
        public IActionResult DeleteDepartment(int id)
        {
            var department = _departmentdata.GetDepartment(id);
            if (department != null)
            {
                _departmentdata.DeleteDepartment(department);
                return Ok();

            }
            return NotFound($"Department with id {id} is not found");
        }

    }
}
