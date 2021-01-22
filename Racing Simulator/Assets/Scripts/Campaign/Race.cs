using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Assets.Scripts;

public class Race : MonoBehaviour
{
  public GameObject quali_screen;
  public GameObject race_screen;

  public TextMeshProUGUI first_place;
  public TextMeshProUGUI second_place;
  public TextMeshProUGUI third_place;
  public TextMeshProUGUI fourth_place;
  public TextMeshProUGUI fifth_place;

  public int contador = 0;

  public TextMeshProUGUI tempoText;
  public float tempo = 3;

  Track track;
  GameSession session;

  List<Team> leaderboard = new List<Team>();

  private void Start()
  {
    session = FindObjectOfType<GameSession>();

    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];

    DefineLeaderboard();

    StartRace();
    //ShowQuali();
  }

  private void StartRace()
  {
    int laps = track.Laps;
    int current_lap = 0;

    do
    {
      foreach (Team team in leaderboard)
      {
        team.SetScore(CalculateTeamScore(team));

        ReduceLapTime(team);
      }

      current_lap++;
    } while (current_lap <= laps);
  }

  private void ReduceLapTime(Team team)
  {
    if (team.Score >= 30)
    {
      team.SetLapTime(team.LapTime - 1.0f);
    }
    else if (team.Score >= 28)
    {
      team.SetLapTime(team.LapTime - 0.8f);
    }
    else if (team.Score >= 25)
    {
      team.SetLapTime(team.LapTime - 0.5f);
    }
    else if (team.Score >= 20)
    {
      team.SetLapTime(team.LapTime - 0.25f);
    }
    else if (team.Score > 14)
    {
      team.SetLapTime(team.LapTime - 0.20f);
    }
    else if (team.Score <= 14)
    {
      team.SetLapTime(team.LapTime - 0.15f);
    }
  }

  //if (contador == 0)
  //      first_place.text = t.Pilot.Name + " | " + t.Name;
  //    else if (contador == 1)
  //      second_place.text = t.Pilot.Name + " | " + t.Name;
  //    else if (contador == 2)
  //      third_place.text = t.Pilot.Name + " | " + t.Name;
  //    else if (contador == 3)
  //      fourth_place.text = t.Pilot.Name + " | " + t.Name;
  //    else if (contador == 4)
  //      fifth_place.text = t.Pilot.Name + " | " + t.Name;
  //contador++;

  private void DefineLeaderboard()
  {
    foreach (Team team in World.teams)
    {
      team.SetScore(CalculateTeamScore(team));

      leaderboard.Add(team);
    }

    SortLeaderboard();

    float time = 100.00f;
    foreach (Team t in leaderboard)
    {
      t.SetLapTime(time);
      time++;
    }
  }

  private void SortLeaderboard()
  {
    Team temp;
    for (int i = 0; i < leaderboard.Count; i++)
    {
      for (int j = 0; j < leaderboard.Count - 1; j++)
      {
        if (leaderboard[j + 1].Score > leaderboard[j].Score)
        {
          temp = leaderboard[j];
          leaderboard[j] = leaderboard[j + 1];
          leaderboard[j + 1] = temp;
        }
      }
    }
  }

  public int CalculateTeamScore(Team team)
  {
    int r_power, r_dura, r_aero, r_chass, score = 0;

    r_power = RandomNumberGenerator.NumberBetween(team.Car.Power, track.Power);
    r_dura = RandomNumberGenerator.NumberBetween(team.Car.Durability, track.Durability);
    r_aero = RandomNumberGenerator.NumberBetween(team.Car.Aerodynamics, track.Aerodynamics);
    r_chass = RandomNumberGenerator.NumberBetween(team.Car.Chassis, track.Chassi);

    score = (r_power + r_dura + r_aero + r_chass + session.GetPilotOver()) / 6;

    return score;
  }

  //public void ShowQuali()
  //{
  //  race_screen.SetActive(false);
  //  quali_screen.SetActive(true);
  //}

  //public void Cronometro()
  //{
  //  quali_screen.SetActive(false);

  //  if (tempo > 0)
  //  {
  //    tempo -= Time.deltaTime;
  //    int tempoInt = (int)tempo;
  //    tempoText.text = tempoInt.ToString();
  //  }
  //  if (tempo <= 0)
  //  {
  //    tempoText.text = "LIGHTS OUT!";
  //    race_screen.SetActive(true);
  //  }
  //}
}
