using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class FinalController : MonoBehaviour
{
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

  // Player Final Score
  public TextMeshProUGUI playerPoints;

  List<Team> championship = new List<Team>();
  List<Team> top10 = new List<Team>();
  GameSession session;

  // Start is called before the first frame update
  void Start()
  {
    session = FindObjectOfType<GameSession>();
    DefineStandings();
    Standings();

    pilotName_text.text = session.GetPilotName();
    pilotOver_text.text = session.GetPilotOver().ToString();
    pilotTeam_text.text = session.GetTeamName();
    playerAero_text.text = session.GetAero().ToString();
    playerChassi_text.text = session.GetChassis().ToString();
    playerDura_text.text = session.GetDura().ToString();
    playerPower_text.text = session.GetPower().ToString();
    playerScore_text.text = session.GetPlayerFinalScore().ToString();
    pilotCarDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + FindObjectOfType<GameSession>().GetCarString());
    pilotFaceDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + FindObjectOfType<GameSession>().GetPilotFaceString());

    //session.NewSeason();
    Debug.Log("New Season");
  }

  // Update is called once per frame
  void Update()
  {
    
  }

  public void NextSeason()
  {
    FindObjectOfType<GameSession>().NewSeason();
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
        primeiro_col.text = t.Pilot.Name;
        primeiro_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 1)
      {
        segundo_col.text = t.Pilot.Name;
        segundo_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 2)
      {
        terceiro_col.text = t.Pilot.Name;
        terceiro_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 3)
      {
        quarto_col.text = t.Pilot.Name;
        quarto_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 4)
      {
        quinto_col.text = t.Pilot.Name;
        quinto_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 5)
      {
        sexto_col.text = t.Pilot.Name;
        sexto_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 6)
      {
        setimo_col.text = t.Pilot.Name;
        setimo_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 7)
      {
        oitavo_col.text = t.Pilot.Name;
        oitavo_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 8)
      {
        nono_col.text = t.Pilot.Name;
        nono_pts.text = t.Pilot.points.ToString();
      }
      else if (contador == 9)
      {
        decimo_col.text = t.Pilot.Name;
        decimo_pts.text = t.Pilot.points.ToString();
      }

      contador++;
    }
  }
}
