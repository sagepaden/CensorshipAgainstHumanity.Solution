using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CAH.Controllers
{
    public class BlackCardsController : Controllers
    {
        private readonly CAHContext _db;
        public BlackCardsController (CAHContext db)
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
