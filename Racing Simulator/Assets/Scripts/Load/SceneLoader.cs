using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public void LoadMainMenu()
  {
    SceneManager.LoadScene(0);
  }

  public void LoadPastScene(int i)
  {
    int currentScene = SceneManager.GetActiveScene().buildIndex;

    SceneManager.LoadScene(currentScene - i);
  }

  public void LoadNextScene()
  {
    int currentScene = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(currentScene + 1);
  }

  public void LoadScene(int i)
  {
    SceneManager.LoadScene(i);
  }
}
