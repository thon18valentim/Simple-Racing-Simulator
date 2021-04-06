using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
  public AudioSource backMusic;

  // Pausing Current Back Music
  public void PauseMusic()
  {
    backMusic = GameObject.Find("Music Source").GetComponent<AudioSource>();
    backMusic.Pause();
  }
  // Playing Back Music
  public void PlayMusic()
  {
    backMusic = GameObject.Find("Music Source").GetComponent<AudioSource>();
    backMusic.Play();
  } 
}
