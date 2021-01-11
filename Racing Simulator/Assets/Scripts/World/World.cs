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
  public const int PILOT_HAMILTON_ID = 1;
  public const int PILOT_VERSTAPPEN_ID = 2;
  public const int PILOT_LECLERC_ID = 3;
  public const int PILOT_STROLL_ID = 4;
  public const int PILOT_SAINZ_ID = 5;
  public const int PILOT_RIC_ID = 6;
  public const int PILOT_GASLY_ID = 7;
  public const int PILOT_RAIK_ID = 8;
  public const int PILOT_MAG_ID = 9;
  public const int PILOT_RUSS_ID = 10;
  public const int PILOT_VAND_ID = 11;
  public const int PILOT_MICK_ID = 12;
  public const int PILOT_DRUG_ID = 13;

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
    PopulatePilots();
    PopulateTeams();
    PopulateCars();
    PopulateTracks();
  }

  //Creating pilots and adding them to the list
  public static void PopulatePilots()
  {
    pilots.Add(new Pilot(PILOT_HAMILTON_ID, "Hamilton", "England", "PilotFace2", 35, 94));
    pilots.Add(new Pilot(PILOT_VERSTAPPEN_ID, "Verstappen", "Netherlands", "PilotFace1", 23, 90));
    pilots.Add(new Pilot(PILOT_LECLERC_ID, "Leclerc", "Monaco", "PilotFace1", 23, 87));
    pilots.Add(new Pilot(PILOT_STROLL_ID, "Stroll", "Canada", "PilotFace3", 22, 82));
    pilots.Add(new Pilot(PILOT_SAINZ_ID, "Sainz", "Spanish", "PilotFace3", 26, 85));
    pilots.Add(new Pilot(PILOT_RIC_ID, "Ricciardo", "Australia", "PilotFace3", 31, 89));
    pilots.Add(new Pilot(PILOT_GASLY_ID, "Gasly", "France", "PilotFace1", 24, 83));
    pilots.Add(new Pilot(PILOT_RAIK_ID, "Raikkonen", "Finland", "PilotFace1", 41, 88));
    pilots.Add(new Pilot(PILOT_MAG_ID, "Magnussen", "Denmark", "PilotFace3", 28, 80));
    pilots.Add(new Pilot(PILOT_RUSS_ID, "Russel", "England", "PilotFace3", 22, 78));
    pilots.Add(new Pilot(PILOT_VAND_ID, "Vandoorne", "Belgium", "PilotFace3", 28, 74));
    pilots.Add(new Pilot(PILOT_MICK_ID, "Shumacher", "Germany", "PilotFace1", 21, 72));
    pilots.Add(new Pilot(PILOT_DRUG_ID, "Drugovich", "Brazil", "PilotFace1", 20, 69));
  }

  // Creating the teams
  public static void PopulateTeams()
  {
    teams.Add(new Team(TEAM_SILVER_TECH_ID, "Silver Tech", "silverLogo", "silverTechCar", PILOT_HAMILTON_ID));
    teams.Add(new Team(TEAM_BLUE_DEVILS_ID, "Blue Devils", "blueDevilsLogo", "blueDev", PILOT_VERSTAPPEN_ID));
    teams.Add(new Team(TEAM_ITALY_ID, "Team Italy", "logoItaly1", "italyCar", PILOT_LECLERC_ID));
    teams.Add(new Team(TEAM_FLOAT_POINT_TEAM_ID, "Float Point Team", "floatPointLogo", "floatPointCar", PILOT_STROLL_ID));
    teams.Add(new Team(TEAM_ORANGE_TEAM_ID, "Orange Team", "orangeTeamLogo", "orangeTeam", PILOT_SAINZ_ID));
    teams.Add(new Team(TEAM_YELL_MOTORS_ID, "Yell Motors", "logoYell", "yellCar", PILOT_RIC_ID));
    teams.Add(new Team(TEAM_WHITE_DEVILS_ID, "White Devils", "whiteDevilsLogo", "whiteDev", PILOT_GASLY_ID));
    teams.Add(new Team(TEAM_WHITE_DEVILS_ID, "Juliet Motors", "julietLogo", "julietCar", PILOT_RAIK_ID));
    teams.Add(new Team(TEAM_AMERICAN_MONO_ID, "American Mono", "logoAmericanMono", "americanCar", PILOT_MAG_ID));
    teams.Add(new Team(TEAM_BLUE_SKY_ID, "Blue Sky Racing", "blueSkyLogo", "blueSkyCar", PILOT_RUSS_ID));
  }

  //Creating the Tracks
  public static void PopulateTracks()
  {
    tracks.Add(new Track(TRACK_AUSTRALIA_ID, "Albert Park", "Australia", 58, 30, 35, 28, 32));
    tracks.Add(new Track(TRACK_BAHREIN_ID, "Autódromo de Bahrein", "Bahrein", 57, 34, 30, 30, 32));
    tracks.Add(new Track(TRACK_BRAZIL_ID, "Autódromo de Interlagos", "Brasil", 71, 32, 32, 32, 32));
  }

  public static Car CreatePlayerCar()
  {
    Car car = new Car(6, 7, 5, 4); //Player Starting points

    return car;
  }

  public static void SetPlayerTeam(Team team)
  {
    teams[team.Id - 1] = team; 
  }

  public static void PopulateCars()
  {
    Car car = new Car(26, 20, 21, 19); //Power, Aero, Dura, Chassis
    teams[0].Car = car; //Silver Tech
    car = new Car(20, 18, 22, 18);
    teams[1].Car = car; //Blue Devils
    car = new Car(14, 13, 10, 13);
    teams[2].Car = car; //Team Italy
    car = new Car(17, 16, 15, 16);
    teams[3].Car = car; //Float Point
    car = new Car(15, 15, 19, 14);
    teams[4].Car = car; //Orange Team
    car = new Car(15, 17, 14, 15);
    teams[5].Car = car; //Yell Motors
    car = new Car(13, 13, 17, 12);
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
