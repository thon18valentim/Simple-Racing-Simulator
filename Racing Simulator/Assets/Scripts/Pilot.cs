using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
  public class Pilot
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public int Age { get; set; }
    public int Over { get; set; }

    // Constructor
    public Pilot(int id, string name, string country, int age, int over)
    {
      Id = id;
      Name = name;
      Country = country;
      Age = age;
      Over = over;
    }
  }
}
