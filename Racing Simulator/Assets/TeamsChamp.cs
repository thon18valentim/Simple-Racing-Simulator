using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class TeamsChamp : MonoBehaviour
{
  // Teams Text
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

  List<Team> Teamschampionship = new List<Team>();
  GameSession session;

  // Start is called before the first frame update
  void Start()
    {
    session = FindObjectOfType<GameSession>();
    DefineStandings();
    Standings();
    }

  private void DefineStandings()
  {
    int contador = 0;
    foreach (Team team in World.teams)
    {
      if(contador < 10)
        Teamschampionship.Add(team);
      contador++;
    }

    SortStandings();
  }

  private void SortStandings()
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

  public void Standings()
  {
    int contador = 0;

    foreach (Team t in Teamschampionship)
    {
      if (contador == 0)
      {
        primeiro_col.text = t.Name;
        primeiro_pts.text = t.points.ToString();
      }
      else if (contador == 1)
      {
        segundo_col.text = t.Name;
        segundo_pts.text = t.points.ToString();
      }
      else if (contador == 2)
      {
        terceiro_col.text = t.Name;
        terceiro_pts.text = t.points.ToString();
      }
      else if (contador == 3)
      {
        quarto_col.text = t.Name;
        quarto_pts.text = t.points.ToString();
      }
      else if (contador == 4)
      {
        quinto_col.text = t.Name;
        quinto_pts.text = t.points.ToString();
      }
      else if (contador == 5)
      {
        sexto_col.text = t.Name;
        sexto_pts.text = t.points.ToString();
      }
      else if (contador == 6)
      {
        setimo_col.text = t.Name;
        setimo_pts.text = t.points.ToString();
      }
      else if (contador == 7)
      {
        oitavo_col.text = t.Name;
        oitavo_pts.text = t.points.ToString();
      }
      else if (contador == 8)
      {
        nono_col.text = t.Name;
        nono_pts.text = t.points.ToString();
      }
      else if (contador == 9)
      {
        decimo_col.text = t.Name;
        decimo_pts.text = t.points.ToString();
      }

      contador++;
    }
  }
}
