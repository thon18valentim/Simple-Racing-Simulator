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
  public GameObject austria_info;
  public GameObject singapore_info;
  public GameObject abu_info;
  public GameObject russia_info;
  public GameObject usa_info;
  public GameObject italy_info;
  public GameObject england_info;

  public TextMeshProUGUI gp_name;
  public TextMeshProUGUI country_name;
  public TextMeshProUGUI gp_laps;
  public TextMeshProUGUI gp_aero;
  public TextMeshProUGUI gp_power;
  public TextMeshProUGUI gp_dura;
  public TextMeshProUGUI gp_chassi;

  List<Track> tracks_list = new List<Track>();

  // GP Order Text
  public TextMeshProUGUI gp1;
  public TextMeshProUGUI gp2;
  public TextMeshProUGUI gp3;
  public TextMeshProUGUI gp4;
  public TextMeshProUGUI gp5;
  public TextMeshProUGUI gp6;
  public TextMeshProUGUI gp7;
  public TextMeshProUGUI gp8;
  public TextMeshProUGUI gp9;
  public TextMeshProUGUI gp10;


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

  public void GettingCurrentTrack()
  {
    int current_track = FindObjectOfType<GameSession>().GetCurrentTrack();

    if(current_track == 0)
    {
      gp1.color = new Color(255, 60, 0, 255);
    }
    else if(current_track == 1)
    {
      gp2.color = new Color(255, 60, 0, 255);
    }
    else if (current_track == 2)
    {
      gp3.color = new Color(255, 60, 0, 255);
    }
    else if (current_track == 3)
    {
      gp4.color = new Color(255, 60, 0, 255);
    }
    else if (current_track == 4)
    {
      gp5.color = new Color(255, 60, 0, 255);
    }
    else if (current_track == 5)
    {
      gp6.color = new Color(255, 60, 0, 255);
    }
    else if (current_track == 6)
    {
      gp7.color = new Color(255, 60, 0, 255);
    }
    else if (current_track == 7)
    {
      gp8.color = new Color(255, 60, 0, 255);
    }
    else if (current_track == 8)
    {
      gp9.color = new Color(255, 60, 0, 255);
    }
    else
    {
      gp10.color = new Color(255, 60, 0, 255);
    }
  }

  public void ShowTrackInfo(int i)
  {
    if(i == 0)
    {
      australia_info.SetActive(true);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);
      austria_info.SetActive(false);
      england_info.SetActive(false);
      italy_info.SetActive(false);
      singapore_info.SetActive(false);
      russia_info.SetActive(false);
      usa_info.SetActive(false);
      abu_info.SetActive(false);

    }
    else if(i == 1)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(true);
      brazil_info.SetActive(false);
      austria_info.SetActive(false);
      england_info.SetActive(false);
      italy_info.SetActive(false);
      singapore_info.SetActive(false);
      russia_info.SetActive(false);
      usa_info.SetActive(false);
      abu_info.SetActive(false);

    }
    else if(i == 2)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(true);
      austria_info.SetActive(false);
      england_info.SetActive(false);
      italy_info.SetActive(false);
      singapore_info.SetActive(false);
      russia_info.SetActive(false);
      usa_info.SetActive(false);
      abu_info.SetActive(false);

    }
    else if(i == 3)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);
      austria_info.SetActive(true);
      england_info.SetActive(false);
      italy_info.SetActive(false);
      singapore_info.SetActive(false);
      russia_info.SetActive(false);
      usa_info.SetActive(false);
      abu_info.SetActive(false);

      
    }
    else if(i == 4)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);
      austria_info.SetActive(false);
      england_info.SetActive(true);
      italy_info.SetActive(false);
      singapore_info.SetActive(false);
      russia_info.SetActive(false);
      usa_info.SetActive(false);
      abu_info.SetActive(false);

    }
    else if(i == 5)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);
      austria_info.SetActive(false);
      england_info.SetActive(false);
      italy_info.SetActive(true);
      singapore_info.SetActive(false);
      russia_info.SetActive(false);
      usa_info.SetActive(false);
      abu_info.SetActive(false);

    }
    else if(i == 6)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);
      austria_info.SetActive(false);
      england_info.SetActive(false);
      italy_info.SetActive(false);
      singapore_info.SetActive(true);
      russia_info.SetActive(false);
      usa_info.SetActive(false);
      abu_info.SetActive(false);

    }
    else if(i == 7)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);
      austria_info.SetActive(false);
      england_info.SetActive(false);
      italy_info.SetActive(false);
      singapore_info.SetActive(false);
      russia_info.SetActive(true);
      usa_info.SetActive(false);
      abu_info.SetActive(false);

    }
    else if(i == 8)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);
      austria_info.SetActive(false);
      england_info.SetActive(false);
      italy_info.SetActive(false);
      singapore_info.SetActive(false);
      russia_info.SetActive(false);
      usa_info.SetActive(true);
      abu_info.SetActive(false);

    }
    else if(i == 9)
    {
      australia_info.SetActive(false);
      bahrain_info.SetActive(false);
      brazil_info.SetActive(false);
      austria_info.SetActive(false);
      england_info.SetActive(false);
      italy_info.SetActive(false);
      singapore_info.SetActive(false);
      russia_info.SetActive(false);
      usa_info.SetActive(false);
      abu_info.SetActive(true);

    }

    gp_name.text = tracks_list[i].Name;
    country_name.text = tracks_list[i].Country;
    gp_laps.text = tracks_list[i].Laps.ToString() + " Laps";
    gp_aero.text = tracks_list[i].Aerodynamics.ToString() + " Aer";
    gp_chassi.text = tracks_list[i].Chassi.ToString() + " Cha";
    gp_power.text = tracks_list[i].Power.ToString() + " Pow";
    gp_dura.text = tracks_list[i].Durability.ToString() + " Dur";
  }
}
