using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
  public class Car
  {
    public int Power { get; set; }
    public int Aerodynamics { get; set; }
    public int Durability { get; set; }
    public int Chassis { get; set; }

    public Car(int power, int aero, int dura, int chass)
    {
      Power = power;
      Aerodynamics = aero;
      Durability = dura;
      Chassis = chass;
    }

    public int Pit_stop(int volta) // Função para selecionar a volta do Pit-Stop
    {
      return volta;
    }
  }
}
