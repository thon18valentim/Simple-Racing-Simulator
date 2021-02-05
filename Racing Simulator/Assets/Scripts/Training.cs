using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using TMPro;

public class Training : MonoBehaviour
{
  int tPoints = 4;

  public TextMeshProUGUI tPoints_text;

  GameSession session;

    // Start is called before the first frame update
    void Start()
    {
      session = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
    tPoints_text.text = tPoints.ToString();
    }

  public void TrainingPilot()
  {
    tPoints = session.GetCurrentTrainePoints();

    if(tPoints >= 3)
    {
      World.teams[10].Pilot.Over += 1;
      World.teams[11].Pilot.Over += 1;
      World.teams[12].Pilot.Over += 1;
      tPoints -= 3;
    }
  }
}
