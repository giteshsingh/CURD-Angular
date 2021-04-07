using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Model;

namespace WebApiService.Common
{
   public interface IDepartmentData
    {
        List<Department> GetDepartments();

        Department GetDepartment(int id);

        Department AddDepartment(Department department);
        void DeleteDepartment(Department department);

        Department EditDepartment(Department department);
    }
}
