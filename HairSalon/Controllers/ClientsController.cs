using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http.Features;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {

    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db) 
    {
      _db = db;
    }

    public ActionResult Index()
    {
    List<Client> model = _db.Clients.ToList();
    ViewBag.PageTitle = "View All Stylist";
    return View(model);
    }

    public ActionResult Create(int id)
    {
      ViewBag.Stylists = new SelectList(_db.Stylists, "StylistId", "FirstName", id);
      ViewBag.StylistId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients
                        .Include(client => client.StylistId)
                        .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
        Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
        _db.Clients.Update(client);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        _db.Clients.Remove(thisClient);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    
  }
}