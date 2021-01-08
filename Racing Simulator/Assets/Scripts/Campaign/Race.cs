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
    ShowQuali();
  }

  private void DefineLeaderboard()
  {
    int r_power, r_dura, r_aero, r_chass, score = 0;
    foreach (Team team in World.teams)
    {
      r_power = RandomNumberGenerator.NumberBetween(team.Car.Power, track.Power);
      r_dura = RandomNumberGenerator.NumberBetween(team.Car.Durability, track.Durability);
      r_aero = RandomNumberGenerator.NumberBetween(team.Car.Aerodynamics, track.Aerodynamics);
      r_chass = RandomNumberGenerator.NumberBetween(team.Car.Chassis, track.Chassi);

      score = r_power + r_dura + r_aero + r_chass + session.GetPilotOver();
      team.SetScore(score);

      leaderboard.Add(team);
    }

    SortLeaderboard();

    foreach (Team t in leaderboard)
    {
      Debug.Log(t.Pilot.Name + " | " + t.Score + " | " + t.Name);

      if (contador == 0)
        first_place.text = t.Pilot.Name + " | " + t.Name;
      else if (contador == 1)
        second_place.text = t.Pilot.Name + " | " + t.Name;
      else if (contador == 2)
        third_place.text = t.Pilot.Name + " | " + t.Name;
      else if (contador == 3)
        fourth_place.text = t.Pilot.Name + " | " + t.Name;
      else if (contador == 4)
        fifth_place.text = t.Pilot.Name + " | " + t.Name;

      contador++;
    }
      
  }

  private void SortLeaderboard()
  {
    Team temp;
    for (int i = 0; i < leaderboard.Count; i++)
    {
      for (int j = 0; j < leaderboard.Count - 1; j++)
      {
        if (leaderboard[j+1].Score > leaderboard[j].Score)
        {
          temp = leaderboard[j];
          leaderboard[j] = leaderboard[j + 1];
          leaderboard[j + 1] = temp;
        }
      }
    }
  }

  public void ShowQuali()
  {
    race_screen.SetActive(false);
    quali_screen.SetActive(true);
  }

  public void Cronometro()
  {
    quali_screen.SetActive(false);

    if(tempo > 0)
    {
      tempo -= Time.deltaTime;
      int tempoInt = (int)tempo;
      tempoText.text = tempoInt.ToString();
    }
    if(tempo <= 0)
    {
      tempoText.text = "LIGHTS OUT!";
      race_screen.SetActive(true);
    }
  }

}
