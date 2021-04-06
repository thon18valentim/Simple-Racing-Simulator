using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
  [Serializable]
  public class Team
  {
    // Corea Team Attributes
    public int Id { get; set; }
    public string Name { get; set; }
    public string LogoString { get; set; }
    public string CarString { get; set; }
    // Car Score
    public int Score { get; set; }
    // Lap Time var
    public float LapTime { get; set; }
    // Teams Champ points
    public int points { get; set; }
    // Setting Tyres vars
    public int pneu_id { get; set; }
    public int pneu_dura { get; set; }
    // Setting Car
    public Car Car { get; set; }
    // Setting Pilot
    public Pilot Pilot { get; set; }

    // Constructor
    public Team(int id, string name, string logoName, string carName, int pilotId)
    {
      Id = id;
      Name = name;
      LogoString = logoName;
      CarString = carName;
      Pilot = World.GetPilotById(pilotId);
      pneu_id = 30;
    }

    // Setting one pilot
    public void SetPilot(int id)
    {
      Pilot = World.GetPilotById(id);
    }

    // Setting current score
    public void SetScore(int score)
    {
      Score = score;
    }

    // Setting Current Lap Time
    public void SetLapTime(float time)
    {
      LapTime = time;
    }
  }
}
