using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImprovementsScene : MonoBehaviour
{

  public TextMeshProUGUI points;

  // Update is called once per frame
  void Update()
  {
    points.text = "Points: " + FindObjectOfType<GameSession>().GetPoints().ToString();

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

  public void powerBtn()
  {
    FindObjectOfType<GameSession>().IncreasePower();
  }

  public void aerodynamicsBtn()
  {
    FindObjectOfType<GameSession>().IncreaseAerodynamics();
  }

  public void chassisBtn()
  {
    FindObjectOfType<GameSession>().IncreaseChassis();
  }
}
