using BlazorProject.Data.Contexts;
using BlazorProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorProject.Data.Repositories
{
    
        public class EmployeesRepository : IEmployeeRepository
    {
            private readonly CalendarEventContext _EmployeeContext;

            public EmployeesRepository(CalendarEventContext calendarEventContext)
            {
                _EmployeeContext = calendarEventContext;
            }

            public IEnumerable<Employees> GetAllEmployees()
            {
                return _EmployeeContext.Employee;
            }

            public Employees GetEmployeeById(int employeeId)
            {
                return _EmployeeContext.Employee.FirstOrDefault(c => c.Id == employeeId);
            }

            public Employees AddEmployee(Employees employee)
            {
                var addedEntity = _EmployeeContext.Employee.Add(employee);
                _EmployeeContext.SaveChanges();
                return addedEntity.Entity;
            }

            public Employees UpdateEmployee(Employees employee)
            {
                var foundEmployee = _EmployeeContext.Employee.FirstOrDefault(e => e.Id == employee.Id);

                if (foundEmployee != null)
                {
                                 
                    foundEmployee.FirstName = employee.FirstName;
                    foundEmployee.LastName = employee.LastName;                   

                    _EmployeeContext.SaveChanges();

                    return foundEmployee;
                }

                return null;
            }

            public void DeleteEmployee(int employeeId)
            {
                var foundEmployee = _EmployeeContext.Employee.FirstOrDefault(e => e.Id == employeeId);
                if (foundEmployee == null) return;

                _EmployeeContext.Employee.Remove(foundEmployee);
                _EmployeeContext.SaveChanges();
            }
        }
    }

