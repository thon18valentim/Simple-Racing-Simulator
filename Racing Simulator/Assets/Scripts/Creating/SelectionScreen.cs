using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using TMPro;

public class SelectionScreen : MonoBehaviour
{
  // Pilot 1 Texts
  public TextMeshProUGUI namePilot1; 
  public TextMeshProUGUI countryPilot1;
  public TextMeshProUGUI agePilot1;
  public TextMeshProUGUI overPilot1;
  public GameObject pilot1;

  // Pilot 2 Texts
  public TextMeshProUGUI namePilot2;
  public TextMeshProUGUI countryPilot2;
  public TextMeshProUGUI agePilot2;
  public TextMeshProUGUI overPilot2;
  public GameObject pilot2;

  // Pilot 3 Texts
  public TextMeshProUGUI namePilot3;
  public TextMeshProUGUI countryPilot3;
  public TextMeshProUGUI agePilot3;
  public TextMeshProUGUI overPilot3;
  public GameObject pilot3;

  // Creating Scene Arrow
  public GameObject arrow;
  // Setting Team Name
  public string teamName;

  // Setting Sounds
  public AudioSource conf_sound;
  public AudioSource btn_sound;

  // Integer for pilot selection
  int selection = 1;

  private void Start()
  {
    // Getting the info from World.cs
    namePilot1.text = World.pilots[10].Name; 
    countryPilot1.text = World.pilots[10].Country;
    agePilot1.text = World.pilots[10].Age.ToString() + " Years";
    overPilot1.text = World.pilots[10].Over.ToString() + " Over";
    pilot1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[10].PilotString);

    namePilot2.text = World.pilots[11].Name;
    countryPilot2.text = World.pilots[11].Country;
    agePilot2.text = World.pilots[11].Age.ToString() + " Years";
    overPilot2.text = World.pilots[11].Over.ToString() + " Over";
    pilot2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[11].PilotString);

    namePilot3.text = World.pilots[12].Name;
    countryPilot3.text = World.pilots[12].Country;
    agePilot3.text = World.pilots[12].Age.ToString() + " Years";
    overPilot3.text = World.pilots[12].Over.ToString() + " Over";
    pilot3.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[12].PilotString);
  }

  private void Update()
  {
    // Setting Arrow Commands
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      btn_sound.Play();
      arrow.transform.position = new Vector2(arrow.transform.position.x - 5f, arrow.transform.position.y);
      CheckBoundaries();
      selection--;
      if (selection < 0)
        selection = 0;
    }

    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      btn_sound.Play();
      arrow.transform.position = new Vector2(arrow.transform.position.x + 5f, arrow.transform.position.y);
      CheckBoundaries();
      selection++;
      if (selection > 2)
        selection = 2;
    }

    if (Input.GetKeyDown(KeyCode.Return))
    {
      conf_sound.Play();
      // Setting the player chosen pilot on game session
      FindObjectOfType<GameSession>().SetPlayerPilot(selection);
      FindObjectOfType<SceneLoader>().LoadNextScene();
    }
  }

  // Checking the boundaries in which the arrow pointer can move
  public void CheckBoundaries()
  {
    if (arrow.transform.position.x > 5f)
    {
      arrow.transform.position = new Vector2(5f, 2f);
    }
    if (arrow.transform.position.x < -5f)
    {
      arrow.transform.position = new Vector2(-5f, 2f);
    }
  }
}
