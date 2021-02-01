using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CampaignMenu : MonoBehaviour
{
  public GameObject game_menu;
  public GameObject management_menu;
  public GameObject race_menu;

  // Start is called before the first frame update
  void Start()
  {
    ShowRace();
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
}
