using Microsoft.AspNetCore.Mvc;

namespace HortaOrganicaWebApp.Areas.App.Controllers
{

    public class HomeController : AppController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
