using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
  public static List<Pilot> pilots = new List<Pilot>();
  public static List<Team> teams = new List<Team>();
  public static List<Track> tracks = new List<Track>();

  // Definig the variables with id for use later
  public const int PILOT_MAICON_ID = 1;
  public const int PILOT_CARLOS_ID = 2;
  public const int PILOT_ROGER_ID = 3;

  // Id for teams
  public const int TEAM_SILVER_TECH_ID = 1;
  public const int TEAM_BLUE_DEVILS_ID = 2;
  public const int TEAM_ITALY_ID = 3;
  public const int TEAM_FLOAT_POINT_TEAM_ID = 4;
  public const int TEAM_ORANGE_TEAM_ID = 5;
  public const int TEAM_YELL_MOTORS_ID = 6;
  public const int TEAM_WHITE_DEVILS_ID = 7;
  public const int TEAM_JULIET_MOTORS_ID = 8;
  public const int TEAM_AMERICAN_MONO_ID = 9;
  public const int TEAM_BLUE_SKY_ID = 10;

  // Id for tracks
  public const int TRACK_AUSTRALIA_ID = 1;
  public const int TRACK_BAHREIN_ID = 2;
  public const int TRACK_BRAZIL_ID = 3;

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
    pilots.Add(new Pilot(PILOT_MAICON_ID, "Maicon Smith", "Germany", "PilotFace1", 21, 67));
    pilots.Add(new Pilot(PILOT_CARLOS_ID, "Carlos Lori", "England", "PilotFace2", 21, 65));
    pilots.Add(new Pilot(PILOT_ROGER_ID, "Roger Suzen", "Russia", "PilotFace3", 21, 64));
  }

  // Creating the teams
  public static void PopulateOpTeams()
  {
    teams.Add(new Team(TEAM_SILVER_TECH_ID, "Silver Tech", "silverLogo", "silverTechCar", PILOT_CARLOS_ID));
    teams.Add(new Team(TEAM_BLUE_DEVILS_ID, "Blue Devils", "blueDevilsLogo", "blueDev", PILOT_MAICON_ID));
    teams.Add(new Team(TEAM_ITALY_ID, "Team Italy", "logoItaly1", "italyCar", PILOT_ROGER_ID));
    teams.Add(new Team(TEAM_FLOAT_POINT_TEAM_ID, "Float Point Team", "floatPointLogo", "floatPointCar"));
    teams.Add(new Team(TEAM_ORANGE_TEAM_ID, "Orange Team", "orangeTeamLogo", "orangeTeam"));
    teams.Add(new Team(TEAM_YELL_MOTORS_ID, "Yell Motors", "logoYell", "yellCar"));
    teams.Add(new Team(TEAM_WHITE_DEVILS_ID, "White Devils", "whiteDevilsLogo", "whiteDev"));
    teams.Add(new Team(TEAM_WHITE_DEVILS_ID, "Juliet Motors", "julietLogo", "julietCar"));
    teams.Add(new Team(TEAM_AMERICAN_MONO_ID, "American Mono", "logoAmericanMono", "americanCar"));
    teams.Add(new Team(TEAM_BLUE_SKY_ID, "Blue Sky Racing", "blueSkyLogo", "blueSkyCar"));
  }

  //Creating the Tracks
  public static void PopulateOpTracks()
  {
    tracks.Add(new Track(TRACK_AUSTRALIA_ID, "Alberto Correia", "Australia", 58, 30, 35, 28, 32));
    tracks.Add(new Track(TRACK_BAHREIN_ID, "Autódromo das Areias", "Bahrein", 57, 34, 30, 30, 32));
    tracks.Add(new Track(TRACK_BRAZIL_ID, "Autódromo de São Paulo", "Brasil", 71, 32, 32, 32, 32));
  }

  public static Car CreatePlayerCar()
  {
    Car car = new Car(5, 5, 5, 5); //Player Starting points

    return car;
  }

  public static void PopulateCars()
  {
    Car car = new Car(21, 17, 19, 17); //Power, Aero, Dura, Chassis
    teams[0].Car = car; //Silver Tech
    car = new Car(17, 18, 16, 15);
    teams[1].Car = car; //Blue Devils
    car = new Car(14, 13, 10, 13);
    teams[2].Car = car; //Team Italy
    car = new Car(15, 14, 13, 14);
    teams[3].Car = car; //Float Point
    car = new Car(13, 13, 17, 12);
    teams[4].Car = car; //Orange Team
    car = new Car(13, 15, 12, 13);
    teams[5].Car = car; //Yell Motors
    car = new Car(11, 11, 15, 10);
    teams[6].Car = car; //White Devils
    car = new Car(8, 10, 15, 8);
    teams[7].Car = car; //Juliet Motors
    car = new Car(7, 9, 9, 10);
    teams[8].Car = car; //American Mono
    car = new Car(8, 8, 8, 9);
    teams[9].Car = car; //Blue Sky
  }

  public static Pilot GetPilotById(int id)
  {
    foreach (Pilot pilot in pilots)
      if (pilot.Id == id)
        return pilot;

    return null;
  }

  public static Team GetTeamById(int id)
  {
    foreach (Team team in teams)
      if (team.Id == id)
        return team;

    return null;
  }
}
