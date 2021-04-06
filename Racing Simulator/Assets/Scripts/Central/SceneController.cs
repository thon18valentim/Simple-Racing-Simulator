using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
  // Setting Back Music
  public AudioSource back_music;

  // Loading Next Scene
  public void LoadNextScene()
  {
    FindObjectOfType<SceneLoader>().LoadNextScene();
  }

  // Load indicated Scene
  public void LoadScene(int i)
  {
    FindObjectOfType<SceneLoader>().LoadScene(i);
  }

  // Loading Previous Scene
  public void LoadPreviousScene()
  {
    FindObjectOfType<SceneLoader>().LoadPreviousScene();
  }

  // Playing Back Music
  public void PlayBackMusic()
  {
    back_music = GameObject.Find("Music Source").GetComponent<AudioSource>();
    back_music.Play();
  }
}
