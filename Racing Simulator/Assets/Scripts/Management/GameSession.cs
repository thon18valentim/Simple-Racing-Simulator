using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  public static Team team; // Player chosen team
  static Pilot pilot; // Player chosen pilot
  static Track track; // Currently track

  int currentTrack = 0;
  int week = 0;
  int gpTrack = 0;
  int chosenPilot = 0;

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

  public int GetGpTrack()
  {
    return gpTrack;
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
    pilot = new Pilot(World.pilots[i].Id, World.pilots[i].Name, World.pilots[i].Country, World.pilots[i].PilotString, World.pilots[i].Age, World.pilots[i].Over);
    pilot.SetPoints(3);
    team.SetPilot(i + 1);
    World.SetPlayerTeam(team);
    chosenPilot = i;
  }

  public void SetTeamScore(int score)
  {
    team.Score = score;
  }

  public string GetPilotFaceString()
  {
    return pilot.PilotString;
  }

  public string GetTrackString()
  {
    return track.TrackString;
  }

  public int GetPilotOver()
  {
    return World.pilots[chosenPilot].Over;
  }

  public int GetPilotTyre()
  {
    return team.pneu_id;
  }

  public string GetPilotName()
  {
    return World.pilots[chosenPilot].Name;
  }

  public string GetCarString()
  {
    return team.CarString;
  }

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

  public int GetPower()
  {
    return team.Car.Power;
  }

  public int GetDura()
  {
    return team.Car.Durability;
  }

  public int GetAero()
  {
    return team.Car.Aerodynamics;
  }

  public int GetChassis()
  {
    return team.Car.Chassis;
  }

  public int GetPoints()
  {
    return pilot.Points;
  }

  public int GetCurrentTrack()
  {
    return currentTrack;
  }

  public void ChooseTrack(int i)
  {
    gpTrack = i;
  }

  public void NextRace()
  {
    currentTrack++;
    week++;
  }

  public int GetCurrentWeek()
  {
    return week;
  }

  public void GameOver()
  {
    if(currentTrack > 9)
    {
      FindObjectOfType<SceneLoader>().LoadScene(10);
    }
  }

  public int GetTeamId()
  {
    return team.Id;
  }

  public void IncreasePlayerStatus(int points)
  {
    pilot.Points += points;
  }

  public void IncreasingPilotsOver()
  {
    if (currentTrack == 3 || currentTrack == 6)
    {
      foreach (Team team in World.teams)
      {
        int overIncrease = RandomNumberGenerator.NumberBetween(0, 2);

        if (team.Pilot.Age < 30)
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

  public void IncreaseStatus(string improvement)
  {
    switch (improvement)
    {
      case "power":
        if (pilot.Points > 0)
        {
          team.Car.Power++;
          pilot.Points--;
        }
        break;
      case "durability":
        if (pilot.Points > 0)
        {
          team.Car.Durability++;
          pilot.Points--;
        }
        break;
      case "aerodynamics":
        if (pilot.Points > 0)
        {
          team.Car.Aerodynamics++;
          pilot.Points--;
        }
        break;
      case "chassi":
        if (pilot.Points > 0)
        {
          team.Car.Chassis++;
          pilot.Points--;
        }
        break;
    }
  }

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

  
}