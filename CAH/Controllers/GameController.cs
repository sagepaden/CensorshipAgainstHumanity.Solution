using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CAH.Controllers
{
    public class GameController : Controllers
    {
        private readonly CAHContext _db;
        public GameController (CAHContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {

        }
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
