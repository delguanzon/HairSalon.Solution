using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
    public class ClientController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}