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

  public const int OP_SILVER_TECH_ID = 1;
  public const int OP_BLUE_DEVILS_ID = 2;
  public const int OP_TEAM_ITALY_ID = 3;
  public const int OP_FLOAT_POINT_TEAM_ID = 4;
  public const int OP_ORANGE_TEAM_ID = 5;
  public const int OP_YELL_MOTORS_ID = 6;
  public const int OP_WHITE_DEVILS_ID = 7;
  public const int OP_JULIET_MOTORS_ID = 8;
  public const int OP_AMERICAN_MONO_ID = 9;
  public const int OP_BLUE_SKY_ID = 10;

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
    op_teams.Add(new Team(OP_SILVER_TECH_ID, "Silver Tech", "silverLogo", "silverTechCar"));
    op_teams.Add(new Team(OP_BLUE_DEVILS_ID, "Blue Devils", "blueDevilsLogo", "blueDev"));
    op_teams.Add(new Team(OP_TEAM_ITALY_ID, "Team Italy", "logoItaly1", "italyCar"));
    op_teams.Add(new Team(OP_FLOAT_POINT_TEAM_ID, "Float Point Team", "floatPointLogo", "floatPointCar")); 
    op_teams.Add(new Team(OP_ORANGE_TEAM_ID, "Orange Team", "orangeTeamLogo", "orangeTeam"));
    op_teams.Add(new Team(OP_YELL_MOTORS_ID, "Yell Motors", "logoYell", "yellCar"));
    op_teams.Add(new Team(OP_WHITE_DEVILS_ID, "White Devils", "whiteDevilsLogo", "whiteDev"));
    op_teams.Add(new Team(OP_WHITE_DEVILS_ID, "Juliet Motors", "julietLogo", "julietCar"));
    op_teams.Add(new Team(OP_AMERICAN_MONO_ID, "American Mono", "logoAmericanMono", "americanCar"));
    op_teams.Add(new Team(OP_BLUE_SKY_ID, "Blue Sky Racing", "blueSkyLogo", "blueSkyCar"));
  }

  public Team GetOpTeam(int i)
  {
    return op_teams[i];
  }
}
