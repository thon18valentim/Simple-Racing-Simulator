using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  public static Team team; // Player chosen team
  static Pilot pilot; // Player chosen pilot

  public int points = 10;

  public int durability = 0;
  public int power = 0;
  public int aerodynamics = 0;
  public int chassis = 0;

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
    team = new Team(World.op_teams[i].Id, World.op_teams[i].Name, World.op_teams[i].LogoString, World.op_teams[i].CarString);
    team.Car = World.CreatePlayerCar();
  }

  // Setting the player pilot
  public void SetPlayerPilot(int i)
  {
    pilot = new Pilot(World.op_pilots[i].Id, World.op_pilots[i].Name, World.op_pilots[i].Country, World.op_pilots[i].PilotString, World.op_pilots[i].Age, World.op_pilots[i].Over);
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

  public void DecreaseStatus(string improvement)
  {
    switch (improvement)
    {
      case "power":
        if (team.Car.Power > 0)
        {
          team.Car.Power--;
          points++;
        }
        break;
      case "durability":
        if (team.Car.Durability > 0)
        {
          team.Car.Durability--;
          points++;
        }
        break;
      case "aerodynamics":
        if (team.Car.Aerodynamics > 0)
        {
          team.Car.Aerodynamics--;
          points++;
        }
        break;
      case "chassi":
        if (team.Car.Chassis > 0)
        {
          team.Car.Chassis--;
          points++;
        }
        break;
    }
  }

  public string GetPilotFaceString()
  {
    return pilot.PilotString;
  }

  public string GetCarString()
  {
    return team.CarString;
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
}