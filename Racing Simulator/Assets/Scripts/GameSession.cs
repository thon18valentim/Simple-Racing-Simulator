using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  Team team; // Player chosen team
  Pilot pilot; // Player chosen pilot

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
  }

  // Setting the player pilot
  public void SetPlayerPilot(int i)
  {
    pilot = new Pilot(World.op_pilots[i].Id, World.op_pilots[i].Name, World.op_pilots[i].Country, World.op_pilots[i].PilotString, World.op_pilots[i].Age, World.op_pilots[i].Over);
  }

  public void IncreaseDurability()
  {
    if (points != 0)
    {
      durability++;
      points--;
    }
  }

  public void DecreaseDurability()
  {
    if (durability != 0)
    {
      durability--;
      points++;
    }
  }

  public void IncreasePower()
  {
    if (points != 0)
    {
      power++;
      points--;
    }
  }

  public void DecreasePower()
  {
    if (power != 0)
    {
      power--;
      points++;
    }
  }

  public void IncreaseAerodynamics()
  {
    if (points != 0)
    {
      aerodynamics++;
      points--;
    }
  }

  public void DecreaseAerodynamics()
  {
    if (aerodynamics != 0)
    {
      aerodynamics--;
      points++;
    }
  }

  public void IncreaseChassis()
  {
    if (points != 0)
    {
      chassis++;
      points--;
    }
  }

  public void DecreaseChassis()
  {
    if (chassis != 0)
    {
      chassis--;
      points++;
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

  public int GetPoints()
  {
    return points;
  }

  public int GetPower()
  {
    return power;
  }

  public int GetDura()
  {
    return durability;
  }

  public int GetAero()
  {
    return aerodynamics;
  }

  public int GetChassis()
  {
    return chassis;
  }
}