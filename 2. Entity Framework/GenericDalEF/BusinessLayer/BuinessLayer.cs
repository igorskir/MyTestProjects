using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DomainModel;

namespace BusinessLayer
{
    public class BuinessLayer : IBusinessLayer
    {
        private readonly IDepartmentRepository _depRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public BuinessLayer()
        {
            _depRepository = new DepartmentRepository();
            _employeeRepository = new EmployeeRepository();
        }
        public BuinessLayer(IDepartmentRepository deptRepository,
            IEmployeeRepository employeeRepository)
        {
            _depRepository = deptRepository;
            _employeeRepository = employeeRepository;
        }
        public IList<Department> GetAllDepartments()
        {
            return _depRepository.GetAll();
        }

        public Department GetDepartmentByName(string departmentName)
        {
           return _depRepository.GetSingle(d => d.Name.Equals(departmentName),
               d => d.Employees);
        }

        public void AddDepartment(params Department[] departments)
        {
            /* Validation and error handling omitted */
            _depRepository.Add(departments);
        }

        public void UpdateDepartment(params Department[] departments)
        {
            /* Validation and error handling omitted */
            _depRepository.Update(departments);
        }

        public void RemoveDepartment(params Department[] departments)
        {
            /* Validation and error handling omitted */
            _depRepository.Remove(departments);
        }

        public IList<Employee> GetEmployeesByDepartmentName(string departmentName)
        {
            return _employeeRepository.GetList(e => e.Department.Name.Equals(departmentName));
        }

        public void AddEmployee(Employee employee)
        {
            /* Validation and error handling omitted */
            _employeeRepository.Add(employee);
        }

        public void UpdateEmploee(Employee employee)
        {
            /* Validation and error handling omitted */
            _employeeRepository.Update(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            /* Validation and error handling omitted */
            _employeeRepository.Remove(employee);
        }
    }
}
