using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
  public static List<Pilot> pilots = new List<Pilot>();

  // Definig the variables with id for use later
  public const int PILOT_BOB_ID = 1;
  public const int PILOT_JOHN_ID = 2;
  public const int PILOT_JESUS_ID = 3;

  // Class constructor
  // It populates the list with the data needed
  static World()
  {
    PopulatePilots();
  }

  //Creating game objects and adding them to the list
  public static void PopulatePilots()
  {
    pilots.Add(new Pilot(PILOT_BOB_ID, "Maicon Smith", "Germany", 21, 67));
    pilots.Add(new Pilot(PILOT_JOHN_ID, "Carlos Lori", "England", 21, 65));
    pilots.Add(new Pilot(PILOT_JESUS_ID, "Roger Suzen", "Russia", 21, 64));
  }
}
