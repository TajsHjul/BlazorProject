using BlazorProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Data.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetAllEmployees();
        Employees GetEmployeeById(int employeeId);
        Employees AddEmployee(Employees employee);
        Employees UpdateEmployee(Employees employee);
        void DeleteEmployee(int employeeId);
       
    }
}
