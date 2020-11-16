using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class ImprovementsScene : MonoBehaviour
{
  public GameObject pilotFace;
  public GameObject carDisplay;

  public TextMeshProUGUI points;
  public TextMeshProUGUI power;
  public TextMeshProUGUI aero;
  public TextMeshProUGUI dura;
  public TextMeshProUGUI chassis;


  private void Start()
  {
    pilotFace.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + FindObjectOfType<GameSession>().GetPilotFaceString());
    carDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + FindObjectOfType<GameSession>().GetCarString());
  }

  // Update is called once per frame
  void Update()
  {
    points.text = "Points: " + FindObjectOfType<GameSession>().GetPoints().ToString();
    power.text = "> " + FindObjectOfType<GameSession>().GetPower().ToString();
    aero.text = "> " + FindObjectOfType<GameSession>().GetAero().ToString();
    dura.text = "> " + FindObjectOfType<GameSession>().GetDura().ToString();
    chassis.text = "> " + FindObjectOfType<GameSession>().GetChassis().ToString();

    if (Input.GetKeyDown(KeyCode.Return))
    {
      //Loading Next Scene on Return click
      FindObjectOfType<SceneLoader>().LoadNextScene();
    }
  }

  public void durabilityBtn()
  {
    FindObjectOfType<GameSession>().IncreaseStatus("durability");
  }

  public void duraLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseStatus("durability");
  }

  public void powerBtn()
  {
    FindObjectOfType<GameSession>().IncreaseStatus("power");
  }

  public void powerLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseStatus("power");
  }

  public void aerodynamicsBtn()
  {
    FindObjectOfType<GameSession>().IncreaseStatus("aerodynamics");
  }

  public void aeroLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseStatus("aerodynamics");
  }

  public void chassisBtn()
  {
    FindObjectOfType<GameSession>().IncreaseStatus("chassi");
  }

  public void chassisLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseStatus("chassi");
  }
}
