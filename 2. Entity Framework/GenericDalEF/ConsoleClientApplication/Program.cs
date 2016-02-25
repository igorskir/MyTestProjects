﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DomainModel;

namespace ConsoleClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessLayer businessLayer = new BuinessLayer();

            Department itDep = new Department() { Name = "IT" };
            Department salesDep = new Department() { Name = "Sales" };
            Department marketing = new Department() { Name = "Marketing" };
            businessLayer.AddDepartment(itDep, salesDep, marketing);

            Console.WriteLine("Existing departments:");
            IList<Department> departments = businessLayer.GetAllDepartments();
            foreach (var department in departments)
            {
                Console.WriteLine("{0} - {1}", department.DepartmentId, department.Name);
            }

            Employee employee = new Employee()
            {
                FirstName = "Magnus",
                LastName = "Montin",
                DepartmentId = itDep.DepartmentId
            };

            Employee employeeIgor = new Employee()
            {
                FirstName = "Igor",
                LastName = "Skirnevskiy",
                DepartmentId = itDep.DepartmentId
            };

            businessLayer.AddEmployee(employee);
            businessLayer.AddEmployee(employeeIgor);

            itDep = businessLayer.GetDepartmentByName("IT");
            if (itDep != null)
            {
                Console.WriteLine("Employees at the {0} department: ", itDep.Name);
                foreach (var emp in itDep.Employees)
                {
                    Console.WriteLine("{0} {1}", emp.LastName, emp.FirstName);
                }
            }

            Console.WriteLine("Employees into {0} department:",itDep.Name);
            var employees = businessLayer.GetEmployeesByDepartmentName("IT");
            foreach (var emp in employees)
            {
                Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);
            }

            itDep.Name = "IT Department";
            businessLayer.UpdateDepartment(itDep);

            itDep.Employees.Clear();
            businessLayer.RemoveEmployee(employee);
            businessLayer.RemoveEmployee(employeeIgor);

            //* Remove departments*/
            businessLayer.RemoveDepartment(itDep, salesDep, marketing);

            Console.ReadLine();
        }
    }
}
