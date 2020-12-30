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
  }

  public void DefineLeaderboard()
  {
    int r_power, r_dura, r_aero, r_chass, score = 0;
    foreach (Team team in World.teams)
    {
      if (team.Id == session.GetTeamId())
      {
        r_power = RandomNumberGenerator.NumberBetween(session.GetPower(), track.Power);
        r_dura = RandomNumberGenerator.NumberBetween(session.GetDura(), track.Durability);
        r_aero = RandomNumberGenerator.NumberBetween(session.GetAero(), track.Aerodynamics);
        r_chass = RandomNumberGenerator.NumberBetween(session.GetChassis(), track.Chassi);

        score = r_power + r_dura + r_aero + r_chass + session.GetPilotOver();
        session.SetTeamScore(score);
      }
      else
      {
        r_power = RandomNumberGenerator.NumberBetween(team.Car.Power, track.Power);
        r_dura = RandomNumberGenerator.NumberBetween(team.Car.Durability, track.Durability);
        r_aero = RandomNumberGenerator.NumberBetween(team.Car.Aerodynamics, track.Aerodynamics);
        r_chass = RandomNumberGenerator.NumberBetween(team.Car.Chassis, track.Chassi);

        score = r_power + r_dura + r_aero + r_chass + session.GetPilotOver();
      }
    }
  }
}
