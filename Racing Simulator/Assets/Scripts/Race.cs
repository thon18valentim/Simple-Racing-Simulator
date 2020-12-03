using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Race : MonoBehaviour
{
  //Gp Text
  public TextMeshProUGUI gp_name;
  public TextMeshProUGUI gp_country;

  public TextMeshProUGUI[] grid_corrida = new TextMeshProUGUI[10];

  private void Start()
  {
    
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
    
  }
}
