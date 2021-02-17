using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Assets.Scripts;

public class CampaignMenu : MonoBehaviour
{
  public GameObject game_menu;
  public GameObject management_menu;
  public GameObject race_menu;

  Track track;
  GameSession session;

  public int currentTrack;

  public TextMeshProUGUI NextTrack_text;

  // Start is called before the first frame update
  void Start()
  {
    session = FindObjectOfType<GameSession>();
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;
    //UpdatingNextText();
    ShowRace();
  }
  private void Update()
  {
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;
  }

  public void ShowRace()
  {
    race_menu.SetActive(true);
    management_menu.SetActive(false);
  }

  public void HideRace()
  {
    race_menu.SetActive(false);
    management_menu.SetActive(true);
  }

  public void UpdatingNextText()
  {
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;
  }
}
