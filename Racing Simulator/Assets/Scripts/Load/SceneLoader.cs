using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public void LoadMainMenu()
  {
    int currentScene = SceneManager.GetActiveScene().buildIndex;

    SceneManager.LoadScene(0);
  }

  public void LoadPastScene(int i)
  {
    int currentScene = SceneManager.GetActiveScene().buildIndex;

    SceneManager.LoadScene(currentScene - i);
  }

  public void LoadScene(int i)
  {
    int currentScene = SceneManager.GetActiveScene().buildIndex;

    SceneManager.LoadScene(currentScene + i);
  }
}
