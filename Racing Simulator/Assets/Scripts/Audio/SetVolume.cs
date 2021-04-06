using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
  public AudioMixer mixer;

  // Setting Back Music Volume
  public void SetLevel(float sliderValue)
  {
    mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue)*20);
  }
}
