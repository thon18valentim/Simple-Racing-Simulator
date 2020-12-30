using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  public static Team team; // Player chosen team
  static Pilot pilot; // Player chosen pilot

  int points = 10;
  int currentTrack = 0;

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
    team.SetPilot(i);
    World.SetPlayerTeam(team);
  }

  public void SetTeamScore(int score)
  {
    team.Score = score;
  }

  public string GetPilotFaceString()
  {
    return pilot.PilotString;
  }

  public int GetPilotOver()
  {
    return pilot.Over;
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
    return points;
  }

  public int GetCurrentTrack()
  {
    return currentTrack;
  }

  public int GetTeamId()
  {
    return team.Id;
  }

  public void IncreaseStatus(string improvement)
  {
    switch (improvement)
    {
      case "power":
        if (points > 0)
        {
          team.Car.Power++;
          points--;
        }
        break;
      case "durability":
        if (points > 0)
        {
          team.Car.Durability++;
          points--;
        }
        break;
      case "aerodynamics":
        if (points > 0)
        {
          team.Car.Aerodynamics++;
          points--;
        }
        break;
      case "chassi":
        if (points > 0)
        {
          team.Car.Chassis++;
          points--;
        }
        break;
    }
  }
}