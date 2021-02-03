using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
  public AudioSource backMusic;

  public void Start()
  {
    
  }

  public void PauseMusic()
  {
    backMusic = GameObject.Find("Music Source").GetComponent<AudioSource>();
    backMusic.Pause();
  }
  public void PlayMusic()
  {
    backMusic = GameObject.Find("Music Source").GetComponent<AudioSource>();
    backMusic.Play();
  } 
}
