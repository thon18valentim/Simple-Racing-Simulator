using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
  public static List<Pilot> op_pilots = new List<Pilot>();
  public static List<Team> op_teams = new List<Team>();

  // Definig the variables with id for use later
  public const int OP_PILOT_MAICON_ID = 1;
  public const int OP_PILOT_CARLOS_ID = 2;
  public const int OP_PILOT_ROGER_ID = 3;

  public const int OP_TEAM_ITALY_ID = 1;
  public const int OP_AMERICAN_MONO_ID = 2;
  public const int OP_YELL_MOTORS_ID = 3;

  // Class constructor
  // It populates the list with the data needed
  static World()
  {
    PopulateOpPilots();
    PopulateOpTeams();
  }

  //Creating pilots and adding them to the list
  public static void PopulateOpPilots()
  {
    op_pilots.Add(new Pilot(OP_PILOT_MAICON_ID, "Maicon Smith", "Germany", 21, 67));
    op_pilots.Add(new Pilot(OP_PILOT_CARLOS_ID, "Carlos Lori", "England", 21, 65));
    op_pilots.Add(new Pilot(OP_PILOT_ROGER_ID, "Roger Suzen", "Russia", 21, 64));
  }

  // Creating the teams
  public static void PopulateOpTeams()
  {
    op_teams.Add(new Team(OP_TEAM_ITALY_ID, "Team Italy", "logoItaly1", "italyCar"));
    op_teams.Add(new Team(OP_AMERICAN_MONO_ID, "American Mono", "logoAmericanMono", "americanCar"));
    op_teams.Add(new Team(OP_YELL_MOTORS_ID, "Yell Motors", "logoYell", "yellCar"));
  }

  public Team GetOpTeam(int i)
  {
    return op_teams[i];
  }
}
