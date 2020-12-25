using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CampaignMenu : MonoBehaviour
{
  public GameObject financial_menu;
  public GameObject pilot_menu;
  public GameObject teams_menu;
  public GameObject game_menu;

  public float player_money = 150000;
  public TextMeshProUGUI money_text;

    // Start is called before the first frame update
    void Start()
    {
    HideFin();
    HidePilo();
    HideTeams();
    Cash();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void ShowFin() //Show Financial Menu
  {
    financial_menu.SetActive(true);
    game_menu.SetActive(false);
  }
  public void HideFin()
  {
    financial_menu.SetActive(false);
    game_menu.SetActive(true);
  }
  public void ShowPilo()
  {
    pilot_menu.SetActive(true);
    game_menu.SetActive(false);
  }
  public void HidePilo()
  {
    pilot_menu.SetActive(false);
    game_menu.SetActive(true);
  }
  public void ShowTeams()
  {
    teams_menu.SetActive(true);
    game_menu.SetActive(false);
  }
  public void HideTeams()
  {
    teams_menu.SetActive(false);
    game_menu.SetActive(true);
  }
  public void Cash()
  {
    money_text.text = "$ " + player_money.ToString();
  }
}
