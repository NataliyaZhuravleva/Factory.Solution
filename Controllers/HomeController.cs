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
    public class ViewModel
    {
      public List<Engineer> Engineers { get; set; }
      public List<Machine> Machines { get; set; }

      public ViewModel()
      {
        this.Engineers = new List<Engineer>();
        this.Machines = new List<Machine>();
      }
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewModel model = new ViewModel();
      model.Engineers = _db.Engineers.ToList();
      model.Machines = _db.Machines.ToList();
      return View(model);
    }
  }
}