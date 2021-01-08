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
      List<Engineer> engineers = _db.Engineers.ToList();
      List<Machine> machines = _db.Machines.ToList();
      List<List<EngineerMachine>> model = new List<List<EngineerMachine>>(engineers, machines);
      return View(model);
    }
  }
}