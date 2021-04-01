using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Profile : MonoBehaviour
{
  public TextMeshProUGUI pilot_name;
  public TextMeshProUGUI pilot_age;
  public TextMeshProUGUI pilot_team;
  public TextMeshProUGUI pilot_over;
  public TextMeshProUGUI pilot_country;

    // Start is called before the first frame update
    void Start()
    {
    pilot_name.text = FindObjectOfType<GameSession>().GetPilotName();
    pilot_country.text = FindObjectOfType<GameSession>().GetPilotNation();
    pilot_over.text = FindObjectOfType<GameSession>().GetPilotOver().ToString();
    pilot_age.text = FindObjectOfType<GameSession>().GetPilotAge().ToString();
    pilot_team.text = FindObjectOfType<GameSession>().GetTeamName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
