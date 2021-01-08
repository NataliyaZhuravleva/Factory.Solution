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
    public int MachineId { get; set; }
    public string MachineBrandName { get; set; }
    public string MachineModelName { get; set; }
    public string MachineProductionYear { get; set; }
    public string MachineSerialNumber { get; set; }
    [DisplayName("DateOfMachineInspection")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime DateOfMachineInspection { get; set; }

    public ICollection<EngineerMachine> Engineers { get; }
  }
}
