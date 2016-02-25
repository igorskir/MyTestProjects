using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace BusinessLayer
{
    public interface IBusinessLayer
    {
        IList<Department> GetAllDepartments();
        Department GetDepartmentByName(string departmentName);
        void AddDepartment(params Department[] departments);
        void UpdateDepartment(params Department[] departments);
        void RemoveDepartment(params Department[] departments);

        IList<Employee> GetEmployeesByDepartmentName(string departmentName);
        void AddEmployee(Employee employee);
        void UpdateEmploee(Employee employee);
        void RemoveEmployee(Employee employee);
    }
}
