using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
  public class Team
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string LogoString { get; set; }
    public string CarString { get; set; }

    public Team(int id, string name, string logoName, string carName)
    {
      Id = id;
      Name = name;
      LogoString = logoName;
      CarString = carName;
    }
  }
}
