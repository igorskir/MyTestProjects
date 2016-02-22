using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace DataAccessLayer
{
    public interface IDepartmentRepository : IGenericDataRepository<Department>
    {
    }

    public interface IEmployeeRepository : IGenericDataRepository<Employee>
    {
    }

    public class DepartmentRepository : GenericDataRepository<Department>, IDepartmentRepository
    {
    }

    public class EmployeeRepository : GenericDataRepository<Employee>, IEmployeeRepository
    {
    }
}
