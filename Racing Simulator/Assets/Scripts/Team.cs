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
    public string LogoName { get; set; }
    public string CarName { get; set; }

    public Team(int id, string name, string logoName, string carName)
    {
      Id = id;
      Name = name;
      LogoName = logoName;
      CarName = carName;
    }
  }
}
