using System.Collections.Generic;

namespace Factory.Models
{
  public class HomeViewModel
  {
    public List<Engineer> Engineers { get; set; }
    public List<Machine> Machines { get; set; }

    public HomeViewModel()
    {
      this.Engineers = new List<Engineer>();
      this.Machines = new List<Machine>();
    }
  }
}