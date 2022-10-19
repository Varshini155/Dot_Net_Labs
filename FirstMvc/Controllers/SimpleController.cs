using Microsoft.AspNetCore.Mvc;

namespace FirstMvc.Controllers
{
    public class SimpleController : Controller
    {

        [HttpGet("/simple")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/names")]
        public ActionResult DisplayNames()
        {
            return View("DisplayNames");
        }

        [HttpGet("/onLogin")]
        public IActionResult OnLogin(string username,string password)
        {
            if(username=="admin" && password=="nimda")
            {
                ViewBag.status = "Login Successful";
                return View("Index");

            }
            else
            {
                ViewBag.status = "Login Failed";
                return View("Index");
            }
        }
    }
}
