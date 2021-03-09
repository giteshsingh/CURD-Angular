using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Common;
using WebApiService.Model;

namespace WebApiService.DAL
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                id= Guid.NewGuid(),
                name="Employee1"
            },
             new Employee()
            {
                id= Guid.NewGuid(),
                name="Employee2"
            },
              new Employee()
            {
                id= Guid.NewGuid(),
                name="Employee3"
            }
        };
        public Employee AddEmployee(Employee employee)
        {
            employee.id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.id);
            existingEmployee.name = employee.name;
            return existingEmployee;
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
