using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
  public static Team team; // Player chosen team
  static Pilot pilot; // Player chosen pilot
  static Track track; // Currently track

  // Setting count vars
  int currentTrack = 0;
  int week = 0;
  int chosenPilot = 0;
  public int year = 2020;
  public int count_temporada = 0;

  private void Awake()
  {
    SetUpSingleton();
  }

  // Keep only one Game Session
  private void SetUpSingleton()
  {
    int numberGameSessions = FindObjectsOfType<GameSession>().Length;
    if (numberGameSessions > 1)
    {
      Destroy(gameObject);
    }
    else
    {
      DontDestroyOnLoad(gameObject);
    }
  }

  // Setting Current Season Year
  public void SetYear(int year_temp)
  {
    year = year_temp;
  }
  
  // Getting Current Year
  public int GetYear()
  {
    return year;
  }
  
  // Setting Current Season Count
  public void SetTemporada(int temporada)
  {
    count_temporada = temporada;
  }

  // Getting Current Season Count
  public int GetTemporada()
  {
    return count_temporada;
  }

  // Setting the player team
  public void SetPlayerTeam(int i)
  {
    team = new Team(World.teams[i].Id, World.teams[i].Name, World.teams[i].LogoString, World.teams[i].CarString, i)
    {
      Car = World.CreatePlayerCar()
    };
  }

  // Setting the player pilot
  public void SetPlayerPilot(int i)
  {
    pilot = new Pilot(World.pilots[i].Id, World.pilots[i].Name, World.pilots[i].Country, World.pilots[i].PilotString, World.pilots[i].Age, World.pilots[i].Over, World.pilots[i].Title, World.pilots[i].Wins);
    pilot.SetPoints(3);
    team.SetPilot(i + 1);
    World.SetPlayerTeam(team);
    chosenPilot = i;
  }

  // Setting Team Score
  public void SetTeamScore(int score)
  {
    team.Score = score;
  }

  // Setting Current Track
  public void SetCurrentTrack(int i)
  {
    currentTrack = i;
  }

  // Setting Current Week
  public void SetWeek(int i)
  {
    week = i;
  }

  // Getting player Team from Save Game File
  public void SetSavedPlayerTeam(Team player)
  {
    team = player;
  }

  // Getting Player Car
  public string GetPlayerCar()
  {
    return team.CarString;
  }

  // Getting player Pilot from Save Game File
  public void SetSavedPlayerPilot(Pilot player)
  {
    pilot = player;
  }

  // Getting Season Year
  public int GetSeasonYear()
  {
    return year;
  }

  // Getting Pilot Face
  public string GetPilotFaceString()
  {
    return team.Pilot.PilotString;
  }

  // Getting Pilot Titles count
  public int GetPilotTitle()
  {
    return team.Pilot.Title;
  }

  // Getting Pilot Wins count
  public int GetPilotWins()
  {
    return team.Pilot.Wins;
  }

  // Getting Pilot SeasonScore (Challenges)
  public int GetPilotSeasonScore()
  {
    return team.Pilot.SeasonScore;
  }

  // Getting Track String
  public string GetTrackString()
  {
    return track.TrackString;
  }

  // Getting Pilot Over
  public int GetPilotOver()
  {
    return team.Pilot.Over;
  }

  // Getting Player Team
  public Team GetPlayerTeam()
  {
    return team;
  }

  // Getting Player Pilot
  public Pilot GetPlayerPilot()
  {
    return pilot;
  }

  // Getting Pilot tyre
  public int GetPilotTyre()
  {
    return team.pneu_id;
  }

  // Getting Team Name
  public string GetTeamName()
  {
    return team.Name;
  }

  // Getting Pilot Current Age
  public int GetPilotAge()
  {
    return team.Pilot.Age;
  }

  // Getting Pilot Country 
  public string GetPilotNation()
  {
    return team.Pilot.Country;
  }

  // Getting Pilot Name
  public string GetPilotName()
  {
    return team.Pilot.Name;
  }

  // Getting Car String
  public string GetCarString()
  {
    return team.CarString;
  }

  // Getting Car Statu
  public int GetCarStatus(int selection)
  {
    if (selection == 0)
      return GetPower();
    if (selection == 1)
      return GetDura();
    if (selection == 2)
      return GetAero();
    return GetChassis();
  }

  // Getting Car Power
  public int GetPower()
  {
    return team.Car.Power;
  }

  // Getting Car Durability
  public int GetDura()
  {
    return team.Car.Durability;
  }

  // Getting Car Aerodynamics
  public int GetAero()
  {
    return team.Car.Aerodynamics;
  }

  // Getting Car Chassis
  public int GetChassis()
  {
    return team.Car.Chassis;
  }

  // Getting Pilot Points
  public int GetPoints()
  {
    return pilot.Points;
  }

  // Getting Current Track
  public int GetCurrentTrack()
  {
    return currentTrack;
  }

  // Advance to next race
  public void NextRace()
  {
    currentTrack++;
    week++;
  }

  // Advance to next year
  public void NextYear()
  {
    year++;
  }

  // Getting Current Week
  public int GetCurrentWeek()
  {
    return week;
  }

  // Set Campaign Game Over
  public void GameOver()
  {
    if(currentTrack > 9)
    {
      FindObjectOfType<SceneLoader>().LoadScene(10);
    }
  }

  // Getting Team Id
  public int GetTeamId()
  {
    return team.Id;
  }

  // Increasing player Points for improvements
  public void IncreasePlayerStatus(int points)
  {
    pilot.Points += points;
  }

  // Increasing Pilots Over
  public void IncreasingPilotsOver()
  {
    // Increasing during race 3 & 6
    if (currentTrack == 3 || currentTrack == 6)
    {
      foreach (Team team in World.teams)
      {
        int overIncrease = RandomNumberGenerator.NumberBetween(0, 3);

        if (team.Pilot.Age < 30 && team.Pilot.Over < 97)
        {
          team.Pilot.Over += overIncrease;
        }
        else if (team.Pilot.Age > 30)
        {
          team.Pilot.Over -= overIncrease;
        }
      }
    }
  }

  // Increasing Car Status
  public void IncreaseStatus(string improvement)
  {
    switch (improvement)
    {
      case "power":
        if (pilot.Points > 0 && team.Car.Power < 27)
        {
          team.Car.Power++;
          pilot.Points--;
        }
        break;
      case "durability":
        if (pilot.Points > 0 && team.Car.Durability < 27)
        {
          team.Car.Durability++;
          pilot.Points--;
        }
        break;
      case "aerodynamics":
        if (pilot.Points > 0 && team.Car.Aerodynamics < 27)
        {
          team.Car.Aerodynamics++;
          pilot.Points--;
        }
        break;
      case "chassi":
        if (pilot.Points > 0 && team.Car.Chassis < 27)
        {
          team.Car.Chassis++;
          pilot.Points--;
        }
        break;
    }
  }

  // Decreasing Car Status
  public void DecreaseStatus(string improvement)
  {
    switch (improvement)
    {
      case "power":
        if (team.Car.Power > 0)
        {
          team.Car.Power--;
          pilot.Points++;
        }
        break;
      case "durability":
        if (team.Car.Durability > 0)
        {
          team.Car.Durability--;
          pilot.Points++;
        }
        break;
      case "aerodynamics":
        if (team.Car.Aerodynamics > 0)
        {
          team.Car.Aerodynamics--;
          pilot.Points++;
        }
        break;
      case "chassi":
        if (team.Car.Chassis > 0)
        {
          team.Car.Chassis--;
          pilot.Points++;
        }
        break;
    }
  }

  // Increasing AI Cars Status
  public void IncreaseIAStatus()
  {
    int contador = 0;
    foreach(Team t in World.teams)
    {
      // Generating random numbers to improve IA Cars
      int imp_points1 = RandomNumberGenerator.NumberBetween(0, 2);
      int imp_points2 = RandomNumberGenerator.NumberBetween(0, 1);

      if (contador <= 9)
      {
        // Improving Power
        if (t.Car.Power < 26)
        {
          t.Car.Power += imp_points1;
        }
        else if (t.Car.Power < 27)
        {
          t.Car.Power += imp_points2;
        }

        // Improving Aero
        if (t.Car.Aerodynamics < 26)
        {
          t.Car.Aerodynamics += imp_points1;
        }
        else if (t.Car.Aerodynamics < 27)
        {
          t.Car.Aerodynamics += imp_points2;
        }

        // Improving Chassi
        if (t.Car.Chassis < 26)
        {
          t.Car.Chassis += imp_points1;
        }
        else if (t.Car.Chassis < 27)
        {
          t.Car.Chassis += imp_points2;
        }

        // Improving Durability
        if (t.Car.Durability < 26)
        {
          t.Car.Durability += imp_points1;
        }
        else if (t.Car.Durability < 27)
        {
          t.Car.Durability += imp_points2;
        }
      }
      contador++;
    }

    for(int i=0; i<9; i++)
    {
      World.teams[i + 10].Car.Power = World.teams[i].Car.Power;
      World.teams[i + 10].Car.Aerodynamics = World.teams[i].Car.Aerodynamics;
      World.teams[i + 10].Car.Chassis = World.teams[i].Car.Chassis;
      World.teams[i + 10].Car.Durability = World.teams[i].Car.Durability;
      Debug.Log(World.teams[i].Name + " improved their car!");
    }
    
  }

  // AI Pilot Retire
  public void PilotRetire()
  {
    int contador = 0;

    foreach (Pilot p in World.pilots)
    {
      if (p.Age > 35)
      {
        Debug.Log(p.Name + " retire!");
        p.Id = World.pilots_juniors[contador].Id;
        p.Name = World.pilots_juniors[contador].Name;
        p.Country = World.pilots_juniors[contador].Country;
        p.PilotString = World.pilots_juniors[contador].PilotString;
        p.Age = World.pilots_juniors[contador].Age;
        p.Over = World.pilots_juniors[contador].Over;
        p.Wins = World.pilots_juniors[contador].Wins;
        p.Title = World.pilots_juniors[contador].Title;
        Debug.Log(p.Name + " is the new Pilot");
      }
      contador++;
    }
  }

  // Setting a New Season
  public void NewSeason()
  {
    currentTrack = 0;
    week = 0;

    IncreaseIAStatus();
    PilotRetire();

    foreach (Team t in World.teams)
    {
      t.Pilot.points = 0;
      t.points = 0;
      t.Pilot.SeasonScore = 0;
    }
    foreach (Pilot p in World.pilots)
    {
      p.Age += 1;
    }
    // Setting Final Game Over after 10 seasons
    if(count_temporada > 9)
    {
      SceneManager.LoadScene(11);
    }
    count_temporada++;
  }
}