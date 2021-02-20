using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class ImprovementsScene : MonoBehaviour
{
  public List<TextMeshProUGUI> scoreText = new List<TextMeshProUGUI>();
  public List<GameObject> pointers = new List<GameObject>();

  public GameObject pilotFace;
  public GameObject carDisplay;
  public GameObject arrow;

  public TextMeshProUGUI PilotNameDisplay;
  public TextMeshProUGUI PilotOverDisplay;

  public TextMeshProUGUI player_points;
  public TextMeshProUGUI power;
  public TextMeshProUGUI aero;
  public TextMeshProUGUI dura;
  public TextMeshProUGUI chassis;

  public AudioSource conf_sound;
  public AudioSource btn_sound;

  GameSession session;

  int selection = 0;

  private void Start()
  {
    session = FindObjectOfType<GameSession>();

    // Loading player pilot and car images
    pilotFace.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + FindObjectOfType<GameSession>().GetPilotFaceString());
    carDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + FindObjectOfType<GameSession>().GetCarString());
    PilotOverDisplay.text = session.GetPilotOver().ToString();
    PilotNameDisplay.text = session.GetPilotName();
  }

  // Update is called once per frame
  void Update()
  {
    // Player points for improvements
    player_points.text = session.GetPoints().ToString() + " pts";
    power.text = session.GetPower().ToString();
    aero.text = session.GetAero().ToString();
    dura.text = session.GetDura().ToString();
    chassis.text = session.GetChassis().ToString();

    DisableTexts(selection);

    // Adding points to desired category
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      btn_sound.Play();
      arrow.transform.position = new Vector2(arrow.transform.position.x, arrow.transform.position.y - 1.11f);
      CheckBoundaries();
      selection++;
      if (selection > 3)
        selection = 3;
      DisableTexts(selection);
    }

    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      btn_sound.Play();
      arrow.transform.position = new Vector2(arrow.transform.position.x, arrow.transform.position.y + 1.11f);
      CheckBoundaries();
      selection--;
      if (selection < 0)
        selection = 0;
      DisableTexts(selection);
    }

    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      conf_sound.Play();
      switch (selection)
      {
        case 0:
          session.IncreaseStatus("power");
          break;
        case 1:
          session.IncreaseStatus("durability");
          break;
        case 2:
          session.IncreaseStatus("aerodynamics");
          break;
        case 3:
          session.IncreaseStatus("chassi");
          break;
      }
    }

    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      conf_sound.Play();
      switch (selection)
      {
        case 0:
          session.DecreaseStatus("power");
          break;
        case 1:
          session.DecreaseStatus("durability");
          break;
        case 2:
          session.DecreaseStatus("aerodynamics");
          break;
        case 3:
          session.DecreaseStatus("chassi");
          break;
      }
    }

    if (Input.GetKeyDown(KeyCode.Return))
    {
      conf_sound.Play();
      //Loading Next Scene on Return click
      FindObjectOfType<SceneLoader>().LoadNextScene();
    }
  }

  private void DisableTexts(int s)
  { 
    for (int i = 0; i < 4; i++)
    {
      if (i == s)
      {
        scoreText[i].text = (session.GetCarStatus(s) + 1).ToString();
        pointers[i].SetActive(true);
      }
      else
      {
        scoreText[i].text = "";
        pointers[i].SetActive(false);
      }
        
    }
  }

  public void CheckBoundaries()
  {
    if (arrow.transform.position.y < -0.88f)
    {
      arrow.transform.position = new Vector2(-4.5f, -0.88f);
    }
    if (arrow.transform.position.y > 2.45f)
    {
      arrow.transform.position = new Vector2(-4.5f, 2.45f);
    }
  }
}
