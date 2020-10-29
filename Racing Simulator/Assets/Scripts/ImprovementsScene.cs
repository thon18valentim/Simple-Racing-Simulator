using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    FindObjectOfType<GameSession>().IncreaseDurability();
  }

  public void duraLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseDurability();
  }

  public void powerLessBtn()
  {
    FindObjectOfType<GameSession>().DecreasePower();
  }

  public void powerBtn()
  {
    FindObjectOfType<GameSession>().IncreasePower();
  }

  public void aeroLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseAerodynamics();
  }

  public void aerodynamicsBtn()
  {
    FindObjectOfType<GameSession>().IncreaseAerodynamics();
  }

  public void chassisLessBtn()
  {
    FindObjectOfType<GameSession>().DecreaseChassis();
  }

  public void chassisBtn()
  {
    FindObjectOfType<GameSession>().IncreaseChassis();
  }
}
