using Microsoft.AspNetCore.Mvc;

namespace FirstMvc.Controllers
{
    public class DataExchange : Controller
    {
        [HttpGet("/dataex")]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Username", "meena@kpmg.com");
            return View("Index");
        }
        [HttpGet("/next")]
        public IActionResult NextPage()
        {
            ViewBag.User = HttpContext.Session.GetString("Username");
            return View("NextPage");
        }
    }
}
