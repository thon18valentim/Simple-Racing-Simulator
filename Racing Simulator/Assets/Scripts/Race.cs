using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Race : MonoBehaviour
{
  //Gp Text
  public TextMeshProUGUI gp_name;
  public TextMeshProUGUI gp_country;

  //Pit markers
  public TextMeshProUGUI mark1;
  public TextMeshProUGUI mark2;

  //Lap Count
  int current_lap = 1;

  //Lap marker
  public TextMeshProUGUI mark_lap;

  // Integer for changing the pit lap
  int select1 = 10;
  int select2 = 30;

  public TextMeshProUGUI[] grid_corrida = new TextMeshProUGUI[10];

  private void Start()
  {
    SetPit();
    mark_lap.text = "Laps: " + current_lap.ToString() + " / " + World.tracks[0].Laps;

    gp_name.text = World.tracks[0].Name;
    gp_country.text = World.tracks[0].Country;
   
    grid_corrida[0].text = World.pilots[0].Name;
    grid_corrida[1].text = World.pilots[1].Name;
    grid_corrida[2].text = World.pilots[2].Name;
    grid_corrida[3].text = World.pilots[3].Name;
    grid_corrida[4].text = World.pilots[4].Name;
    grid_corrida[5].text = World.pilots[5].Name;
    grid_corrida[6].text = World.pilots[6].Name;
    grid_corrida[7].text = World.pilots[7].Name;
    grid_corrida[8].text = World.pilots[8].Name;
    grid_corrida[9].text = World.pilots[9].Name;
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.A))
    {
      select1--;
      if(select1 < 1)
      {
        select1 = World.tracks[0].Laps;
      }
      SetPit();
    }

    if (Input.GetKeyDown(KeyCode.S))
    {
      select2--;
      if(select2 < 1)
      {
        select2 = World.tracks[0].Laps;
      }
      SetPit();
    }

    if (Input.GetKeyDown(KeyCode.D))
    {
      select1++;
      if (select1 > World.tracks[0].Laps)
      {
        select1 = 1;
      }
      SetPit();
    }

    if (Input.GetKeyDown(KeyCode.F))
    {
      select2++;
      if (select2 > World.tracks[0].Laps)
      {
        select2 = 1;
      }
      SetPit();
    }
  }

  public void SetPit()
  {
    mark1.text = select1.ToString();
    mark2.text = select2.ToString();
  }
}
