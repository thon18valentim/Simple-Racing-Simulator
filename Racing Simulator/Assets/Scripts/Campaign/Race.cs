using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Assets.Scripts;

public class Race : MonoBehaviour
{
  // Sound Control
  public GameObject sound_play;
  public GameObject sound_mute;

  // Set Qualification and Race Screen
  public GameObject quali_screen;
  public GameObject race_screen;

  public TextMeshProUGUI pilot_marker1;
  public TextMeshProUGUI pilot_marker2;
  public TextMeshProUGUI pilot_marker3;
  public TextMeshProUGUI pilot_marker4;
  public TextMeshProUGUI pilot_marker5;
  public TextMeshProUGUI pilot_marker6;
  public TextMeshProUGUI pilot_marker7;
  public TextMeshProUGUI pilot_marker8;
  public TextMeshProUGUI pilot_marker9;
  public TextMeshProUGUI pilot_marker10;
  public TextMeshProUGUI pilot_marker11;
  public TextMeshProUGUI pilot_marker12;
  public TextMeshProUGUI pilot_marker13;
  public TextMeshProUGUI pilot_marker14;
  public TextMeshProUGUI pilot_marker15;
  public TextMeshProUGUI pilot_marker16;
  public TextMeshProUGUI pilot_marker17;
  public TextMeshProUGUI pilot_marker18;
  public TextMeshProUGUI pilot_marker19;
  public TextMeshProUGUI pilot_marker20;

  List<TextMeshProUGUI> Markers = new List<TextMeshProUGUI>();

  // Set Current Track Img
  public GameObject australia_track;
  public GameObject bahrain_track;
  public GameObject brazil_track;
  public GameObject austria_track;
  public GameObject singapore_track;
  public GameObject abu_track;
  public GameObject russia_track;
  public GameObject usa_track;
  public GameObject italy_track;
  public GameObject england_track;

  // Management of Qualification Texts
  public TextMeshProUGUI first_place;
  public TextMeshProUGUI second_place;
  public TextMeshProUGUI third_place;
  public TextMeshProUGUI fourth_place;
  public TextMeshProUGUI fifth_place;

  // Management Grand Prix Name and lap Text 
  public TextMeshProUGUI gp_name;
  public TextMeshProUGUI gp_lap;

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

  public TextMeshProUGUI eleventh_race;
  public TextMeshProUGUI twelfth_race;
  public TextMeshProUGUI thirdth_race;
  public TextMeshProUGUI fourteenth_race;
  public TextMeshProUGUI fifteenth_race;
  public TextMeshProUGUI sixteenth_race;
  public TextMeshProUGUI seventeenth_race;
  public TextMeshProUGUI eighteenth_race;
  public TextMeshProUGUI nineteenth_race;
  public TextMeshProUGUI twenty_race;

  // Management of Race Time Texts
  //public TextMeshProUGUI first_time;
  public TextMeshProUGUI second_time;
  public TextMeshProUGUI third_time;
  public TextMeshProUGUI fourth_time;
  public TextMeshProUGUI fifth_time;
  public TextMeshProUGUI sixth_time;
  public TextMeshProUGUI seventh_time;
  public TextMeshProUGUI eighth_time;
  public TextMeshProUGUI nineth_time;
  public TextMeshProUGUI tenth_time;

  public TextMeshProUGUI eleventh_time;
  public TextMeshProUGUI twelfth_time;
  public TextMeshProUGUI thirdth_time;
  public TextMeshProUGUI fourteenth_time;
  public TextMeshProUGUI fifteenth_time;
  public TextMeshProUGUI sixteenth_time;
  public TextMeshProUGUI seventeenth_time;
  public TextMeshProUGUI eighteenth_time;
  public TextMeshProUGUI nineteenth_time;
  public TextMeshProUGUI twenty_time;

  // Tyres Text
  public TextMeshProUGUI first_tyre;
  public TextMeshProUGUI sec_tyre;
  public TextMeshProUGUI thi_tyre;
  public TextMeshProUGUI four_tyre;
  public TextMeshProUGUI fif_tyre;
  public TextMeshProUGUI six_tyre;
  public TextMeshProUGUI sev_tyre;
  public TextMeshProUGUI eig_tyre;
  public TextMeshProUGUI nin_tyre;
  public TextMeshProUGUI ten_tyre;

