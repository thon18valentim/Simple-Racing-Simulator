using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class FinalController : MonoBehaviour
{
  // Sound Control
  public GameObject sound_play;
  public GameObject sound_mute;
  public AudioSource back_sound;

  // Player Texts
  public TextMeshProUGUI pilotName_text;
  public TextMeshProUGUI pilotOver_text;
  public TextMeshProUGUI pilotTeam_text;
  public GameObject pilotCarDisplay;
  public GameObject pilotFaceDisplay;
  public TextMeshProUGUI playerScore_text;

  public TextMeshProUGUI playerAero_text;
  public TextMeshProUGUI playerChassi_text;
  public TextMeshProUGUI playerPower_text;
  public TextMeshProUGUI playerDura_text;

  // Table 1
  // Pilots Text
  public TextMeshProUGUI primeiro_col;
  public TextMeshProUGUI segundo_col;
  public TextMeshProUGUI terceiro_col;
  public TextMeshProUGUI quarto_col;
  public TextMeshProUGUI quinto_col;
  public TextMeshProUGUI sexto_col;
  public TextMeshProUGUI setimo_col;
  public TextMeshProUGUI oitavo_col;
  public TextMeshProUGUI nono_col;
  public TextMeshProUGUI decimo_col;

  // Points Text
  public TextMeshProUGUI primeiro_pts;
  public TextMeshProUGUI segundo_pts;
  public TextMeshProUGUI terceiro_pts;
  public TextMeshProUGUI quarto_pts;
  public TextMeshProUGUI quinto_pts;
  public TextMeshProUGUI sexto_pts;
  public TextMeshProUGUI setimo_pts;
  public TextMeshProUGUI oitavo_pts;
  public TextMeshProUGUI nono_pts;
  public TextMeshProUGUI decimo_pts;

  // Table
  // Teams Text
  public TextMeshProUGUI primeiro_team;
  public TextMeshProUGUI segundo_team;
  public TextMeshProUGUI terceiro_team;
  public TextMeshProUGUI quarto_team;
  public TextMeshProUGUI quinto_team;

  // Points Text
  public TextMeshProUGUI primeiroteam_pts;
  public TextMeshProUGUI segundoteam_pts;
  public TextMeshProUGUI terceiroteam_pts;
  public TextMeshProUGUI quartoteam_pts;
  public TextMeshProUGUI quintoteam_pts;

  public TextMeshProUGUI temporada_text;

  // Player Final Score
  public TextMeshProUGUI playerPoints;

  // Table
  List<Team> championship = new List<Team>();
  List<Team> Teamschampionship = new List<Team>();
  // Pilots
  List<Team> top10 = new List<Team>();
  // Teams
  List<Team> top5 = new List<Team>();
  GameSession session;

  private void Awake()
  {
    back_sound.Play();
  }

  // Start is called before the first frame update
  void Start()
  {
    session = FindObjectOfType<GameSession>();
    DefineStandings();
    Standings();
    DefineTop5();
    Top5();

    temporada_text.text = "Season " + session.GetSeasonYear().ToString();
    //ShowNextYear();

    FindObjectOfType<GameSession>().NextYear();
    Debug.Log("New Year");
    Debug.Log(session.GetSeasonYear());

    pilotName_text.text = session.GetPilotName();
    pilotOver_text.text = session.GetPilotOver().ToString();
    pilotTeam_text.text = session.GetTeamName();
    playerAero_text.text = session.GetAero().ToString();
    playerChassi_text.text = session.GetChassis().ToString();
    playerDura_text.text = session.GetDura().ToString();
    playerPower_text.text = session.GetPower().ToString();
    playerScore_text.text = session.GetPilotSeasonScore().ToString();
    pilotCarDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + FindObjectOfType<GameSession>().GetCarString());
    pilotFaceDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + FindObjectOfType<GameSession>().GetPilotFaceString());

    //session.NewSeason();
    Debug.Log("New Season");
  }

  // Update is called once per frame
  void Update()
  {
    
  }

  public void muteSound()
  {
    back_sound.Stop();
    sound_play.SetActive(false);
    sound_mute.SetActive(true);
  }
  public void playSound()
  {
    back_sound.Play();
    sound_play.SetActive(true);
    sound_mute.SetActive(false);
  }

  public void NextSeason()
  {
    FindObjectOfType<GameSession>().NewSeason();
  }
  public void NextYear()
  {
    
  }
  public void ShowNextYear()
  {
    temporada_text.text = "Season " + session.GetSeasonYear().ToString();
  }

  private void DefineStandings()
  {
    int contador = 0;
    foreach (Team team in World.teams)
    {
      championship.Add(team);
    }

    SortStandings();

    foreach (Team team in championship)
    {
      if (contador < 10)
        top10.Add(team);
      contador++;
    }
  }

  private void DefineTop5()
  {
    int contador = 0;
    foreach (Team team in World.teams)
    {
      if (contador < 10)
        Teamschampionship.Add(team);
      contador++;
    }

    SortTop5();
  }

  private void SortTop5()
  {
    Team temp;
    for (int i = 0; i < Teamschampionship.Count; i++)
    {
      for (int j = 0; j < Teamschampionship.Count - 1; j++)
      {
        if (Teamschampionship[j + 1].points > Teamschampionship[j].points)
        {
          temp = Teamschampionship[j];
          Teamschampionship[j] = Teamschampionship[j + 1];
          Teamschampionship[j + 1] = temp;
        }
      }
    }
  }

  public void Top5()
  {
    int contador = 0;

    foreach (Team t in Teamschampionship)
    {
      if (contador == 0)
      {
        primeiro_team.text = t.Name;
        primeiroteam_pts.text = t.points.ToString();
      }
      else if (contador == 1)
      {
        segundo_team.text = t.Name;
        segundoteam_pts.text = t.points.ToString();
      }
      else if (contador == 2)
      {
        terceiro_team.text = t.Name;
        terceiroteam_pts.text = t.points.ToString();
      }
      else if (contador == 3)
      {
        quarto_team.text = t.Name;
        quartoteam_pts.text = t.points.ToString();
      }
      else if (contador == 4)
      {
        quinto_team.text = t.Name;
        quintoteam_pts.text = t.points.ToString();
      }

      contador++;
    }
  }

  private void SortStandings()
  {
    Team temp;
    for (int i = 0; i < championship.Count; i++)
    {
      for (int j = 0; j < championship.Count - 1; j++)
      {
        if (championship[j + 1].Pilot.points > championship[j].Pilot.points)
        {
          temp = championship[j];
          championship[j] = championship[j + 1];
          championship[j + 1] = temp;
        }
      }
    }
  }

  public void Standings()
  {
    int contador = 0;

    foreach (Team t in top10)
    {
      if (contador == 0)
      {
        t.Pilot.Title += 1;
        t.Pilot.AddSeasonScore(68);
        primeiro_col.text = t.Pilot.Name;
        primeiro_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 1)
      {
        t.Pilot.AddSeasonScore(28);
        segundo_col.text = t.Pilot.Name;
        segundo_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 2)
      {
        t.Pilot.AddSeasonScore(28);
        terceiro_col.text = t.Pilot.Name;
        terceiro_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 3)
      {
        t.Pilot.AddSeasonScore(28);
        quarto_col.text = t.Pilot.Name;
        quarto_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 4)
      {
        t.Pilot.AddSeasonScore(28);
        quinto_col.text = t.Pilot.Name;
        quinto_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 5)
      {
        t.Pilot.AddSeasonScore(28);
        sexto_col.text = t.Pilot.Name;
        sexto_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 6)
      {
        t.Pilot.AddSeasonScore(28);
        setimo_col.text = t.Pilot.Name;
        setimo_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 7)
      {
        t.Pilot.AddSeasonScore(28);
        oitavo_col.text = t.Pilot.Name;
        oitavo_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 8)
      {
        t.Pilot.AddSeasonScore(28);
        nono_col.text = t.Pilot.Name;
        nono_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 9)
      {
        t.Pilot.AddSeasonScore(28);
        decimo_col.text = t.Pilot.Name;
        decimo_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 10)
      {
        t.Pilot.AddSeasonScore(13);
      }
      else if (contador == 11)
      {
        t.Pilot.AddSeasonScore(13);
      }
      else if (contador == 12)
      {
        t.Pilot.AddSeasonScore(5);
      }
      else if (contador == 13)
      {
        t.Pilot.AddSeasonScore(5);
      }
      else if (contador == 14)
      {
        t.Pilot.AddSeasonScore(5);
      }

      if (t.Pilot.Id <= 3)
      {
        if (t.Pilot.points >= 40)
        {
          t.Pilot.AddSeasonScore(12);
        }
      }

      contador++;
    }
  }
}
