using FirstAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDbController : ControllerBase
    {
        FirstApiContext context = null;
        public EmployeeDbController(FirstApiContext ctx)
        {
            context = ctx;
        }
    
        [HttpPost("/insert")]
        public IActionResult InsertEmp([FromBody] Employee emp)
        {
            context.Employees.Add(emp); 
            context.SaveChanges();
            return Created("/insert",emp);
        }

        [HttpGet("/all")]
        public IActionResult GetEmp()
        {
           return Ok(context.Employees.ToList());
        }
    }
}
