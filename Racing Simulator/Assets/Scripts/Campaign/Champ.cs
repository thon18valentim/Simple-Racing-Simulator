using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class Champ : MonoBehaviour
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

  public TextMeshProUGUI onze_col;
  public TextMeshProUGUI doze_col;
  public TextMeshProUGUI treze_col;
  public TextMeshProUGUI quatorze_col;
  public TextMeshProUGUI quinze_col;
  public TextMeshProUGUI dezesseis_col;
  public TextMeshProUGUI dezessete_col;
  public TextMeshProUGUI dezoito_col;
  public TextMeshProUGUI dezenove_col;
  public TextMeshProUGUI vinte_col;

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

  public TextMeshProUGUI onze_pts;
  public TextMeshProUGUI doze_pts;
  public TextMeshProUGUI treze_pts;
  public TextMeshProUGUI quatorze_pts;
  public TextMeshProUGUI quinze_pts;
  public TextMeshProUGUI dezesseis_pts;
  public TextMeshProUGUI dezessete_pts;
  public TextMeshProUGUI dezoito_pts;
  public TextMeshProUGUI dezenove_pts;
  public TextMeshProUGUI vinte_pts;

  // Setting Championship List (Standings)
  List<Team> championship = new List<Team>();
  GameSession session;

  public void Start()
  {
    session = FindObjectOfType<GameSession>();
    DefineStandings();
    Standings();
  }

  // Defining Standings
  private void DefineStandings()
  {
    foreach (Team team in World.teams)
    {
      championship.Add(team);
    }

    SortStandings();
  }

  // Organizing Positions
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

  // Showing Standings
  public void Standings()
  {
    int contador = 0;

    foreach(Team t in championship)
    {
      if (contador == 0)
      {
        primeiro_col.text = t.Pilot.Name;
        primeiro_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          primeiro_col.color = new Color(0, 255, 8, 255);
          primeiro_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 1)
      {
        segundo_col.text = t.Pilot.Name;
        segundo_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          segundo_col.color = new Color(0, 255, 8, 255);
          segundo_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 2)
      {
        terceiro_col.text = t.Pilot.Name;
        terceiro_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          terceiro_col.color = new Color(0, 255, 8, 255);
          terceiro_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 3)
      {
        quarto_col.text = t.Pilot.Name;
        quarto_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          quarto_col.color = new Color(0, 255, 8, 255);
          quarto_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 4)
      {
        quinto_col.text = t.Pilot.Name;
        quinto_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          quinto_col.color = new Color(0, 255, 8, 255);
          quinto_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 5)
      {
        sexto_col.text = t.Pilot.Name;
        sexto_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          sexto_col.color = new Color(0, 255, 8, 255);
          sexto_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 6)
      {
        setimo_col.text = t.Pilot.Name;
        setimo_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          setimo_col.color = new Color(0, 255, 8, 255);
          setimo_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 7)
      {
        oitavo_col.text = t.Pilot.Name;
        oitavo_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          oitavo_col.color = new Color(0, 255, 8, 255);
          oitavo_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 8)
      {
        nono_col.text = t.Pilot.Name;
        nono_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          nono_col.color = new Color(0, 255, 8, 255);
          nono_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 9)
      {
        decimo_col.text = t.Pilot.Name;
        decimo_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          decimo_col.color = new Color(0, 255, 8, 255);
          decimo_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 10)
      {
        onze_col.text = t.Pilot.Name;
        onze_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          onze_col.color = new Color(0, 255, 8, 255);
          onze_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 11)
      {
        doze_col.text = t.Pilot.Name;
        doze_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          doze_col.color = new Color(0, 255, 8, 255);
          doze_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 12)
      {
        treze_col.text = t.Pilot.Name;
        treze_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          treze_col.color = new Color(0, 255, 8, 255);
          treze_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 13)
      {
        quatorze_col.text = t.Pilot.Name;
        quatorze_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          quatorze_col.color = new Color(0, 255, 8, 255);
          quatorze_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 14)
      {
        quinze_col.text = t.Pilot.Name;
        quinze_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          quinze_col.color = new Color(0, 255, 8, 255);
          quinze_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 15)
      {
        dezesseis_col.text = t.Pilot.Name;
        dezesseis_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          dezesseis_col.color = new Color(0, 255, 8, 255);
          dezesseis_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 16)
      {
        dezessete_col.text = t.Pilot.Name;
        dezessete_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          dezessete_col.color = new Color(0, 255, 8, 255);
          dezessete_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 17)
      {
        dezoito_col.text = t.Pilot.Name;
        dezoito_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          dezoito_col.color = new Color(0, 255, 8, 255);
          dezoito_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 18)
      {
        dezenove_col.text = t.Pilot.Name;
        dezenove_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          dezenove_col.color = new Color(0, 255, 8, 255);
          dezenove_pts.color = new Color(0, 255, 8, 255);
        }
      }
      else if (contador == 19)
      {
        vinte_col.text = t.Pilot.Name;
        vinte_pts.text = t.Pilot.points.ToString();
        if (t.Pilot.Id < 3)
        {
          vinte_col.color = new Color(0, 255, 8, 255);
          vinte_pts.color = new Color(0, 255, 8, 255);
        }
      }

      contador++;
    }
  }
}
