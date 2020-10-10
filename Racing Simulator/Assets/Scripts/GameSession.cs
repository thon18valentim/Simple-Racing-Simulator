using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  public string teamName;

  Team team;
  Pilot pilot;

  private void Awake()
  {
    SetUpSingleton();
  }

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

  public void SetPlayerTeam(int i)
  {
    teamName = World.op_teams[i].Name;
    team = new Team(World.op_teams[i].Id, World.op_teams[i].Name, World.op_teams[i].LogoString, World.op_teams[i].CarString);
  }

  public string GetTeamName()
  {
    return team.Name;
  }
}
