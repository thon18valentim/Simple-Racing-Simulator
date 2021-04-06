using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Assets.Scripts
{
  [Serializable]
  public class Track
  {
    // Core Track Attributes
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string TrackString { get; set; }
    public int Laps { get; set; }
    public int Aerodynamics { get; set; }
    public int Power { get; set; }
    public int Durability { get; set; }
    public int Chassi { get; set; }

    // Constructor
    public Track(int id, string name, string country, int laps, int aero, int power, int dura, int chassi, string flagString)
    {
      Id = id;
      Name = name;
      Country = country;
      Laps = laps;
      Aerodynamics = aero;
      Power = power;
      Durability = dura;
      Chassi = chassi;
      TrackString = flagString;
    }
  }
}
