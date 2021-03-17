using NUnit.Framework;
using WebApiService.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiService.Common;
using WebApiService.Model;
using Microsoft.AspNetCore.Mvc;

namespace Constroller.Tests
{
    [TestFixture()]
    public class EmployeeControllerTests
    {
        private readonly IEmployeeData employee;

        EmployeeControllerTests(IEmployeeData emp)
        {
            this.employee = emp;
        }

        [Test()]
        public void DeleteEmployeeTest()
        {


            //Arrange  
            var controller = new EmployeesController(employee);
            //var postId = 2;

            //Act  
            var data =  controller.DeleteEmployee(Guid.NewGuid());

            //Assert  
          //  Assert.AreEqual(OkResult,data.ExecuteResultAsync().Status>(data);


        }
    }
}