  public TextMeshProUGUI eleventh_tyre;
  public TextMeshProUGUI twelfth_tyre;
  public TextMeshProUGUI thirdth_tyre;
  public TextMeshProUGUI fourteenth_tyre;
  public TextMeshProUGUI fifteenth_tyre;
  public TextMeshProUGUI sixteenth_tyre;
  public TextMeshProUGUI seventeenth_tyre;
  public TextMeshProUGUI eighteenth_tyre;
  public TextMeshProUGUI nineteenth_tyre;
  public TextMeshProUGUI twenty_tyre;

  // Quali Cars Display
  public GameObject car1;
  public GameObject car2;
  public GameObject car3;
  public GameObject car4;
  public GameObject car5;

  // Overtaking Screen
  public TextMeshProUGUI overtaking_text;
  public TextMeshProUGUI pitStop_text;
  public TextMeshProUGUI mechIssue_text;

  // Player Pit Stop Laps Text
  public TextMeshProUGUI pit1_text;
  public TextMeshProUGUI pit2_text;
  public TextMeshProUGUI pit3_text;

  // Player Pit Stop Laps
  public int pit1;
  public int pit2;
  public int pit3;

  public int chosen_tyre;
  public int tyre_life;

  // Setting race sounds
  public AudioSource race_sound;
  public AudioSource pitStop_sound;
  public AudioSource box_sound;

  // Setting back to menu btn
  public GameObject btn_back;

  // Getting Pit Stop 3 GameObjects
  public GameObject arrowRight;
  public GameObject arrowLeft;
  public GameObject trashIcon;
  public GameObject plusIcon;

  // Player Tyre Life Text
  public TextMeshProUGUI tyreLife_text;

  // Player Chosen Tyre Marker
  public TextMeshProUGUI soft_marker;
  public TextMeshProUGUI med_marker;
  public TextMeshProUGUI hard_marker;

  // Player select tyre sound
  public AudioSource tyreSelect_sound;

  // Race Speed Variable
  public float raceSpeed = 3f;
  public TextMeshProUGUI raceSpeed_text;

  public int contador = 0;

  public TextMeshProUGUI tempoText;
  public float tempo = 3;

  Track track;
  GameSession session;

  // Creating Leaderboard
  List<Team> leaderboard = new List<Team>();

  public GameObject flag;

  // GP Current Laps
  int current_lap = 0;

  private void Start()
  {
    PopulateMarkers();
    session = FindObjectOfType<GameSession>();

    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    session.IncreasingPilotsOver();
    //IncreasingPilotsOver();
    flag.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Flags/" + World.tracks[0].TrackString);

    DefineLeaderboard();

    ShowQuali();
    gp_name.text = track.Name;
    ShowQualiLeaderboard();

    pit1 = 20;
    pit2 = 30;
    pit3 = 40;

    tyreLife_text.text = "Tyre Life 20";

    foreach (Team team in leaderboard)
    {
      if (team.Pilot.Id < 4)
      {
        team.pneu_id = 30;
        team.pneu_dura = 25;
      }
    }

    pit1_text.text = pit1.ToString();
    pit2_text.text = pit2.ToString();
    pit3_text.text = pit3.ToString();

    raceSpeed_text.text = "x 1";

    chosen_tyre = 1;
  }

  // Racing
  public void StartRace()
  {
    race_sound.Play();

    StartCoroutine("Wait");

    FindObjectOfType<GameSession>().NextRace();
  }

  // Reducing each car lap time per lap
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

