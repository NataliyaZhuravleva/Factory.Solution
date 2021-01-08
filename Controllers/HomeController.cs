using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index()
    {
      HomeViewModel model = new HomeViewModel();
      model.Engineers = _db.Engineers.ToList();
      model.Machines = _db.Machines.ToList();
      return View(model);
    }
  }
}