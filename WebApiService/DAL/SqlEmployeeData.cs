using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Common;
using WebApiService.Database;
using WebApiService.Model;

namespace WebApiService.DAL
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _employeeContext;
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.id = Guid.NewGuid();
            _employeeContext.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();


        }

        public Employee EditEmployee(Employee employee)
        {
            var existing = _employeeContext.Employees.FirstOrDefault(x=>x.id== employee.id);
            if(existing!=null)
            {
                existing.name = employee.name;
                _employeeContext.Employees.Update(existing);
                _employeeContext.SaveChanges();
            }
            
            return employee;
        }

        public Employee GetEmployee(Guid id)
        {
            var employee = _employeeContext.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }
    }
}
