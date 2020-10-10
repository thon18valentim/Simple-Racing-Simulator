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

  // Pilot 2 Texts
  public TextMeshProUGUI namePilot2;
  public TextMeshProUGUI countryPilot2;
  public TextMeshProUGUI agePilot2;
  public TextMeshProUGUI overPilot2;

  // Pilot 3 Texts
  public TextMeshProUGUI namePilot3;
  public TextMeshProUGUI countryPilot3;
  public TextMeshProUGUI agePilot3;
  public TextMeshProUGUI overPilot3;

  public GameObject arrow;

  private void Start()
  {
    // Getting the info from World.cs
    namePilot1.text = World.op_pilots[0].Name; 
    countryPilot1.text = World.op_pilots[0].Country;
    agePilot1.text = World.op_pilots[0].Age.ToString() + " Years";
    overPilot1.text = World.op_pilots[0].Over.ToString() + " Over";

    namePilot2.text = World.op_pilots[1].Name;
    countryPilot2.text = World.op_pilots[1].Country;
    agePilot2.text = World.op_pilots[1].Age.ToString() + " Years";
    overPilot2.text = World.op_pilots[1].Over.ToString() + " Over";

    namePilot3.text = World.op_pilots[2].Name;
    countryPilot3.text = World.op_pilots[2].Country;
    agePilot3.text = World.op_pilots[2].Age.ToString() + " Years";
    overPilot3.text = World.op_pilots[2].Over.ToString() + " Over";

    Debug.Log("Here");
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      arrow.transform.position = new Vector2(arrow.transform.position.x - 5f, 2f);
      CheckBoundaries();
    }

    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      arrow.transform.position = new Vector2(arrow.transform.position.x + 5f, 2f);
      CheckBoundaries();
    }
  }

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
