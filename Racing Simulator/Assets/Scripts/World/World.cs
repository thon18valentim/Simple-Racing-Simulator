using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
  public static List<Pilot> pilots = new List<Pilot>();
  public static List<Team> teams = new List<Team>();
  public static List<Track> tracks = new List<Track>();
  public static List<Email> emails = new List<Email>();

  // Definig the variables with id for use later
  public const int PILOT_VAND_ID = 1;
  public const int PILOT_MICK_ID = 2;
  public const int PILOT_DRUG_ID = 3;
  public const int PILOT_HAMILTON_ID = 4;
  public const int PILOT_VERSTAPPEN_ID = 5;
  public const int PILOT_LECLERC_ID = 6;
  public const int PILOT_STROLL_ID = 7;
  public const int PILOT_SAINZ_ID = 8;
  public const int PILOT_RIC_ID = 9;
  public const int PILOT_GASLY_ID = 10;
  public const int PILOT_RAIK_ID = 11;
  public const int PILOT_MAG_ID = 12;
  public const int PILOT_RUSS_ID = 13;

  // Definig the variables with id for use later on second pilot
  public const int PILOT_BOT_ID = 14;
  public const int PILOT_ALB_ID = 15;
  public const int PILOT_VET_ID = 16;
  public const int PILOT_PER_ID = 17;
  public const int PILOT_NOR_ID = 18;
  public const int PILOT_OCO_ID = 19;
  public const int PILOT_KVY_ID = 20;
  public const int PILOT_GIO_ID = 21;
  public const int PILOT_GRO_ID = 22;
  public const int PILOT_LAT_ID = 23;

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
  // Second Pilot Team ID
  public const int TEAM_SILVER_TECH_IDP2 = 11;
  public const int TEAM_BLUE_DEVILS_IDP2 = 12;
  public const int TEAM_ITALY_IDP2 = 13;
  public const int TEAM_FLOAT_POINT_TEAM_IDP2 = 14;
  public const int TEAM_ORANGE_TEAM_IDP2 = 15;
  public const int TEAM_YELL_MOTORS_IDP2 = 16;
  public const int TEAM_WHITE_DEVILS_IDP2 = 17;
  public const int TEAM_JULIET_MOTORS_IDP2 = 18;
  public const int TEAM_AMERICAN_MONO_IDP2 = 19;
  public const int TEAM_BLUE_SKY_IDP2 = 20;

  // Id for tracks
  public const int TRACK_AUSTRALIA_ID = 1;
  public const int TRACK_BAHREIN_ID = 2;
  public const int TRACK_BRAZIL_ID = 3;
  public const int TRACK_AUSTRIA_ID = 4;
  public const int TRACK_ENGLAND_ID = 5;
  public const int TRACK_ITALY_ID = 6;
  public const int TRACK_SINGAPORE_ID = 7;
  public const int TRACK_RUSSIA_ID = 8;
  public const int TRACK_USA_ID = 9;
  public const int TRACK_ABU_ID = 10;

  // Id for emails pre race
  public const int EMAIL_AUSTRALIA_ID = 1;
  public const int EMAIL_BAHREIN_ID = 2;
  public const int EMAIL_BRAZIL_ID = 3;
  public const int EMAIL_AUSTRIA_ID = 4;
  public const int EMAIL_ENGLAND_ID = 5;
  public const int EMAIL_ITALY_ID = 6;
  public const int EMAIL_SINGAPORE_ID = 7;
  public const int EMAIL_RUSSIA_ID = 8;
  public const int EMAIL_USA_ID = 9;
  public const int EMAIL_ABU_ID = 10;

  // Id for emails general
  public const int EMAIL_WELCOME_ID = 11;
  public const int EMAIL_CHALLENGES_ID = 12;
  public const int EMAIL_END_ID = 13;



  // Class constructor
  // It populates the list with the data needed
  static World()
  {
    PopulatePilots();
    PopulateTeams();
    PopulateCars();
    PopulateTracks();
    PopulateEmails();
  }

  // Creating pilots and adding them to the list
  public static void PopulatePilots()
  {
    pilots.Add(new Pilot(PILOT_HAMILTON_ID, "Hamilton", "England", "PilotFace01", 35, 94));
    pilots.Add(new Pilot(PILOT_VERSTAPPEN_ID, "Verstappen", "Netherlands", "PilotFace03", 23, 90));
    pilots.Add(new Pilot(PILOT_LECLERC_ID, "Leclerc", "Monaco", "PilotFace03", 23, 87));
    pilots.Add(new Pilot(PILOT_STROLL_ID, "Stroll", "Canada", "PilotFace06", 22, 82));
    pilots.Add(new Pilot(PILOT_SAINZ_ID, "Sainz", "Spanish", "PilotFace03", 26, 85));
    pilots.Add(new Pilot(PILOT_RIC_ID, "Ricciardo", "Australia", "PilotFace07", 31, 89));
    pilots.Add(new Pilot(PILOT_GASLY_ID, "Gasly", "France", "PilotFace06", 24, 83));
    pilots.Add(new Pilot(PILOT_RAIK_ID, "Raikkonen", "Finland", "PilotFace02", 41, 88));
    pilots.Add(new Pilot(PILOT_MAG_ID, "Magnussen", "Denmark", "PilotFace02", 28, 80));
    pilots.Add(new Pilot(PILOT_RUSS_ID, "Russel", "England", "PilotFace06", 22, 78));
    pilots.Add(new Pilot(PILOT_VAND_ID, "Vandoorne", "Belgium", "PilotFace06", 28, 74));
    pilots.Add(new Pilot(PILOT_MICK_ID, "Shumacher", "Germany", "PilotFace03", 21, 72));
    pilots.Add(new Pilot(PILOT_DRUG_ID, "Drugovich", "Brazil", "PilotFace06", 20, 69));
    //Second Pilot
    pilots.Add(new Pilot(PILOT_BOT_ID, "Bottas", "Finland", "PilotFace02", 31, 87));
    pilots.Add(new Pilot(PILOT_ALB_ID, "Albon", "Thailand", "PilotFace04", 24, 81));
    pilots.Add(new Pilot(PILOT_VET_ID, "Vettel", "Germany", "PilotFace05", 33, 84));
    pilots.Add(new Pilot(PILOT_PER_ID, "Perez", "Mexico", "PilotFace06", 31, 86));
    pilots.Add(new Pilot(PILOT_NOR_ID, "Norris", "England", "PilotFace03", 21, 83));
    pilots.Add(new Pilot(PILOT_OCO_ID, "Ocon", "France", "PilotFace06", 24, 82));
    pilots.Add(new Pilot(PILOT_KVY_ID, "Kvyat", "Russia", "PilotFace06", 26, 81));
    pilots.Add(new Pilot(PILOT_GIO_ID, "Giovinazzi", "Italy", "PilotFace06", 27, 79));
    pilots.Add(new Pilot(PILOT_GRO_ID, "Grosjean", "France", "PilotFace06", 34, 78));
    pilots.Add(new Pilot(PILOT_LAT_ID, "Latifi", "Canada", "PilotFace03", 25, 73));
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
    teams.Add(new Team(TEAM_JULIET_MOTORS_ID, "Juliet Motors", "julietLogo", "julietCar", PILOT_RAIK_ID));
    teams.Add(new Team(TEAM_AMERICAN_MONO_ID, "American Mono", "logoAmericanMono", "americanCar", PILOT_MAG_ID));
    teams.Add(new Team(TEAM_BLUE_SKY_ID, "Blue Sky Racing", "blueSkyLogo", "blueSkyCar", PILOT_RUSS_ID));
    // Second Pilot Team
    teams.Add(new Team(TEAM_SILVER_TECH_IDP2, "Silver Tech", "silverLogo", "silverTechCar", PILOT_BOT_ID));
    teams.Add(new Team(TEAM_BLUE_DEVILS_IDP2, "Blue Devils", "blueDevilsLogo", "blueDev", PILOT_ALB_ID));
    teams.Add(new Team(TEAM_ITALY_IDP2, "Team Italy", "logoItaly1", "italyCar", PILOT_VET_ID));
    teams.Add(new Team(TEAM_FLOAT_POINT_TEAM_IDP2, "Float Point Team", "floatPointLogo", "floatPointCar", PILOT_PER_ID));
    teams.Add(new Team(TEAM_ORANGE_TEAM_IDP2, "Orange Team", "orangeTeamLogo", "orangeTeam", PILOT_NOR_ID));
    teams.Add(new Team(TEAM_YELL_MOTORS_IDP2, "Yell Motors", "logoYell", "yellCar", PILOT_OCO_ID));
    teams.Add(new Team(TEAM_WHITE_DEVILS_IDP2, "White Devils", "whiteDevilsLogo", "whiteDev", PILOT_KVY_ID));
    teams.Add(new Team(TEAM_JULIET_MOTORS_IDP2, "Juliet Motors", "julietLogo", "julietCar", PILOT_GIO_ID));
    teams.Add(new Team(TEAM_AMERICAN_MONO_IDP2, "American Mono", "logoAmericanMono", "americanCar", PILOT_GRO_ID));
    teams.Add(new Team(TEAM_BLUE_SKY_IDP2, "Blue Sky Racing", "blueSkyLogo", "blueSkyCar", PILOT_LAT_ID));
  }

  // Creating the Tracks
  public static void PopulateTracks()
  { 
    tracks.Add(new Track(TRACK_AUSTRALIA_ID, "Albert Park", "Australia", 58, 30, 35, 30, 32, "bandeira_australia"));
    tracks.Add(new Track(TRACK_BAHREIN_ID, "Bahrain International Circuit", "Bahrain", 57, 34, 30, 30, 32, "bandeira_bahrein"));
    tracks.Add(new Track(TRACK_BRAZIL_ID, "Autodromo de Interlagos", "Brasil", 71, 32, 32, 32, 32, "bandeira_brasil"));
    tracks.Add(new Track(TRACK_AUSTRIA_ID, "Red Bull Ring", "Austria", 71, 33, 28, 34, 32, "bandeira_austria"));
    tracks.Add(new Track(TRACK_ENGLAND_ID, "Silverstone Circuit", "England", 52, 29, 31, 33, 30, "bandeira_england"));
    tracks.Add(new Track(TRACK_ITALY_ID, "Autodromo Nazionale Monza", "Italy", 53, 30, 28, 34, 32, "bandeira_italy"));
    tracks.Add(new Track(TRACK_SINGAPORE_ID, "Marina Bay Street Circuit", "Singapore", 61, 35, 35, 29, 28, "bandeira_singapore"));
    tracks.Add(new Track(TRACK_RUSSIA_ID, "Sochi Autodrom", "Russia", 53, 34, 33, 30, 29, "bandeira_russia"));
    tracks.Add(new Track(TRACK_USA_ID, "Circuit of the Americas", "United States", 56, 30, 30, 33, 32, "bandeira_usa"));
    tracks.Add(new Track(TRACK_ABU_ID, "Yas Marina Circuit", "Abu Dhabi", 55, 30,29,35,32, "bandeira_abu"));
  }

  // Creating Emails
  public static void PopulateEmails()
  {
    emails.Add(new Email(EMAIL_AUSTRALIA_ID, "Manuel Vieira - Team Assistant", "Australia GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Aerodynamics & Durability are the big dogs here;" +
      "\n>> Your great rivals here are Blue Devils & Silver Tech & Orange Team;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "1º Month"));
    emails.Add(new Email(EMAIL_BAHREIN_ID, "Manuel Vieira - Team Assistant", "Bahrein GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Power & Durability are the big dogs here;" +
      "\n>> Your great rivals here are Silver Tech & Blue Devils & Float Point;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "2º Month"));
    emails.Add(new Email(EMAIL_BRAZIL_ID, "Manuel Vieira - Team Assistant", "Brazil GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> This track is very balanced among each attribute;" +
      "\n>> Your great rivals here are Silver Tech & Blue Devils & Float Point;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "3º Month"));
    emails.Add(new Email(EMAIL_AUSTRIA_ID, "Manuel Vieira - Team Assistant", "Austria GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Power is the big dog here;" +
      "\n>> Your great rivals here are Silver Tech & Blue Devils & Float Point;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "4º Month"));
    emails.Add(new Email(EMAIL_ENGLAND_ID, "Manuel Vieira - Team Assistant", "England GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Aerodynamics is the big dog here;" +
      "\n>> Your great rivals here are Blue Devils & Silver Tech & Orange Team;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "5º Month"));
    emails.Add(new Email(EMAIL_ITALY_ID, "Manuel Vieira - Team Assistant", "Italy GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Power is the big dog here;" +
      "\n>> Your great rivals here are Blue Devils & Silver Tech & Orange Team;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "6º Month"));
    emails.Add(new Email(EMAIL_SINGAPORE_ID, "Manuel Vieira - Team Assistant", "Singapore GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Chassi & Durability are the big dogs here;" +
      "\n>> Your great rivals here are Siver Tech & Blue Devils & Float Point;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "7º Month"));
    emails.Add(new Email(EMAIL_RUSSIA_ID, "Manuel Vieira - Team Assistant", "Russia GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Chassi is the big dog here;" +
      "\n>> Your great rivals here are Blue Devils & Silver Tech & Orange Team;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "8º Month"));
    emails.Add(new Email(EMAIL_USA_ID, "Manuel Vieira - Team Assistant", "USA GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Aerodynamics & Power are the big dogs here;" +
      "\n>> Your great rivals here are Blue Devils & Silver Tech & Orange Team;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "9º Month"));
    emails.Add(new Email(EMAIL_ABU_ID, "Manuel Vieira - Team Assistant", "Abu Dhabi GP Pre-race", "Hi, Manuel here!" +
      "\n>> Don't forget to have a look at the Calender;" +
      "\n>> Power is the big dog here;" +
      "\n>> Your great rivals here are Blue Devils & Silver Tech & Orange Team;" +
      "\n>> Take care of your tyres, a great strategy can win titles;", "10º Month"));
    emails.Add(new Email(EMAIL_WELCOME_ID,"Oliver Rashford - Team Principal", "Welcome", "I would like to " +
      "welcome you to your new seat this season. Be free to make any change during the races and backstages." +
      "If you want to have a look at the Season Standings, Calender or Showcase, just click on Management." +
      "If you have to make an improvement in your Car, just click on Improvements, there you will have an" +
      "overview of our Car attributes. Good Luck!", "1º Month"));
    emails.Add(new Email(EMAIL_CHALLENGES_ID, "Alan Right - Team Performance Princial", "Some tips", "Hi, my name is Alan Right." +
      "I'm the Team Performance Principal, I would like to tell you some tips before you start." +
      "Firstly, take a time to read your season challenges, they will increase your final points at " +
      "the end of the season. Before each race, take a look at the calender, it will give you a north" +
      "about the next race characteristics. After every race you will have new Improvements Points," +
      "don't forget to indicate to the Team the necessary changes. I wish you a good season!", "1º Month"));
    emails.Add(new Email(EMAIL_END_ID, "Oliver Rashford - Team Principal", "Goodbye, and Thank you", "Before the last" +
      "race of the season I would like to thank you for all the hard work you spent here. All the Team employees" +
      "are happy with your work. I wish you have a great race tomorrow!", "10º Month"));
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
    teams[0].Car = car; // Silver Tech
    car = new Car(20, 18, 22, 18);
    teams[1].Car = car; // Blue Devils
    car = new Car(14, 13, 10, 13);
    teams[2].Car = car; // Team Italy
    car = new Car(17, 16, 15, 16);
    teams[3].Car = car; // Float Point
    car = new Car(15, 15, 19, 14);
    teams[4].Car = car; // Orange Team
    car = new Car(15, 17, 14, 15);
    teams[5].Car = car; // Yell Motors
    car = new Car(13, 13, 17, 12);
    teams[6].Car = car; // White Devils
    car = new Car(8, 10, 15, 8);
    teams[7].Car = car; // Juliet Motors
    car = new Car(7, 9, 9, 10);
    teams[8].Car = car; // American Mono
    car = new Car(8, 8, 8, 9);
    teams[9].Car = car; // Blue Sky

    // Second Team Car
    car = new Car(26, 20, 21, 19);
    teams[10].Car = car; // Silver Teach P2
    car = new Car(20, 18, 22, 18);
    teams[11].Car = car; // Blue Devils P2
    car = new Car(14, 13, 10, 13);
    teams[12].Car = car; // Team Italy P2
    car = new Car(17, 16, 15, 16);
    teams[13].Car = car; // Float Point P2
    car = new Car(15, 15, 19, 14);
    teams[14].Car = car; // Orange Team P2
    car = new Car(15, 17, 14, 15);
    teams[15].Car = car; // Yell Motors P2
    car = new Car(13, 13, 17, 12);
    teams[16].Car = car; // White Devils P2
    car = new Car(8, 10, 15, 8);
    teams[17].Car = car; // Juliet Motors P2
    car = new Car(7, 9, 9, 10);
    teams[18].Car = car; // American Mono P2
    car = new Car(8, 8, 8, 9);
    teams[19].Car = car; // Blue Sky P2
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
