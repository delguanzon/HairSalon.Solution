using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
    public class ClientController : Controller
    {

      [HttpGet("/clients")]
      public ActionResult Index()
      {
        return View();
      }

    }
}