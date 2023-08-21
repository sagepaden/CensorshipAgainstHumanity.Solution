using Microsoft.AspNetCore.Mvc;

namespace CAH.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}