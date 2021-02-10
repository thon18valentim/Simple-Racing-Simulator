using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Showcase : MonoBehaviour
{
  public TextMeshProUGUI piloto1;
  public TextMeshProUGUI country1;
  public TextMeshProUGUI team1;
  public TextMeshProUGUI over1;

  public AudioSource btn_sound;

  private int select = 0;

  // Start is called before the first frame update
  void Start()
  {
    piloto1.text = World.pilots[0].Name;
    country1.text = World.pilots[0].Country;
    team1.text = World.teams[0].Name;
    over1.text = World.pilots[0].Over.ToString();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      btn_sound.Play();
      select--;
      if(select < 0)
      {
        select = 9;
      }
      Selection(select);
    }
    else if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      btn_sound.Play();
      select++;
      if(select > 9)
      {
        select = 0;
      }
      Selection(select);
    }
  }

  public void Selection(int opc)
  {
    piloto1.text = World.pilots[opc].Name;
    country1.text = World.pilots[opc].Country;
    team1.text = World.teams[opc].Name;
    over1.text = World.pilots[opc].Over.ToString();
  }

  public void AdvanceItem()
  {
    btn_sound.Play();
    select++;
    if (select > 9)
    {
      select = 0;
    }
    Selection(select);
  }

  public void BackItem()
  {
    btn_sound.Play();
    select--;
    if (select < 0)
    {
      select = 9;
    }
    Selection(select);
  }

  public void LoadPreviousScene()
  {
    FindObjectOfType<SceneLoader>().LoadPreviousScene();
  }
}
