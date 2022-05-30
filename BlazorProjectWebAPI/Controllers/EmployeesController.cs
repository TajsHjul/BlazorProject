using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorProject.Data.Contexts;
using BlazorProject.Models;
using BlazorProject.Data.Repositories;

namespace BlazorProjectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _EmployeesRepository;

        public EmployeesController(IEmployeeRepository EmployeesRepository)
        {
            _EmployeesRepository = EmployeesRepository;
        }

        [HttpGet]
        public IActionResult GetAllEmployeess()
        {
            return Ok(_EmployeesRepository.GetAllEmployeess());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeesById(int id)
        {
            return Ok(_EmployeesRepository.GetEmployeeById(id));
        }

        [HttpPost]
        public IActionResult CreateEmployees([FromBody] Employees Employees)
        {
            if (Employees == null)
                return BadRequest();

            if (Employees.FirstName == string.Empty || Employees.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdEmployees = _EmployeesRepository.AddEmployee(Employees);

            return Created("Employees", createdEmployees);
        }

        [HttpPut]
        public IActionResult UpdateEmployees([FromBody] Employees Employees)
        {
            if (Employees == null)
                return BadRequest();

            if (Employees.FirstName == string.Empty || Employees.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var EmployeesToUpdate = _EmployeesRepository.GetEmployeeById(Employees.Id);

            if (EmployeesToUpdate == null)
                return NotFound();

            _EmployeesRepository.UpdateEmployee(Employees);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployees(int id)
        {
            if (id == 0)
                return BadRequest();

            var EmployeesToDelete = _EmployeesRepository.GetEmployeeById(id);
            if (EmployeesToDelete == null)
                return NotFound();

            _EmployeesRepository.DeleteEmployee(id);

            return NoContent();//success
        }
    }
}
