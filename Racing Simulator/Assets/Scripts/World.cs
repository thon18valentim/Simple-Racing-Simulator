using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
  public static List<Pilot> op_pilots = new List<Pilot>();
  public static List<Team> op_teams = new List<Team>();
  public static List<Track> op_tracks = new List<Track>();
  public static List<Classificacao> op_grid = new List<Classificacao>();


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
    PopulateCars();
  }

  //Creating pilots and adding them to the list
  public static void PopulateOpPilots()
  {
    op_pilots.Add(new Pilot(OP_PILOT_MAICON_ID, "Maicon Smith", "Germany","PilotFace1", 21, 67));
    op_pilots.Add(new Pilot(OP_PILOT_CARLOS_ID, "Carlos Lori", "England","PilotFace2", 21, 65));
    op_pilots.Add(new Pilot(OP_PILOT_ROGER_ID, "Roger Suzen", "Russia","PilotFace3", 21, 64));
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

  //Creating the Tracks
  public static void PopulateOpTracks()

  {

    op_tracks.Add(new Track("Alberto Correia","Australia",58,30,35,28,32));

    op_tracks.Add(new Track("Autódromo das Areias", "Bahrein", 57, 34, 30, 30, 32));

    op_tracks.Add(new Track("Autódromo de São Paulo", "Brasil", 71, 32, 32, 32, 32));

  }

  public static Car CreatePlayerCar()
  {
    Car car = new Car(5, 5, 5, 5); //Player Starting points

    return car;
  }

  public static void PopulateCars()
  {
    Car car = new Car(21, 17, 19, 17); //Power, Aero, Dura, Chassis
    op_teams[0].Car = car; //Silver Tech
    car = new Car(17, 18, 16, 15);
    op_teams[1].Car = car; //Blue Devils
    car = new Car(14, 13, 10, 13);
    op_teams[2].Car = car; //Team Italy
    car = new Car(15, 14, 13, 14);
    op_teams[3].Car = car; //Float Point
    car = new Car(13, 13, 17, 12);
    op_teams[4].Car = car; //Orange Team
    car = new Car(13, 15, 12, 13);
    op_teams[5].Car = car; //Yell Motors
    car = new Car(11, 11, 15, 10);
    op_teams[6].Car = car; //White Devils
    car = new Car(8, 10, 15, 8);
    op_teams[7].Car = car; //Juliet Motors
    car = new Car(7, 9, 9, 10);
    op_teams[8].Car = car; //American Mono
    car = new Car(8, 8, 8, 9);
    op_teams[9].Car = car; //Blue Sky
  }

  public static void PopulateGrid()
  {
    op_grid.Add(new Classificacao("Lewis Hamilton", op_teams[0]));
    op_grid.Add(new Classificacao("Max Verstappen", op_teams[1]));
    op_grid.Add(new Classificacao("Charles Leclerc", op_teams[2]));
    op_grid.Add(new Classificacao("Lance Stroll", op_teams[3]));
    op_grid.Add(new Classificacao("Carlos Sainz", op_teams[4]));
    op_grid.Add(new Classificacao("Daniel Ricciardo", op_teams[5]));
    op_grid.Add(new Classificacao("Pierre Gasly", op_teams[6]));
    op_grid.Add(new Classificacao("Kimi Raikkonen", op_teams[7]));
    op_grid.Add(new Classificacao("Kevin Magnussen", op_teams[8]));
    op_grid.Add(new Classificacao("George Russel", op_teams[9]));
  }

  public Team GetOpTeam(int i)
  {
    return op_teams[i];
  }
}
