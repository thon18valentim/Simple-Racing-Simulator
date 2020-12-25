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

  public TextMeshProUGUI points;
  public TextMeshProUGUI power;
  public TextMeshProUGUI aero;
  public TextMeshProUGUI dura;
  public TextMeshProUGUI chassis;

  int selection = 0;

  private void Start()
  {
    pilotFace.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + FindObjectOfType<GameSession>().GetPilotFaceString());
    carDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + FindObjectOfType<GameSession>().GetCarString());
  }

  // Update is called once per frame
  void Update()
  {
    points.text = FindObjectOfType<GameSession>().GetPoints().ToString();
    power.text = FindObjectOfType<GameSession>().GetPower().ToString();
    aero.text = FindObjectOfType<GameSession>().GetAero().ToString();
    dura.text = FindObjectOfType<GameSession>().GetDura().ToString();
    chassis.text = FindObjectOfType<GameSession>().GetChassis().ToString();

    DisableTexts(selection);

    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      selection++;
      if (selection > 3)
        selection = 3;
      DisableTexts(selection);
    }

    if (Input.GetKeyUp(KeyCode.UpArrow))
    {
      selection--;
      if (selection < 0)
        selection = 0;
      DisableTexts(selection);
    }

    if (Input.GetKeyDown(KeyCode.Return))
    {
      //Loading Next Scene on Return click
      FindObjectOfType<SceneLoader>().LoadScene(1);
    }
  }

  private void DisableTexts(int x)
  { 
    for (int i = 0; i < 4; i++)
    {
      if (i == x)
      {
        scoreText[i].text = (FindObjectOfType<GameSession>().GetPower() + 1).ToString();
        pointers[i].SetActive(true);
      }
      else
      {
        scoreText[i].text = "";
        pointers[i].SetActive(false);
      }
        
    }
  }

  public void DurabilityBtn()
  {
    FindObjectOfType<GameSession>().IncreaseStatus("durability");
  }

  public void DuraLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseStatus("durability");
  }

  public void PowerBtn()
  {
    FindObjectOfType<GameSession>().IncreaseStatus("power");
  }

  public void PowerLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseStatus("power");
  }

  public void AerodynamicsBtn()
  {
    FindObjectOfType<GameSession>().IncreaseStatus("aerodynamics");
  }

  public void AeroLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseStatus("aerodynamics");
  }

  public void ChassisBtn()
  {
    FindObjectOfType<GameSession>().IncreaseStatus("chassi");
  }

  public void ChassisLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseStatus("chassi");
  }
}
