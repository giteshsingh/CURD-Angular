using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Common;
using WebApiService.Database;
using WebApiService.Model;

namespace WebApiService.DAL
{
    public class SQLDepartmentData : IDepartmentData
    {
        private EmployeeContext _employeeContext;

        public SQLDepartmentData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public Department AddDepartment(Department department)
        {            
            _employeeContext.Add(department);
            _employeeContext.SaveChanges();
            return department;
        }

        public void DeleteDepartment(Department department)
        {
            _employeeContext.Department.Remove(department);
            _employeeContext.SaveChanges();
        }

        public Department EditDepartment(Department department)
        {
            var existing = _employeeContext.Department.FirstOrDefault(x => x.DepartmentId == department.DepartmentId);
            if (existing != null)
            {
                existing.DepartmentName = department.DepartmentName;
                _employeeContext.Department.Update(existing);
                _employeeContext.SaveChanges();
            }

            return department;
        }

        public Department GetDepartment(int id)
        {
            var department = _employeeContext.Department.Find(id);
            return department;
        }

        public List<Department> GetDepartments()
        {
            return _employeeContext.Department.ToList();
        }
    }
}
