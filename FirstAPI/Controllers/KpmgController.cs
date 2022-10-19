using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oops;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KpmgController : ControllerBase
    {
        [HttpGet("/kpmg/get")]
        public IActionResult GetStr()
        {
            return Ok(_actions);
        }
     
      

        // Small Database
        private static List<KpmgEmployee> _actions = new List<KpmgEmployee>();

        [HttpPost("/kpmg/insert")]
        public IActionResult InsertStr([FromBody] KpmgEmployee str)
        {
            if (str == null)
            {
                return BadRequest("none is not allowed");
            }
            _actions.Add(str);
            return Created("/str/insert", $"{str.Name} added successfully");
        }



        [HttpPut("/kpmg/update/{empId}")]
        public IActionResult UpdateStr([FromRoute] int empId, [FromBody] KpmgEmployee newStr)
        {
            KpmgEmployee? foundStr = _actions.Where((s) => { return s.EmpId == empId; })
                .ToList()
                .FirstOrDefault();

            if (foundStr == null)
            {
                return NotFound();
            }
            //update the string
            foundStr.Name = newStr.Name;
            foundStr.Designation = newStr.Designation;

            return NoContent();
        }

        [HttpDelete("/kpmg/delete/{empId}")]
        public IActionResult RemoveStr([FromRoute] int empId)
        {
            KpmgEmployee foundEmp = _actions.Where((emp) => { return emp.EmpId == empId; }).FirstOrDefault();

            bool isSuccessful = _actions.Remove(foundEmp);
            if (isSuccessful == true)
            {
                return Ok($"Deletion successfull for {empId}");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
