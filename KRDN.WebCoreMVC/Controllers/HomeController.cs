
using KRDN.IDAL;
using KRDN.WebCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KRDN.WebCoreMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserDal _userDal;
        public HomeController(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IActionResult Index()
        {
            var user = _userDal.GetUser(1);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}