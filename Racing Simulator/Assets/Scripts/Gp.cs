using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Assets.Scripts;

public class Gp : MonoBehaviour
{
  public TextMeshProUGUI gp_name;

  public GameObject race;
  public GameObject selectTrack;

  GameSession session;
  Track track;

  List<Team> leaderboard = new List<Team>();

    // Start is called before the first frame update
    void Start()
    {
      session = FindObjectOfType<GameSession>();

      DefineGpLeaderboard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void ChooseGp(int i)
  {
    track = World.tracks[FindObjectOfType<GameSession>().ChooseTrack(i)];
    //gp_name.text = track.Name;
  }
  
  public void DefineGpLeaderboard()
  {
    foreach (Team team in World.teams)
    {
      team.SetScore(CalculateTeamScore(team));
      team.pneu_dura = 20;
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

  public int CalculateTeamScore(Team team)
  {
    int r_power, r_dura, r_aero, r_chass, score = 0;

    r_power = RandomNumberGenerator.NumberBetween(team.Car.Power, track.Power);
    r_dura = RandomNumberGenerator.NumberBetween(team.Car.Durability, track.Durability);
    r_aero = RandomNumberGenerator.NumberBetween(team.Car.Aerodynamics, track.Aerodynamics);
    r_chass = RandomNumberGenerator.NumberBetween(team.Car.Chassis, track.Chassi);

    score = (r_power + r_dura + r_aero + r_chass + session.GetPilotOver() + session.GetPilotTyre()) / 7;

    return score;
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

  public void ShowRace()
  {
    selectTrack.SetActive(false);
    race.SetActive(true);
  }
}
