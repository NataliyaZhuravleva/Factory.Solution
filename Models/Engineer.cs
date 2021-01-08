using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Ingineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }
    public int EngineerId{get;set;}
    public string EngineerFirstName{get;set;}
    public string EngineerLastName{get;set;}
    public ICollection<EngineerMachine> Machines{get;}
  }
}
