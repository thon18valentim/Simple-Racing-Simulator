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
  public GameObject player_face;
  public GameObject player_car;
  public TextMeshProUGUI player_titles;
  public TextMeshProUGUI player_wins;
  public TextMeshProUGUI player_score;

    // Start is called before the first frame update
    void Start()
    {
    pilot_name.text = FindObjectOfType<GameSession>().GetPilotName();
    pilot_country.text = FindObjectOfType<GameSession>().GetPilotNation();
    pilot_over.text = "Over " + FindObjectOfType<GameSession>().GetPilotOver().ToString();
    pilot_age.text = "Age " + FindObjectOfType<GameSession>().GetPilotAge().ToString();
    pilot_team.text = FindObjectOfType<GameSession>().GetTeamName();
    player_face.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + FindObjectOfType<GameSession>().GetPilotFaceString());
    player_car.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + FindObjectOfType<GameSession>().GetCarString());
    player_titles.text = FindObjectOfType<GameSession>().GetPilotTitle().ToString() + " Titles";
    player_wins.text = FindObjectOfType<GameSession>().GetPilotWins().ToString() + " Wins";
    player_score.text = FindObjectOfType<GameSession>().GetPilotSeasonScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
