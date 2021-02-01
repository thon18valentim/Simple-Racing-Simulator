using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateTeam : MonoBehaviour
{
  // Object reference to the team name, logo and car
  public GameObject logo;
  public TextMeshProUGUI teamName;
  public GameObject car;

  // Audios
  public AudioSource conf_sound;
  public AudioSource btn_sound;

  // Integer for changing between teams
  int selection = 0;

  private void Start()
  {
    SetValues(); // Showing the first team
  }

  private void Update()
  {
    // On pressing left or right arrow change between teams
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      btn_sound.Play();
      selection--;
      if (selection < 0)
        selection = 9;
      SetValues();
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      btn_sound.Play();
      selection++;
      if (selection > 9)
        selection = 0;
      SetValues();
    }

    if (Input.GetKeyDown(KeyCode.Return))
    {
      conf_sound.Play();
      // Setting the player chosen team on game session
      FindObjectOfType<GameSession>().SetPlayerTeam(selection);
      FindObjectOfType<SceneLoader>().LoadNextScene();
    }
  }

  // Setting the correct team name, logo and car
  public void SetValues()
  {
    teamName.text = World.teams[selection].Name;
    logo.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Logos/" + World.teams[selection].LogoString); // Accessing the sprites via file name in the resoruces file
    car.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + World.teams[selection].CarString);
  }
}
