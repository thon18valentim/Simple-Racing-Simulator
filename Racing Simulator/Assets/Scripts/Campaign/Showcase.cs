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
  public GameObject face1;

  public AudioSource btn_sound;

  private int select = 0;

  // Start is called before the first frame update
  void Start()
  {
    piloto1.text = World.pilots[0].Name;
    country1.text = World.pilots[0].Country;
    team1.text = World.teams[0].Name;
    over1.text = World.pilots[0].Over.ToString();
    face1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[0].PilotString);
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
        select = 22;
      }
      Selection(select);
    }
    else if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      btn_sound.Play();
      select++;
      if(select > 22)
      {
        select = 0;
      }
      Selection(select);
    }
  }

  public void Selection(int opc)
  {
    if(opc < 10)
    {
      piloto1.text = World.pilots[opc].Name;
      country1.text = World.pilots[opc].Country;
      team1.text = World.teams[opc].Name;
      over1.text = World.pilots[opc].Over.ToString();
      face1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[opc].PilotString);
    }
    else if(opc < 13)
    {
      piloto1.text = World.pilots[opc].Name;
      country1.text = World.pilots[opc].Country;
      team1.text = "Free Agent";
      over1.text = World.pilots[opc].Over.ToString();
      face1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[opc].PilotString);
    }
    else
    {
      piloto1.text = World.pilots[opc].Name;
      country1.text = World.pilots[opc].Country;
      team1.text = World.teams[opc-3].Name;
      over1.text = World.pilots[opc].Over.ToString();
      face1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[opc].PilotString);
    }
  }

  public void AdvanceItem()
  {
    btn_sound.Play();
    select++;
    if (select > 22)
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
      select = 22;
    }
    Selection(select);
  }

  public void LoadPreviousScene()
  {
    FindObjectOfType<SceneLoader>().LoadPreviousScene();
  }
}