  // Defining the correct leaderboard positions
  private void DefineLeaderboard()
  {
    foreach (Team team in World.teams)
    {
      team.SetScore(CalculateTeamScore(team));
      team.pneu_id = 30;
      team.pneu_dura = 25;
      leaderboard.Add(team);
    }

    SortLeaderboard();

    float time = 100.00f;
    foreach (Team t in leaderboard)
    {
      t.SetLapTime(time);
      time++;
    }

    contador = 0;
    foreach(Team team in leaderboard)
    {
      if (contador == 0)
      {
        car1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + leaderboard[0].CarString);
      }
      else if (contador == 1)
      {
        car2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + leaderboard[1].CarString);
      }
      else if (contador == 2)
      {
        car3.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + leaderboard[2].CarString);
      }
      else if (contador == 3)
      {
        car4.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + leaderboard[3].CarString);
      }
      else if(contador == 4)
      {
        car5.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + leaderboard[4].CarString);
      }
      contador++;
    }
  }

  // Organizing Positions
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

  // Cars overtaking each other
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
          overtaking_text.text = leaderboard[j].Pilot.Name + " is overtaking " + leaderboard[j + 1].Pilot.Name;
        }
      }
    }
  }

  // Creating each team score for Qualification & Race
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

  // Showing Qualification elements
  public void ShowQuali()
  {
    race_screen.SetActive(false);
    quali_screen.SetActive(true);
  }

  // Showing Race elements
  public void ShowRace()
  {
    quali_screen.SetActive(false);
    race_screen.SetActive(true);
  }

  // Showing Qualification leaderboard
  public void ShowQualiLeaderboard()
  {
    int contador = 0;
    foreach(Team t in leaderboard)
    {
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

  // Showing Race leaderboard
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
        if (t.LapTime - gapAux > 60)
        {
          second_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          second_time.text = "+2 lap";
        }
        else
          second_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 2)
      {
        third_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          third_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          third_time.text = "+2 lap";
        }
        else
          third_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 3)
      {
        fourth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          fourth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          fourth_time.text = "+2 lap";
        }
        else
          fourth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 4)
      {
        fifth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          fifth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          fifth_time.text = "+2 lap";
        }
        else
          fifth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 5)
      {
        sixth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          sixth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          sixth_time.text = "+2 lap";
        }
        else
          sixth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 6)
      {
        seventh_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          seventh_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          seventh_time.text = "+2 lap";
        }
        else
          seventh_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 7)
      {
        eighth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          eighth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          eighth_time.text = "+2 lap";
        }
        else
          eighth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 8)
      {
        nineth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          nineth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          nineth_time.text = "+2 lap";
        }
        else
          nineth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 9)
      {
        tenth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          tenth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          tenth_time.text = "+2 lap";
        }
        else
          tenth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 10)
      {
        eleventh_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          eleventh_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          eleventh_time.text = "+2 lap";
        }
        else
          eleventh_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 11)
      {
        twelfth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          twelfth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          twelfth_time.text = "+2 lap";
        }
        else
          twelfth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 12)
      {
        thirdth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          thirdth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          thirdth_time.text = "+2 lap";
        }
        else
          thirdth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 13)
      {
        fourteenth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          fourteenth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          fourteenth_time.text = "+2 lap";
        }
        else
          fourteenth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 14)
      {
        fifteenth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          fifteenth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          fifteenth_time.text = "+2 lap";
        }
        else
          fifteenth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 15)
      {
        sixteenth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          sixteenth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          sixteenth_time.text = "+2 lap";
        }
        else
          sixteenth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 16)
      {
        seventeenth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          seventeenth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          seventeenth_time.text = "+2 lap";
        }
        else
          seventeenth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 17)
      {
        eighteenth_race.text = t.Pilot.Name;
        if (t.LapTime - gapAux > 60)
        {
          eighteenth_time.text = "+1 lap";
        }
        else if (t.LapTime - gapAux > 120)
        {
          eighteenth_time.text = "+2 lap";
        }
        else
          eighteenth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 18)
      {
        nineteenth_race.text = t.Pilot.Name;
        if(t.LapTime - gapAux > 60)
        {
          nineteenth_time.text = "+1 lap";
        }
        else if(t.LapTime - gapAux > 120)
        {
          nineteenth_time.text = "+2 lap";
        }
        else
          nineteenth_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }
      else if (contador == 19)
      {
        twenty_race.text = t.Pilot.Name;
        if(t.LapTime - gapAux > 60)
        {
          twenty_time.text = "+1 lap";
        }
        else if(t.LapTime - gapAux > 120)
        {
          twenty_time.text = "+2 lap";
        }else
          twenty_time.text = "+" + (t.LapTime - gapAux).ToString("N1");
      }

      contador++;
    }
  }

  // Racing func
  IEnumerator Wait()
  {
    int laps = track.Laps;
    //int current_lap = 0;
    do
    {
      int contador = 0;
      foreach (Team team in leaderboard)
      {
        team.SetScore(CalculateTeamScore(team));

        ReduceLapTime(team);
        ShowRaceLeaderboard();
        team.pneu_dura--;
        if(team.Pilot.Id == 1 || team.Pilot.Id == 2 || team.Pilot.Id == 3)
        {
          Markers[contador].color = new Color(255, 217, 0, 255);
          Markers[contador].text = "You";
        }
        else
        {
          Markers[contador].color = new Color(0, 0, 0, 0);
          Markers[contador].text = "IA";
        }
        contador++;
      }
      gp_lap.text = "Lap " + current_lap.ToString() + " / " + laps.ToString();
      current_lap++;
      VerifyTyreLife();
      PlayerLifeTyre();
      PitStop();
      MechIssue();
      SettingTyreText();
      Overtaking();
      // Wait for X second
      yield return new WaitForSeconds(raceSpeed);
    } while (current_lap <= laps);
    btn_back.SetActive(true);
    GivingPoints();
    session.GameOver();
  }

  public void GivingPoints()
  {
    int contador = 0;

    foreach (Team t in leaderboard)
    {
      if(contador == 0)
      {
        t.Pilot.points += 25;
        t.Pilot.Wins += 1;
        t.points += 25;
        t.Pilot.AddSeasonScore(85);
      }
      else if(contador == 1)
      {
        t.Pilot.points += 18;
        t.points += 18;
        t.Pilot.AddSeasonScore(55);
      }
      else if(contador == 2)
      {
        t.Pilot.points += 15;
        t.points += 15;
        t.Pilot.AddSeasonScore(55);
      }
      else if(contador == 3)
      {
        t.Pilot.points += 12;
        t.points += 12;
        t.Pilot.AddSeasonScore(30);
      }
      else if(contador == 4)
      {
        t.Pilot.points += 10;
        t.points += 10;
        t.Pilot.AddSeasonScore(30);
      }
      else if(contador == 5)
      {
        t.Pilot.points += 8;
        t.points += 8;
        t.Pilot.AddSeasonScore(10);
      }
      else if(contador == 6)
      {
        t.Pilot.points += 6;
        t.points += 6;
        t.Pilot.AddSeasonScore(10);
      }
      else if(contador == 7)
      {
        t.Pilot.points += 4;
        t.points += 4;
        t.Pilot.AddSeasonScore(10);
      }
      else if(contador == 8)
      {
        t.Pilot.points += 2;
        t.points += 2;
        t.Pilot.AddSeasonScore(10);
      }
      else if(contador == 9)
      {
        t.Pilot.points += 1;
        t.points += 1;
        t.Pilot.AddSeasonScore(10);
      }
      else
      {
        t.Pilot.points += 0;
        t.points += 0;
      }

      contador++;
    }

    session.IncreasePlayerStatus(2);
    SumTeamsPoints();
  }

  // Doing AI and Player Pit Stop
  public void PitStop()
  {
    int sort_pneu;
    int pit_time;

    foreach (Team t in leaderboard)
    {
      if(t.Pilot.Id > 3)
      {
        if (t.pneu_dura <= 11 && current_lap < (track.Laps-5))
        {
          sort_pneu = RandomNumberGenerator.NumberBetween(1, 4);
          if (sort_pneu == 1)
          {
            t.pneu_id = 30;
            t.pneu_dura = 25;
            pit_time = RandomNumberGenerator.NumberBetween(18, 25);
            t.SetLapTime(t.LapTime + pit_time);
          }
          else if (sort_pneu == 2)
          {
            t.pneu_id = 27;
            t.pneu_dura = 35;
            pit_time = RandomNumberGenerator.NumberBetween(18, 25);
            t.SetLapTime(t.LapTime + pit_time);
          }
          else if (sort_pneu == 3)
          {
            t.pneu_id = 24;
            t.pneu_dura = 45;
            pit_time = RandomNumberGenerator.NumberBetween(18, 25);
            t.SetLapTime(t.LapTime + pit_time);
          }
          else
          {
            t.pneu_id = 27;
            t.pneu_dura = 35;
            pit_time = RandomNumberGenerator.NumberBetween(18, 25);
            t.SetLapTime(t.LapTime + pit_time);
          }
        }
        pitStop_text.text = t.Pilot.Name + " is changing tyres";
      }
      else
      {
        if(current_lap == pit1)
        {
          Debug.Log("Player no Pit Stop 1");
          pitStop_sound.Play();
          box_sound.Play();
          pit1_text.color = new Color(0,242,59);
          t.pneu_id = chosen_tyre;
          if (chosen_tyre == 30)
          {
            t.pneu_dura = 25;
            Debug.Log("Player colocando Pneus Macios");
          }
          else if (chosen_tyre == 27)
          {
            t.pneu_dura = 35;
            Debug.Log("Player colocando Pneus Médios");
          }
          else
          {
            t.pneu_dura = 45;
            Debug.Log("Player colocando Pneus Duros");
          }
          pit_time = RandomNumberGenerator.NumberBetween(18, 25);
          t.SetLapTime(t.LapTime + pit_time);
          pitStop_text.text = t.Pilot.Name + " is changing tyres";
        }
        else if(current_lap == pit2)
        {
          Debug.Log("Player no Pit Stop 2");
          pitStop_sound.Play();
          box_sound.Play();
          pit2_text.color = new Color(0, 242, 59);
          t.pneu_id = chosen_tyre;
          if (chosen_tyre == 30)
          {
            t.pneu_dura = 25;
            Debug.Log("Player colocando Pneus Macios");
          }
          else if (chosen_tyre == 27)
          {
            t.pneu_dura = 35;
            Debug.Log("Player colocando Pneus Médios");
          }
          else
          {
            t.pneu_dura = 45;
            Debug.Log("Player colocando Pneus Duros");
          }
          pit_time = RandomNumberGenerator.NumberBetween(18, 25);
          t.SetLapTime(t.LapTime + pit_time);
          pitStop_text.text = t.Pilot.Name + " is changing tyres";
        }
        else if (current_lap == pit3)
        {
          Debug.Log("Player no Pit Stop 3");
          pitStop_sound.Play();
          box_sound.Play();
          pit3_text.color = new Color(0, 242, 59);
          t.pneu_id = chosen_tyre;
          if (chosen_tyre == 30)
          {
            t.pneu_dura = 25;
            Debug.Log("Player colocando Pneus Macios");
          }
          else if (chosen_tyre == 27)
          {
            t.pneu_dura = 35;
            Debug.Log("Player colocando Pneus Médios");
          }
          else
          {
            t.pneu_dura = 45;
            Debug.Log("Player colocando Pneus Duros");
          }
          pit_time = RandomNumberGenerator.NumberBetween(18, 25);
          t.SetLapTime(t.LapTime + pit_time);
          pitStop_text.text = t.Pilot.Name + " is changing tyres";
        }
      }
    }
  }

  // Pilots getting mech Issues
  public void MechIssue()
  {
    int sort;

    foreach(Team t in World.teams)
    {
      if(t.Car.Durability <= 10)
      {
        sort = RandomNumberGenerator.NumberBetween(1,25);
        if(sort == 1)
        {
          t.SetLapTime(t.LapTime + 5.0f);
          mechIssue_text.text = t.Pilot.Name + " had mech Issues";
        }
      }
      else if(t.Car.Durability > 10 && t.Car.Durability <= 15)
      {
        sort = RandomNumberGenerator.NumberBetween(1, 30);
        if (sort == 1)
        {
          t.SetLapTime(t.LapTime + 5.0f);
          mechIssue_text.text = t.Pilot.Name + " had mech Issues";
        }
      }
      else if (t.Car.Durability > 15 && t.Car.Durability <= 20)
      {
        sort = RandomNumberGenerator.NumberBetween(1, 35);
        if (sort == 1)
        {
          t.SetLapTime(t.LapTime + 5.0f);
          mechIssue_text.text = t.Pilot.Name + " had mech Issues";
        }
      }
      else if (t.Car.Durability > 20)
      {
        sort = RandomNumberGenerator.NumberBetween(1, 55);
        if (sort == 1)
        {
          t.SetLapTime(t.LapTime + 5.0f);
          mechIssue_text.text = t.Pilot.Name + " had mech Issues";
        }
      }
    }
  }

  // Muting Race Sound
  public void StopMusic()
  {
    race_sound.Stop();
  }

  // Setting Correct tyre Text
  public void SettingTyreText()
  {
    int contador = 0;

    foreach(Team t in leaderboard)
    {
      if(t.pneu_id == 30)
      {
        if(contador == 0)
        {
          first_tyre.text = "S";
        }
        else if (contador == 1)
        {
          sec_tyre.text = "S";
        }
        else if (contador == 2)
        {
          thi_tyre.text = "S";
        }
        else if (contador == 3)
        {
          four_tyre.text = "S";
        }
        else if (contador == 4)
        {
          fif_tyre.text = "S";
        }
        else if (contador == 5)
        {
          six_tyre.text = "S";
        }
        else if (contador == 6)
        {
          sev_tyre.text = "S";
        }
        else if(contador == 7)
        {
          eig_tyre.text = "S";
        }
        else if (contador == 8)
        {
          nin_tyre.text = "S";
        }
        else if (contador == 9)
        {
          ten_tyre.text = "S";
        }
        else if (contador == 10)
        {
          eleventh_tyre.text = "S";
        }
        else if (contador == 11)
        {
          twelfth_tyre.text = "S";
        }
        else if (contador == 12)
        {
          thirdth_tyre.text = "S";
        }
        else if (contador == 13)
        {
          fourteenth_tyre.text = "S";
        }
        else if (contador == 14)
        {
          fifteenth_tyre.text = "S";
        }
        else if (contador == 15)
        {
          sixteenth_tyre.text = "S";
        }
        else if (contador == 16)
        {
          seventeenth_tyre.text = "S";
        }
        else if (contador == 17)
        {
          eighteenth_tyre.text = "S";
        }
        else if (contador == 18)
        {
          nineteenth_tyre.text = "S";
        }
        else if (contador == 19)
        {
          twenty_tyre.text = "S";
        }
      }
      else if(t.pneu_id == 27)
      {
        if (contador == 0)
        {
          first_tyre.text = "M";
        }
        else if (contador == 1)
        {
          sec_tyre.text = "M";
        }
        else if (contador == 2)
        {
          thi_tyre.text = "M";
        }
        else if (contador == 3)
        {
          four_tyre.text = "M";
        }
        else if (contador == 4)
        {
          fif_tyre.text = "M";
        }
        else if (contador == 5)
        {
          six_tyre.text = "M";
        }
        else if (contador == 6)
        {
          sev_tyre.text = "M";
        }
        else if (contador == 7)
        {
          eig_tyre.text = "M";
        }
        else if (contador == 8)
        {
          nin_tyre.text = "M";
        }
        else if (contador == 9)
        {
          ten_tyre.text = "M";
        }
        else if (contador == 10)
        {
          eleventh_tyre.text = "M";
        }
        else if (contador == 11)
        {
          twelfth_tyre.text = "M";
        }
        else if (contador == 12)
        {
          thirdth_tyre.text = "M";
        }
        else if (contador == 13)
        {
          fourteenth_tyre.text = "M";
        }
        else if (contador == 14)
        {
          fifteenth_tyre.text = "M";
        }
        else if (contador == 15)
        {
          sixteenth_tyre.text = "M";
        }
        else if (contador == 16)
        {
          seventeenth_tyre.text = "M";
        }
        else if (contador == 17)
        {
          eighteenth_tyre.text = "M";
        }
        else if (contador == 18)
        {
          nineteenth_tyre.text = "M";
        }
        else if (contador == 19)
        {
          twenty_tyre.text = "M";
        }
      }
      else if(t.pneu_id == 24)
      {
        if (contador == 0)
        {
          first_tyre.text = "H";
        }
        else if (contador == 1)
        {
          sec_tyre.text = "H";
        }
        else if (contador == 2)
        {
          thi_tyre.text = "H";
        }
        else if (contador == 3)
        {
          four_tyre.text = "H";
        }
        else if (contador == 4)
        {
          fif_tyre.text = "H";
        }
        else if (contador == 5)
        {
          six_tyre.text = "H";
        }
        else if (contador == 6)
        {
          sev_tyre.text = "H";
        }
        else if (contador == 7)
        {
          eig_tyre.text = "H";
        }
        else if (contador == 8)
        {
          nin_tyre.text = "H";
        }
        else if (contador == 9)
        {
          ten_tyre.text = "H";
        }
        else if (contador == 10)
        {
          eleventh_tyre.text = "H";
        }
        else if (contador == 11)
        {
          twelfth_tyre.text = "H";
        }
        else if (contador == 12)
        {
          thirdth_tyre.text = "H";
        }
        else if (contador == 13)
        {
          fourteenth_tyre.text = "H";
        }
        else if (contador == 14)
        {
          fifteenth_tyre.text = "H";
        }
        else if (contador == 15)
        {
          sixteenth_tyre.text = "H";
        }
        else if (contador == 16)
        {
          seventeenth_tyre.text = "H";
        }
        else if (contador == 17)
        {
          eighteenth_tyre.text = "H";
        }
        else if (contador == 18)
        {
          nineteenth_tyre.text = "H";
        }
        else if (contador == 19)
        {
          twenty_tyre.text = "H";
        }
      }

      contador++;
    }
  }

  // Showing Correct Track Image
  public void ShowGpImg()
  {
    if(track.Id == 1)
    {
      australia_track.SetActive(true);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
      austria_track.SetActive(false);
      england_track.SetActive(false);
      italy_track.SetActive(false);
      singapore_track.SetActive(false);
      russia_track.SetActive(false);
      usa_track.SetActive(false);
      abu_track.SetActive(false);
    }
    else if(track.Id == 2)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(true);
      brazil_track.SetActive(false);
      austria_track.SetActive(false);
      england_track.SetActive(false);
      italy_track.SetActive(false);
      singapore_track.SetActive(false);
      russia_track.SetActive(false);
      usa_track.SetActive(false);
      abu_track.SetActive(false);
    }
    else if(track.Id == 3)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(true);
      austria_track.SetActive(false);
      england_track.SetActive(false);
      italy_track.SetActive(false);
      singapore_track.SetActive(false);
      russia_track.SetActive(false);
      usa_track.SetActive(false);
      abu_track.SetActive(false);
    }
    else if(track.Id == 4)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
      austria_track.SetActive(true);
      england_track.SetActive(false);
      italy_track.SetActive(false);
      singapore_track.SetActive(false);
      russia_track.SetActive(false);
      usa_track.SetActive(false);
      abu_track.SetActive(false);
    }
    else if (track.Id == 5)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
      austria_track.SetActive(false);
      england_track.SetActive(true);
      italy_track.SetActive(false);
      singapore_track.SetActive(false);
      russia_track.SetActive(false);
      usa_track.SetActive(false);
      abu_track.SetActive(false);
    }
    else if (track.Id == 6)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
      austria_track.SetActive(false);
      england_track.SetActive(false);
      italy_track.SetActive(true);
      singapore_track.SetActive(false);
      russia_track.SetActive(false);
      usa_track.SetActive(false);
      abu_track.SetActive(false);
    }
    else if (track.Id == 7)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
      austria_track.SetActive(false);
      england_track.SetActive(false);
      italy_track.SetActive(false);
      singapore_track.SetActive(true);
      russia_track.SetActive(false);
      usa_track.SetActive(false);
      abu_track.SetActive(false);
    }
    else if (track.Id == 8)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
      austria_track.SetActive(false);
      england_track.SetActive(false);
      italy_track.SetActive(false);
      singapore_track.SetActive(false);
      russia_track.SetActive(true);
      usa_track.SetActive(false);
      abu_track.SetActive(false);
    }
    else if (track.Id == 9)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
      austria_track.SetActive(false);
      england_track.SetActive(false);
      italy_track.SetActive(false);
      singapore_track.SetActive(false);
      russia_track.SetActive(false);
      usa_track.SetActive(true);
      abu_track.SetActive(false);
    }
    else if (track.Id == 10)
    {
      australia_track.SetActive(false);
      bahrain_track.SetActive(false);
      brazil_track.SetActive(false);
      austria_track.SetActive(false);
      england_track.SetActive(false);
      italy_track.SetActive(false);
      singapore_track.SetActive(false);
      russia_track.SetActive(false);
      usa_track.SetActive(false);
      abu_track.SetActive(true);
    }
  }

  // Sum Pilot 1 and 2 Points
  private void SumTeamsPoints()
  {
    World.teams[0].points += World.teams[10].points;
    World.teams[1].points += World.teams[11].points;
    World.teams[2].points += World.teams[12].points;
    World.teams[3].points += World.teams[13].points;
    World.teams[4].points += World.teams[14].points;
    World.teams[5].points += World.teams[15].points;
    World.teams[6].points += World.teams[16].points;
    World.teams[7].points += World.teams[17].points;
    World.teams[8].points += World.teams[18].points;
    World.teams[9].points += World.teams[19].points;

    World.teams[10].points = 0;
    World.teams[11].points = 0;
    World.teams[12].points = 0;
    World.teams[13].points = 0;
    World.teams[14].points = 0;
    World.teams[15].points = 0;
    World.teams[16].points = 0;
    World.teams[17].points = 0;
    World.teams[18].points = 0;
    World.teams[19].points = 0;
  }

  // Populating Pilots Markes
  private void PopulateMarkers()
  {
    Markers.Add(pilot_marker1);
    Markers.Add(pilot_marker2);
    Markers.Add(pilot_marker3);
    Markers.Add(pilot_marker4);
    Markers.Add(pilot_marker5);
    Markers.Add(pilot_marker6);
    Markers.Add(pilot_marker7);
    Markers.Add(pilot_marker8);
    Markers.Add(pilot_marker9);
    Markers.Add(pilot_marker10);
    Markers.Add(pilot_marker11);
    Markers.Add(pilot_marker12);
    Markers.Add(pilot_marker13);
    Markers.Add(pilot_marker14);
    Markers.Add(pilot_marker15);
    Markers.Add(pilot_marker16);
    Markers.Add(pilot_marker17);
    Markers.Add(pilot_marker18);
    Markers.Add(pilot_marker19);
    Markers.Add(pilot_marker20);
  }

  // Increasing selected Lap to Pit
  public void IncreasePitLap(int id)
  {
    if(id == 1)
    {
      pit1++;
      if (pit1 > track.Laps)
        pit1 = 0;

      pit1_text.text = pit1.ToString();
    }
    else if(id == 2)
    {
      pit2++;
      if (pit2 > track.Laps)
        pit2 = 0;
      pit2_text.text = pit2.ToString();
    }
    else if (id == 3)
    {
      pit3++;
      if (pit3 > track.Laps)
        pit3 = 0;
      pit3_text.text = pit3.ToString();
    }
  }

  // Decrease selected Lap to Pit
  public void DecreasePitLap(int id)
  {
    if (id == 1)
    {
      pit1--;
      if (pit1 < 0)
        pit1 = track.Laps;

      pit1_text.text = pit1.ToString();
    }
    else if (id == 2)
    {
      pit2--;
      if (pit2 < 0)
        pit2 = track.Laps;
      pit2_text.text = pit2.ToString();
    }
    else if (id == 3)
    {
      pit3--;
      if (pit3 < 0)
        pit3 = track.Laps;
      pit3_text.text = pit3.ToString();
    }
  }

  // Selecting a Tyre
  public void SelectPitTyre(int tyre_id)
  {
    chosen_tyre = tyre_id;
    Debug.Log("Tyre Selected " + tyre_id.ToString());
    if (tyre_id == 30)
    {
      soft_marker.color = new Color(20,156,4,255);
      med_marker.color = new Color(0, 0, 0);
      hard_marker.color = new Color(0, 0, 0);
      tyreSelect_sound.Play();
    }
    else if (tyre_id == 27)
    {
      soft_marker.color = new Color(0, 0, 0);
      med_marker.color = new Color(20, 156, 4, 255);
      hard_marker.color = new Color(0, 0, 0);
      tyreSelect_sound.Play();
    }
    else
    {
      soft_marker.color = new Color(0, 0, 0);
      med_marker.color = new Color(0, 0, 0);
      hard_marker.color = new Color(20, 156, 4, 255);
      tyreSelect_sound.Play();
    }
  }

  // Desabling third Pit Stop
  public void DesablePitStop()
  {
    pit3 = 0;
    pit3_text.text = pit3.ToString();
    pit3_text.color = new Color(255,0,0,255);
    arrowRight.SetActive(false);
    arrowLeft.SetActive(false);
    //trashIcon.SetActive(false);
    //plusIcon.SetActive(true);
  }

  // Ableing third Pit Stop
  public void AblePitStop()
  {
    pit3 = 0;
    pit3_text.text = pit3.ToString();
    pit3_text.color = new Color(0, 0, 0, 0);
    arrowRight.SetActive(true);
    arrowLeft.SetActive(true);
    trashIcon.SetActive(true);
    plusIcon.SetActive(false);
  }

  // Verifying Tyre Life
  public void VerifyTyreLife()
  {
    foreach(Team team in leaderboard)
    {
      if (team.pneu_dura < 10)
        team.SetLapTime(team.LapTime + 3.5f);
      else if (team.pneu_dura < 0)
        team.SetLapTime(team.LapTime + 6.0f);
    }
  }

  // Showing Current Player Life Tyre
  public void PlayerLifeTyre()
  {
    foreach (Team team in leaderboard)
    {
      if (team.Pilot.Id < 4)
      {
        tyreLife_text.text = "Tyre Life " + team.pneu_dura.ToString();
        if (team.pneu_dura < 11)
          tyreLife_text.color = new Color(255, 0, 0, 255);
        else
          tyreLife_text.color = new Color(20, 156, 4, 255);
      }
    }
  }

  // Changing Race Simulation Speed
  public void ChangingRaceSpeed(int func)
  {
    if (func == 1) // Plus
    {
      raceSpeed -= 0.5f;
      if (raceSpeed < 1.0f)
      {
        raceSpeed = 1.0f;
      }
      UpdateSpeedText(raceSpeed);
    }
    if (func == 2) // Less
    {
      raceSpeed += 0.5f;
      if (raceSpeed > 4.0f)
      {
        raceSpeed = 4.0f;
      }
      UpdateSpeedText(raceSpeed);
    }
  }

  // Updating Speed Text
  public void UpdateSpeedText(float speed)
  {
    if (speed == 1.0f)
      raceSpeed_text.text = "x 3";
    else if (speed == 1.5f)
      raceSpeed_text.text = "x 2.5";
    else if (speed == 2.0f)
      raceSpeed_text.text = "x 2";
    else if (speed == 2.5f)
      raceSpeed_text.text = "x 1.5";
    else if (speed == 3.0f)
      raceSpeed_text.text = "x 1";
    else if (speed == 3.5f)
      raceSpeed_text.text = "x 0.5";
    else if (speed == 4.0f)
      raceSpeed_text.text = "x 0.1";
  }

  // Muting Sound
  public void muteSound()
  {
    race_sound.Stop();
    sound_play.SetActive(false);
    sound_mute.SetActive(true);
  }
  // Playing Sound
  public void playSound()
  {
    race_sound.Play();
    sound_play.SetActive(true);
    sound_mute.SetActive(false);
  }
}
