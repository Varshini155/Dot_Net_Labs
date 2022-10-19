using Microsoft.AspNetCore.Mvc;

namespace FirstMvc.Controllers
{
    public class SimpleLabController : Controller
    {
        [HttpGet("/lab")]
        public IActionResult Index()
        {
            return View("");
        }
        [HttpGet("/getName")]
        public IActionResult getName()
        {
            ViewBag.Name = "Ankit";
            return View("Index");
        }
        [HttpGet("/getPlace")]
        public IActionResult getPlace()
        {
            ViewBag.Place = "Amritsar";
            return View("Index");
        }
        [HttpGet("/getAnimal")]
        public IActionResult getAnimal()
        {
            ViewBag.Animal = "Aane";
            return View("Index");
        }
        [HttpGet("/getThing")]
        public IActionResult getThing()
        {
            ViewBag.Thing = "Apple";
            return View("Index");
        }
    }
}
