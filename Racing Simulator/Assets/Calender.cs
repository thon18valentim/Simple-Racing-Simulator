using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class Calender : MonoBehaviour
{
  public GameObject australia_info;
  public GameObject bahrain_info;
  public GameObject brazil_info;

  public TextMeshProUGUI gp_name;
  public TextMeshProUGUI gp_laps;
  public TextMeshProUGUI gp_aero;
  public TextMeshProUGUI gp_power;
  public TextMeshProUGUI gp_dura;
  public TextMeshProUGUI gp_chassi;

  List<Track> tracks_list = new List<Track>();

    // Start is called before the first frame update
    void Start()
    {
        foreach(Track track in World.tracks)
        {
          tracks_list.Add(track);
        }

    ShowTrackInfo(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void ShowTrackInfo(int i)
  {
    if(i == 0)
    {
      australia_info.SetActive(true);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);

      gp_name.text = tracks_list[i].Name;
      gp_laps.text = tracks_list[i].Laps.ToString() + " Laps";
      gp_aero.text = tracks_list[i].Aerodynamics.ToString() + " Aer";
      gp_chassi.text = tracks_list[i].Chassi.ToString() + " Cha";
      gp_power.text = tracks_list[i].Power.ToString() + " Pow";
      gp_dura.text = tracks_list[i].Durability.ToString() + " Dur";
    }
    else if(i == 1)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(true);
      brazil_info.SetActive(false);

      gp_name.text = tracks_list[i].Name;
      gp_laps.text = tracks_list[i].Laps.ToString() + " Laps";
      gp_aero.text = tracks_list[i].Aerodynamics.ToString() + " Aer";
      gp_chassi.text = tracks_list[i].Chassi.ToString() + " Cha";
      gp_power.text = tracks_list[i].Power.ToString() + " Pow";
      gp_dura.text = tracks_list[i].Durability.ToString() + " Dur";
    }
    else if(i == 2)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(true);

      gp_name.text = tracks_list[i].Name;
      gp_laps.text = tracks_list[i].Laps.ToString() + " Laps";
      gp_aero.text = tracks_list[i].Aerodynamics.ToString() + " Aer";
      gp_chassi.text = tracks_list[i].Chassi.ToString() + " Cha";
      gp_power.text = tracks_list[i].Power.ToString() + " Pow";
      gp_dura.text = tracks_list[i].Durability.ToString() + " Dur";
    }
  }
}
