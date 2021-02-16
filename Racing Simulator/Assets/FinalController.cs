using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class FinalController : MonoBehaviour
{
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

  List<Team> championship = new List<Team>();
  GameSession session;

  // Start is called before the first frame update
  void Start()
  {
    session = FindObjectOfType<GameSession>();
    DefineStandings();
    Standings();
  }

  // Update is called once per frame
  void Update()
  {

  }

  private void DefineStandings()
  {
    foreach (Team team in World.teams)
    {
      championship.Add(team);
    }

    SortStandings();
  }

  private void SortStandings()
  {
    Team temp;
    for (int i = 0; i < championship.Count; i++)
    {
      for (int j = 0; j < championship.Count - 1; j++)
      {
        if (championship[j + 1].points > championship[j].points)
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

    foreach (Team t in championship)
    {
      if (contador == 0)
      {
        primeiro_col.text = t.Pilot.Name;
        primeiro_pts.text = t.points.ToString();
      }
      else if (contador == 1)
      {
        segundo_col.text = t.Pilot.Name;
        segundo_pts.text = t.points.ToString();
      }
      else if (contador == 2)
      {
        terceiro_col.text = t.Pilot.Name;
        terceiro_pts.text = t.points.ToString();
      }
      else if (contador == 3)
      {
        quarto_col.text = t.Pilot.Name;
        quarto_pts.text = t.points.ToString();
      }
      else if (contador == 4)
      {
        quinto_col.text = t.Pilot.Name;
        quinto_pts.text = t.points.ToString();
      }
      else if (contador == 5)
      {
        sexto_col.text = t.Pilot.Name;
        sexto_pts.text = t.points.ToString();
      }
      else if (contador == 6)
      {
        setimo_col.text = t.Pilot.Name;
        setimo_pts.text = t.points.ToString();
      }
      else if (contador == 7)
      {
        oitavo_col.text = t.Pilot.Name;
        oitavo_pts.text = t.points.ToString();
      }
      else if (contador == 8)
      {
        nono_col.text = t.Pilot.Name;
        nono_pts.text = t.points.ToString();
      }
      else if (contador == 9)
      {
        decimo_col.text = t.Pilot.Name;
        decimo_pts.text = t.points.ToString();
      }

      contador++;
    }
  }
}
