using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }
    public int MachineId{get;set;}
    public string MachineBrandName{get;set;}
    public string MachineModelName{get;set;}
    public string MachineSerialNumber{get;set;}
    public ICollection<EngineerMachine> Engineers{get;}
  }
}
