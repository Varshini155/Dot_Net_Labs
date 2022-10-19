using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oops;
using System.ComponentModel;
using System.Xml.Linq;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    
    public class simpleController : ControllerBase
    {
        [EnableCors("AllowOrigin")]
        [HttpGet("/Greet")]

        public string Greeting(string pName)
        {
            return $"hello {pName}";
        }

        [HttpGet("/allNames")]
        public List<string> AllNames()
        {
            List<string> names = new List<string>() { "Eena", "Meena", "Deeka" };
            return names;
        }

        [HttpGet("/kpmgEmployee")]
        public List<KpmgEmployee> GetAllEmployees()
        {
            List<KpmgEmployee> kpmgEmployee = new List<KpmgEmployee>();
            kpmgEmployee.Add(new KpmgEmployee() { EmpId = 1001, Name = "Mayur", Designation = "Analyst" });
            kpmgEmployee.Add(new KpmgEmployee() { EmpId = 1001, Name = "Varshini", Designation = "Analyst" });
            kpmgEmployee.Add(new KpmgEmployee() { EmpId = 1001, Name = "Sanjay", Designation = "Analyst" });
            kpmgEmployee.Add(new KpmgEmployee() { EmpId = 1001, Name = "shipla", Designation = "Analyst" });

            return kpmgEmployee;
        }


        [HttpGet("/employee/search/{pName}")]

        public List<KpmgEmployee> SearchEmployee([FromRoute] string pName)
        {
            List<KpmgEmployee> allEmps = GetAllEmployees();
            return allEmps.Where((emp) => { return emp.Name == pName; }).ToList();
        }

        [HttpGet("/employee/search/{mName}/{role}")]

        public List<KpmgEmployee> SearchEmp([FromRoute] string mName, string role)
        {
            List<KpmgEmployee> AllEmp = GetAllEmployees();
            return AllEmp.Where((emp) => { return emp.Name.Contains("i") && emp.Designation == role; }).ToList();
        }

        [HttpGet("/IAction")]
        public IActionResult GetUsingIAction()
        {
            List<KpmgEmployee> kpmgEmployee = new List<KpmgEmployee>();
            kpmgEmployee.Add(new KpmgEmployee() { EmpId = 1001, Name = "Mayur", Designation = "Analyst" });
            kpmgEmployee.Add(new KpmgEmployee() { EmpId = 1001, Name = "Varshini", Designation = "Analyst"});
            kpmgEmployee.Add(new KpmgEmployee() { EmpId = 1001, Name = "Sanjay", Designation = "Analyst" });
            kpmgEmployee.Add(new KpmgEmployee() { EmpId = 1001, Name = "shipla", Designation = "Analyst" });

            return Ok(kpmgEmployee);

        }
    }
}
