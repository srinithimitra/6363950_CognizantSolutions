using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace SwaggerDemo.Controllers
{
    [ApiController]
    [Route("api/employee")] // Accessible at /api/employee
    public class EmployeeController : ControllerBase
    {
        static List<string> employees = new List<string> { "Alice", "Bob", "Charlie" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(employees);
        }
    }
}
