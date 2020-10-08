using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
  public static List<Pilot> pilots = new List<Pilot>();
  public static List<Team> teams = new List<Team>();

  // Definig the variables with id for use later
  public const int PILOT_MAICON_ID = 1;
  public const int PILOT_CARLOS_ID = 2;
  public const int PILOT_ROGER_ID = 3;

  public const int TEAM_ITALY_ID = 1;

  // Class constructor
  // It populates the list with the data needed
  static World()
  {
    PopulatePilots();
  }

  //Creating game objects and adding them to the list
  public static void PopulatePilots()
  {
    pilots.Add(new Pilot(PILOT_MAICON_ID, "Maicon Smith", "Germany", 21, 67));
    pilots.Add(new Pilot(PILOT_CARLOS_ID, "Carlos Lori", "England", 21, 65));
    pilots.Add(new Pilot(PILOT_ROGER_ID, "Roger Suzen", "Russia", 21, 64));
  }

  public static void PopulateTeams()
  {
    teams.Add(new Team(TEAM_ITALY_ID, "Team Italy", "logoItaly1", "italyCar"));
  }
}
