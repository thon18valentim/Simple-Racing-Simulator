using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
  public static Team team; // Player chosen team
  static Pilot pilot; // Player chosen pilot
  static Track track; // Currently track

  int currentTrack = 0;
  int week = 0;
  int gpTrack = 0;
  int chosenPilot = 0;
  int playerScore = 0;
  public int year = 2020;
  public int count_temporada = 0;

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

  public void SetYear(int year_temp)
  {
    year = year_temp;
  }
  public int GetYear()
  {
    return year;
  }

  public void SetTemporada(int temporada)
  {
    count_temporada = temporada;
  }
  public int GetTemporada()
  {
    return count_temporada;
  }

  public int GetGpTrack()
  {
    return gpTrack;
  }

  public int GetPlayerFinalScore()
  {
    return playerScore;
  }

  // Setting the player team
  public void SetPlayerTeam(int i)
  {
    team = new Team(World.teams[i].Id, World.teams[i].Name, World.teams[i].LogoString, World.teams[i].CarString, i)
    {
      Car = World.CreatePlayerCar()
    };
  }

  // Setting the player pilot
  public void SetPlayerPilot(int i)
  {
    pilot = new Pilot(World.pilots[i].Id, World.pilots[i].Name, World.pilots[i].Country, World.pilots[i].PilotString, World.pilots[i].Age, World.pilots[i].Over, World.pilots[i].Title, World.pilots[i].Wins);
    pilot.SetPoints(3);
    team.SetPilot(i + 1);
    World.SetPlayerTeam(team);
    chosenPilot = i;
  }

  public void SetTeamScore(int score)
  {
    team.Score = score;
  }

  public void SetCurrentTrack(int i)
  {
    currentTrack = i;
  }
  public void SetWeek(int i)
  {
    week = i;
  }
  public void SetPlayerScore(int i)
  {
    playerScore = i;
  }
  public void SetSavedPlayerTeam(Team player)
  {
    team = player;
  }

  public string GetPlayerCar()
  {
    return team.CarString;
  }
  public void SetSavedPlayerPilot(Pilot player)
  {
    pilot = player;
  }

  public int GetSeasonYear()
  {
    return year;
  }

  public string GetPilotFaceString()
  {
    return pilot.PilotString;
  }

  public string GetTrackString()
  {
    return track.TrackString;
  }

  public int GetPilotOver()
  {
    return team.Pilot.Over;
  }

  public Team GetPlayerTeam()
  {
    return team;
  }
  public Pilot GetPlayerPilot()
  {
    return pilot;
  }

  public int GetPilotTyre()
  {
    return team.pneu_id;
  }

  public string GetTeamName()
  {
    return team.Name;
  }

  public int GetPilotAge()
  {
    return pilot.Age;
  }

  public string GetPilotNation()
  {
    return pilot.Country;
  }

  public string GetPilotName()
  {
    return team.Pilot.Name;
  }

  public string GetCarString()
  {
    return team.CarString;
  }

  public int GetCarStatus(int selection)
  {
    if (selection == 0)
      return GetPower();
    if (selection == 1)
      return GetDura();
    if (selection == 2)
      return GetAero();
    return GetChassis();
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
    return pilot.Points;
  }

  public int GetCurrentTrack()
  {
    return currentTrack;
  }

  public void ChooseTrack(int i)
  {
    gpTrack = i;
  }

  public void NextRace()
  {
    currentTrack++;
    week++;
  }

  public void NextYear()
  {
    year++;
  }

  public int GetCurrentWeek()
  {
    return week;
  }

  public void GameOver()
  {
    if(currentTrack > 9)
    {
      FindObjectOfType<SceneLoader>().LoadScene(10);
    }
  }

  public int GetTeamId()
  {
    return team.Id;
  }

  public void IncreasePlayerStatus(int points)
  {
    pilot.Points += points;
  }

  public void IncreasingPilotsOver()
  {
    if (currentTrack == 3 || currentTrack == 6)
    {
      foreach (Team team in World.teams)
      {
        int overIncrease = RandomNumberGenerator.NumberBetween(0, 3);

        if (team.Pilot.Age < 30 && team.Pilot.Over < 97)
        {
          team.Pilot.Over += overIncrease;
        }
        else if (team.Pilot.Age > 30)
        {
          team.Pilot.Over -= overIncrease;
        }
      }
    }
  }

  public void IncreaseStatus(string improvement)
  {
    switch (improvement)
    {
      case "power":
        if (pilot.Points > 0 && team.Car.Power < 27)
        {
          team.Car.Power++;
          pilot.Points--;
        }
        break;
      case "durability":
        if (pilot.Points > 0 && team.Car.Durability < 27)
        {
          team.Car.Durability++;
          pilot.Points--;
        }
        break;
      case "aerodynamics":
        if (pilot.Points > 0 && team.Car.Aerodynamics < 27)
        {
          team.Car.Aerodynamics++;
          pilot.Points--;
        }
        break;
      case "chassi":
        if (pilot.Points > 0 && team.Car.Chassis < 27)
        {
          team.Car.Chassis++;
          pilot.Points--;
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
          pilot.Points++;
        }
        break;
      case "durability":
        if (team.Car.Durability > 0)
        {
          team.Car.Durability--;
          pilot.Points++;
        }
        break;
      case "aerodynamics":
        if (team.Car.Aerodynamics > 0)
        {
          team.Car.Aerodynamics--;
          pilot.Points++;
        }
        break;
      case "chassi":
        if (team.Car.Chassis > 0)
        {
          team.Car.Chassis--;
          pilot.Points++;
        }
        break;
    }
  }

  public void IncreaseIAStatus()
  {
    int contador = 0;
    foreach(Team t in World.teams)
    {
      // Generating random numbers to improve IA Cars
      int imp_points1 = RandomNumberGenerator.NumberBetween(0, 2);
      int imp_points2 = RandomNumberGenerator.NumberBetween(0, 1);

      if (contador <= 9)
      {
        // Improving Power
        if (t.Car.Power < 26)
        {
          t.Car.Power += imp_points1;
        }
        else if (t.Car.Power < 27)
        {
          t.Car.Power += imp_points2;
        }

        // Improving Aero
        if (t.Car.Aerodynamics < 26)
        {
          t.Car.Aerodynamics += imp_points1;
        }
        else if (t.Car.Aerodynamics < 27)
        {
          t.Car.Aerodynamics += imp_points2;
        }

        // Improving Chassi
        if (t.Car.Chassis < 26)
        {
          t.Car.Chassis += imp_points1;
        }
        else if (t.Car.Chassis < 27)
        {
          t.Car.Chassis += imp_points2;
        }

        // Improving Durability
        if (t.Car.Durability < 26)
        {
          t.Car.Durability += imp_points1;
        }
        else if (t.Car.Durability < 27)
        {
          t.Car.Durability += imp_points2;
        }
      }
      contador++;
    }

    for(int i=0; i<9; i++)
    {
      World.teams[i + 10].Car.Power = World.teams[i].Car.Power;
      World.teams[i + 10].Car.Aerodynamics = World.teams[i].Car.Aerodynamics;
      World.teams[i + 10].Car.Chassis = World.teams[i].Car.Chassis;
      World.teams[i + 10].Car.Durability = World.teams[i].Car.Durability;
      Debug.Log(World.teams[i].Name + " improved their car!");
    }
    
  }

  public void PilotRetire()
  {
    int contador = 0;

    foreach (Pilot p in World.pilots)
    {
      if (p.Age > 35)
      {
        Debug.Log(p.Name + " retire!");
        p.Id = World.pilots_juniors[contador].Id;
        p.Name = World.pilots_juniors[contador].Name;
        p.Country = World.pilots_juniors[contador].Country;
        p.PilotString = World.pilots_juniors[contador].PilotString;
        p.Age = World.pilots_juniors[contador].Age;
        p.Over = World.pilots_juniors[contador].Over;
        p.Wins = World.pilots_juniors[contador].Wins;
        p.Title = World.pilots_juniors[contador].Title;
        Debug.Log(p.Name + " is the new Pilot");
      }
      contador++;
    }
  }

  public void NewSeason()
  {
    currentTrack = 0;
    week = 0;
    playerScore = 0;

    IncreaseIAStatus();
    PilotRetire();

    foreach (Team t in World.teams)
    {
      t.Pilot.points = 0;
      t.points = 0;
    }
    foreach (Pilot p in World.pilots)
    {
      p.Age += 1;
    }
    if(count_temporada > 9)
    {
      SceneManager.LoadScene(11);
    }
    count_temporada++;
  }

  
}