using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
  public AudioSource back_music;
  public void LoadNextScene()
  {
    FindObjectOfType<SceneLoader>().LoadNextScene();
  }

  public void LoadScene(int i)
  {
    FindObjectOfType<SceneLoader>().LoadScene(i);
  }

  public void LoadPreviousScene()
  {
    FindObjectOfType<SceneLoader>().LoadPreviousScene();
  }

  public void PlayBackMusic()
  {
    back_music = GameObject.Find("Music Source").GetComponent<AudioSource>();
    back_music.Play();
  }
}
