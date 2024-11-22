using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebShop2.DAL.Models;
using WebShop2.Models;

namespace WebShop2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebShop2Context _db;

        public HomeController(ILogger<HomeController> logger, WebShop2Context db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //Create
            var kategorija = new Kategorija { Naziv = "Racunarska oprema 1" };
            _db.Kategorijas.Add(kategorija);

            //Update
            //var kategorija = _db.Kategorijas.Single(k => k.Id == 1);
            //kategorija.Naziv = "Racunarske periferije";

            //Delete
            //var kategorija = _db.Kategorijas.Single(k => k.Id == 1);
            //_db.Kategorijas.Remove(kategorija);

            _db.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
