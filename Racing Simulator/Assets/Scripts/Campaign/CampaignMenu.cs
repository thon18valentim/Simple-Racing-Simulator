using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CampaignMenu : MonoBehaviour
{
  public GameObject game_menu;
  public GameObject management_menu;
  public GameObject race_menu;

  public float player_money = 150000;
  public TextMeshProUGUI money_text;

    // Start is called before the first frame update
    void Start()
    {
    ShowRace();
    Cash();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void Cash()
  {
    money_text.text = "$ " + player_money.ToString();
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
