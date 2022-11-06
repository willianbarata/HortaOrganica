using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HortaOrganicaWebApp.Areas.App.Controllers
{
    [Area("App")]
    [Authorize]
    public class AppController : Controller
    {

    }
}
