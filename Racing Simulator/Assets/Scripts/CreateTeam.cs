using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateTeam : MonoBehaviour
{
  SceneLoader sl;
  Team team;

  // Object reference to the team name, logo and car
  public GameObject logo;
  public TextMeshProUGUI teamName;
  public GameObject car;

  // Array for team names
  string[] names = { "Italy Team", "American Mono Team", "Yell Motors", "Silver Tech" };
  // Sprite array for logos and cars
  public Sprite[] logos;
  public Sprite[] cars;

  // Integer for changing between teams
  int selection = 0;

  private void Start()
  {
    SetValues(); // Showing the first team
    sl = FindObjectOfType<SceneLoader>();
  }

  private void Update()
  {
    // On pressing left or right arrow change between teams
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      selection--;
      if (selection < 0)
        selection = 2;
      SetValues();
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      selection++;
      if (selection > 2)
        selection = 0;
      SetValues();
    }

    if (Input.GetKeyDown(KeyCode.Return))
    {
      sl.LoadNextScene();
    }
  }

  // Setting the corretc team name, logo and car
  public void SetValues()
  {
    teamName.text = names[selection].ToString();
    logo.GetComponent<SpriteRenderer>().sprite = logos[selection];
    car.GetComponent<SpriteRenderer>().sprite = cars[selection];
  }

  public int GetChosenTeamId()
  {
    return selection;
  }
}
