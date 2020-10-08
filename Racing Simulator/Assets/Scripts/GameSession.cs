using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  Team team;

  private void Awake()
  {
    int gameSessionCount = FindObjectsOfType<GameSession>().Length;// If game already have a status, i.e from level 1 - keep that
    if (gameSessionCount > 1)
    {
      Destroy(gameObject);
    }
    else
    {
      DontDestroyOnLoad(gameObject);
    }
  }
}
