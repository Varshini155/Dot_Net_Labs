using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        [HttpGet("/str/get")]
        public IActionResult GetStr()
        {
            return Ok(_actions);
        }

        // Small Database
        private static List<string> _actions = new List<string>();

        [HttpPost("/str/insert")]
        public IActionResult InsertStr([FromBody] string str)
        {
            if (str == "none")
            {
                return BadRequest("none is not allowed");
            }
            _actions.Add(str);
            return Created("/str/insert", $"{str} added successfully");
        }



        [HttpPut("/str/update/{oldStr}")]
        public IActionResult UpdateStr([FromRoute] string oldStr, [FromBody] string newStr)
        {
            string? foundStr = _actions.Where((s) => { return s == oldStr; }).ToList().FirstOrDefault();

            if(foundStr ==null || foundStr == "")
            {
                return NotFound();
            }
            //update the string
            foundStr = newStr;

            return NoContent();
        }

        [HttpDelete("/str/delete/{strToRemove}")]
        public IActionResult RemoveStr([FromRoute] string strToRemove)
        {
            bool isSuccessful =_actions.Remove(strToRemove);
            if (isSuccessful == true)
            {
                return Ok($"Deletion successfull for {strToRemove}");
            }
            else
            {
                return NotFound();
            }
        }

            
    }
}
