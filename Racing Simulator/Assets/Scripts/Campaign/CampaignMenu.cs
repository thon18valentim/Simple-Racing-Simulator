using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Assets.Scripts;

public class CampaignMenu : MonoBehaviour
{
  // Setting Campaign Modals
  public GameObject game_menu;
  public GameObject email_menu;
  public GameObject profile_menu;
  public GameObject challenge_menu;
  public GameObject exit_popup;

  // Setting Email struct
  public TextMeshProUGUI email_mandatory;
  public TextMeshProUGUI email_subject;
  public TextMeshProUGUI email_body;
  public TextMeshProUGUI email_date;

  // Creating Track and GameSession vars
  Track track;
  GameSession session;

  // Current Track Var
  public int currentTrack;

  // Controlling email selection
  public int email_selection = 0;

  // Setting Next Track Text
  public TextMeshProUGUI NextTrack_text;

  // Setting Email inbox and count
  public List<Email> email_to_show = new List<Email>();
  public int email_count;

  // Start is called before the first frame update
  void Start()
  {
    session = FindObjectOfType<GameSession>();
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;

    //week_text.text = "Month " + (FindObjectOfType<GameSession>().GetCurrentWeek()+1).ToString();
    SettingEmailDisplay();

  }
  private void Update()
  {
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;
    SettingEmailDisplay();
  }

  // Hiding Email inbox
  public void HideMenuInbox()
  {
    game_menu.SetActive(true);
    email_menu.SetActive(false);
    profile_menu.SetActive(false);
    challenge_menu.SetActive(false);
  }

  // Showing Email inbox
  public void ShowEmailInbox()
  {
    game_menu.SetActive(false);
    email_menu.SetActive(true);
    profile_menu.SetActive(false);
    challenge_menu.SetActive(false);
  }

  // Showing Profile Modal
  public void ShowProfile()
  {
    game_menu.SetActive(false);
    email_menu.SetActive(false);
    profile_menu.SetActive(true);
    challenge_menu.SetActive(false);
  }

  // Hiding Profile Modal
  public void HideProfile()
  {
    game_menu.SetActive(true);
    email_menu.SetActive(false);
    profile_menu.SetActive(false);
    challenge_menu.SetActive(false);
  }

  // Showing Challenges Modal
  public void ShowChallenge()
  {
    game_menu.SetActive(false);
    email_menu.SetActive(false);
    profile_menu.SetActive(false);
    challenge_menu.SetActive(true);
  }

  // Hiding Challenge Modal
  public void HideChallenge()
  {
    game_menu.SetActive(true);
    email_menu.SetActive(false);
    profile_menu.SetActive(false);
    challenge_menu.SetActive(false);
  }

  // Showing Exit Popup Modal
  public void ShowExit()
  {
    profile_menu.SetActive(false);
    exit_popup.SetActive(true);
  }

  // Hiding Exit Popup Modal
  public void HideExit()
  {
    profile_menu.SetActive(true);
    exit_popup.SetActive(false);
  }

  // Updating Next Race Text
  public void UpdatingNextText()
  {
    track = World.tracks[FindObjectOfType<GameSession>().GetCurrentTrack()];
    NextTrack_text.text = track.Name;
  }

  // Advance between emails
  public void AdvanceEmail()
  {
    email_selection++;

    if (email_selection > CountDisplayEmail())
      email_selection = 0;

    ShowingEmail(email_selection);
  }

  public void BackEmail()
  {
    email_selection--;

    if (email_selection < 0)
      email_selection = CountDisplayEmail();

    ShowingEmail(email_selection);
  }

  // Set the correct email Text
  public void ShowingEmail(int selection)
  {
    if (email_to_show[selection].IsDisplay())
    {
      email_mandatory.text = email_to_show[selection].Mandatory;
      email_subject.text = email_to_show[selection].Subject;
      email_body.text = email_to_show[selection].Body;
      email_date.text = email_to_show[selection].Date;
    }
  }

  // Setting correct email to display
  public void SettingEmailDisplay()
  {
    foreach (Email mail in World.emails)
    {
      if (FindObjectOfType<GameSession>().GetCurrentTrack() == 0)
      {
        if(mail.Id == 1)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 1");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 1)
      {
        if(mail.Id == 2)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 2");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 2)
      {
        if (mail.Id == 3)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 3");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 3)
      {
        if (mail.Id == 4)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 4");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 4)
      {
        if (mail.Id == 5)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 5");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 5)
      {
        if (mail.Id == 6)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 6");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 6)
      {
        if (mail.Id == 7)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 7");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 7)
      {
        if (mail.Id == 8)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 8");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 8)
      {
        if (mail.Id == 9)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 9");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
      else if (FindObjectOfType<GameSession>().GetCurrentTrack() == 9)
      {
        if(mail.Id == 10)
        {
          mail.setDisplay(true);
          email_to_show.Add(mail);
          //Debug.Log("Setando email id 10");
        }
        else
        {
          mail.setDisplay(false);
        }
      }
    } 
  }

  // Counting emails to display
  public int CountDisplayEmail()
  {
    int count = 0;

    foreach(Email mail in email_to_show)
    {
      if (mail.IsDisplay())
      {
        count++;
      }
    }
    return count; 
  }
}
