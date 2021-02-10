using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Assets.Scripts;

public class Gp : MonoBehaviour
{
  public TextMeshProUGUI gp_name;
  public TextMeshProUGUI gp_lap;

  public GameObject race;
  public GameObject selectTrack;

  // Management of Race Position Texts
  public TextMeshProUGUI first_race;
  public TextMeshProUGUI second_race;
  public TextMeshProUGUI third_race;
  public TextMeshProUGUI fourth_race;
  public TextMeshProUGUI fifth_race;
  public TextMeshProUGUI sixth_race;
  public TextMeshProUGUI seventh_race;
  public TextMeshProUGUI eighth_race;
  public TextMeshProUGUI nineth_race;
  public TextMeshProUGUI tenth_race;

  // Management of Race Time Texts
  public TextMeshProUGUI second_time;
  public TextMeshProUGUI third_time;
  public TextMeshProUGUI fourth_time;
  public TextMeshProUGUI fifth_time;
  public TextMeshProUGUI sixth_time;
  public TextMeshProUGUI seventh_time;
  public TextMeshProUGUI eighth_time;
  public TextMeshProUGUI nineth_time;
  public TextMeshProUGUI tenth_time;

  public GameObject btn_back;

  public GameObject australia_track;
  public GameObject bahrain_track;
  public GameObject brazil_track;

  GameSession session;
  Track track;

  List<Team> leaderboard = new List<Team>();

  // Integer for changing between tracks
  int selection = 0;

  // Btn Sound
  public AudioSource btn_sound;
  public AudioSource conf_sound;
  public AudioSource race_sound;

  // Start is called before the first frame update
  private void Start()
    {
      session = FindObjectOfType<GameSession>();
      //track = World.tracks[FindObjectOfType<GameSession>().GetGpTrack()];
      SetValues();
    }

  // Update is called once per frame
  private void Update()
    {
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      btn_sound.Play();
      selection--;
      if (selection < 0)
        selection = 2;
      SetValues();
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      btn_sound.Play();
      selection++;
      if (selection > 2)
        selection = 0;
      SetValues();
    }
    if (Input.GetKeyDown(KeyCode.Return))
    {
      conf_sound.Play();
      ShowRace();
    }
  }

  public void SetValues()
  {
    if(selection == 0)
    {
      australia_track.SetActive(true);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
    }
    else if (selection == 1)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(true);
      brazil_track.SetActive(false);
    }
    else if (selection == 2)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(true);
    }

    gp_name.text = World.tracks[selection].Name;
    track = World.tracks[selection];
    
  }
  
  public void StartRace()
  {
    race_sound.Play();

    StartCoroutine("Wait");
  }

  public void DefineGpLeaderboard()
  {
    foreach (Team team in World.teams)
    {
      team.SetScore(CalculateRaceScore(team));
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

  public int CalculateRaceScore(Team team)
  {
    int r_power, r_dura, r_aero, r_chass, score = 0;

    r_power = RandomNumberGenerator.NumberBetween(team.Car.Power, track.Power);
    r_dura = RandomNumberGenerator.NumberBetween(team.Car.Durability, track.Durability);
    r_aero = RandomNumberGenerator.NumberBetween(team.Car.Aerodynamics, track.Aerodynamics);
    r_chass = RandomNumberGenerator.NumberBetween(team.Car.Chassis, track.Chassi);

    score = (r_power + r_dura + r_aero + r_chass);

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
    DefineGpLeaderboard();
    StartRace();
  }

  IEnumerator Wait()
  {
    int laps = track.Laps;
    int current_lap = 0;
    do
    {
      foreach (Team team in leaderboard)
      {
        team.SetScore(CalculateRaceScore(team));

        ReduceLapTime(team);
        ShowRaceLeaderboard();
        team.pneu_dura--;
      }
      Overtaking();
      gp_lap.text = "Lap " + current_lap.ToString() + " / " + laps.ToString();
      current_lap++;
      //PitStop();
      //MechIssue();
      //SettingTyreText();

      // Wait for X second
      yield return new WaitForSeconds(2f);
    } while (current_lap <= laps);
    btn_back.SetActive(true);
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

  private void Overtaking()
  {
    Team temp;
    for (int i = 0; i < leaderboard.Count; i++)
    {
      for (int j = 0; j < leaderboard.Count - 1; j++)
      {
        if (leaderboard[j + 1].LapTime - leaderboard[j].LapTime <= 0.2f)
        {
          temp = leaderboard[j];
          leaderboard[j] = leaderboard[j + 1];
          leaderboard[j + 1] = temp;
          Debug.Log("Ultrapassagem");
        }
      }
    }
  }

  public void ShowRaceLeaderboard()
  {
    int contador = 0;
    float gapAux = 0.0f;
    foreach (Team t in leaderboard)
    {
      if (contador == 0)
      {
        first_race.text = t.Pilot.Name;
        gapAux = t.LapTime;
      }
      else if (contador == 1)
      {
        second_race.text = t.Pilot.Name;
        second_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 2)
      {
        third_race.text = t.Pilot.Name;
        third_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 3)
      {
        fourth_race.text = t.Pilot.Name;
        fourth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 4)
      {
        fifth_race.text = t.Pilot.Name;
        fifth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 5)
      {
        sixth_race.text = t.Pilot.Name;
        sixth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 6)
      {
        seventh_race.text = t.Pilot.Name;
        seventh_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 7)
      {
        eighth_race.text = t.Pilot.Name;
        eighth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 8)
      {
        nineth_race.text = t.Pilot.Name;
        nineth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 9)
      {
        tenth_race.text = t.Pilot.Name;
        tenth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }

      contador++;
    }
  }
}
