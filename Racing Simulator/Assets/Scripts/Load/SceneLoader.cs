using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public int scene;

  private void Awake()
  {
    SetUpSingleton();
  }

  // Keep only one Game Session
  private void SetUpSingleton()
  {
    int numberSceneLoaders = FindObjectsOfType<SceneLoader>().Length;
    if (numberSceneLoaders > 1)
    {
      Destroy(gameObject);
    }
    else
    {
      DontDestroyOnLoad(gameObject);
    }
  }


  public void LoadNextScene()
  {
    scene = SceneManager.GetActiveScene().buildIndex;

    int currentScene = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(currentScene + 1);
  }

  public void LoadScene(int i)
  {
    scene = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(i);
  }

  public void LoadPreviousScene()
  {
    SceneManager.LoadScene(scene);
  }
}
