using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Assets.Scripts;

public class Race : MonoBehaviour
{
  Track track;
  GameSession session;

  List<Team> leaderboard = new List<Team>();

  private void Start()
  {
    session = FindObjectOfType<GameSession>();

    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];

    DefineLeaderboard();
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
      Debug.Log(t.Name + " " + t.Score);
  }

  private void SortLeaderboard()
  {
    Team temp;
    for (int i = 0; i < leaderboard.Count; i++)
    {
      for (int j = 0; j < leaderboard.Count - 1; j++)
      {
        if (leaderboard[j].Score > leaderboard[j + 1].Score)
        {
          temp = leaderboard[j];
          leaderboard[j] = leaderboard[j + 1];
          leaderboard[j + 1] = temp;
        }
      }
    }
  }
}
