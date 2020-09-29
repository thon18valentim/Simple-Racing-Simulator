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

  private void Start()
  {
    // Getting the info from World.cs
    namePilot1.text = World.pilots[0].Name; 
    countryPilot1.text = World.pilots[0].Country;
    agePilot1.text = World.pilots[0].Age.ToString() + " Years";
  }
}
