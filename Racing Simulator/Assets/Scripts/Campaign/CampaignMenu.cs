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
  public GameObject email_menu;

  public TextMeshProUGUI email_mandatory;
  public TextMeshProUGUI email_subject;
  public TextMeshProUGUI email_body;
  public TextMeshProUGUI email_date;

  public TextMeshProUGUI week_text;

  Track track;
  GameSession session;

  public int currentTrack;

  public int email_selection = 0;

  public TextMeshProUGUI NextTrack_text;

  // Start is called before the first frame update
  void Start()
  {
    session = FindObjectOfType<GameSession>();
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;

    week_text.text = "Month " + (FindObjectOfType<GameSession>().GetCurrentWeek()+1).ToString();

    ShowRace();
    ShowingEmail(0);
  }
  private void Update()
  {
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;

    week_text.text = "Month " + (FindObjectOfType<GameSession>().GetCurrentWeek() + 1).ToString();

    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      email_selection++;

      if (email_selection > World.emails.Count)
        email_selection = 0;

      ShowingEmail(email_selection);
    }
    else if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      email_selection--;

      if (email_selection < 0)
        email_selection = World.emails.Count;

      ShowingEmail(email_selection);
    }
  }

  public void ShowRace()
  {
    race_menu.SetActive(true);
    management_menu.SetActive(false);
    email_menu.SetActive(false);
  }

  public void HideRace()
  {
    race_menu.SetActive(false);
    management_menu.SetActive(true);
    email_menu.SetActive(false);
  }

  public void ShowEmailInbox()
  {
    race_menu.SetActive(false);
    management_menu.SetActive(false);
    email_menu.SetActive(true);
  }

  public void UpdatingNextText()
  {
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;
  }

  // Advance between emails
  public void AdvanceEmail()
  {
    email_selection++;

    if (email_selection > World.emails.Count)
      email_selection = 0;

    ShowingEmail(email_selection);
  }

  public void BackEmail()
  {
    email_selection--;

    if (email_selection < 0)
      email_selection = World.emails.Count;

    ShowingEmail(email_selection);
  }

  // Set the correct email Text
  public void ShowingEmail(int week)
  {
    email_mandatory.text = World.emails[week].Mandatory;
    email_subject.text = World.emails[week].Subject;
    email_body.text = World.emails[week].Body;
    email_date.text = World.emails[week].Date;
  }
}
