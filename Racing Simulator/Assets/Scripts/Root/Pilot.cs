using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
  [Serializable]
  public class Pilot
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string PilotString { get; set; }
    public int Age { get; set; }
    public int Over { get; set; }
    public int Points { get; set; }
    public int points { get; set; }
    public int Title { get; set; }
    public int Wins { get; set; }
    public int SeasonScore { get; set; }

    // Constructor
    public Pilot(int id, string name, string country, string faceString, int age, int over, int title, int wins)
    {
      Id = id;
      Name = name;
      Country = country;
      PilotString = faceString;
      Age = age;
      Over = over;
      Title = title;
      Wins = wins;
    }

    public void SetPoints(int points)
    {
      Points = points;
    }
    public void AddSeasonScore(int add_amount)
    {
      SeasonScore += add_amount;
    }
  }
}
