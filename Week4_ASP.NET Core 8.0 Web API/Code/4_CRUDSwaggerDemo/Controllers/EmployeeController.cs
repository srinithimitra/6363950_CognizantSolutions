using _4_CRUDSwaggerDemo.Filters;
using _4_CRUDSwaggerDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4_CRUDSwaggerDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees;

       
        static EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

    
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

   
        [HttpGet("standard")]
        public ActionResult<Employee> GetStandard()
        {
            return Ok(GetStandardEmployeeList()[0]);
        }

   
        [HttpPost]
        public ActionResult Post([FromBody] Employee emp)
        {
            employees.Add(emp);
            return Ok(emp);
        }

       
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> Put(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
            {
                return BadRequest("Invalid employee id");
            }

         
            emp.Name = updatedEmp.Name;
            emp.Salary = updatedEmp.Salary;
            emp.Permanent = updatedEmp.Permanent;
            emp.Department = updatedEmp.Department;
            emp.Skills = updatedEmp.Skills;
            emp.DateOfBirth = updatedEmp.DateOfBirth;

            return Ok(emp);
        }

    
        private static List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Sample Name",
                    Salary = 0,
                    Permanent = true,
                    DateOfBirth = DateTime.Today,
                    Department = new Department { Id = 1, Name = "Sample Dept" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Skill1" },
                        new Skill { Id = 2, Name = "Skill2" }
                    }
                }
            };
        }
    }
}
