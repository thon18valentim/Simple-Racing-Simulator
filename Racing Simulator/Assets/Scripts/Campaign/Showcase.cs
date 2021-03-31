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
  public TextMeshProUGUI age1;
  public TextMeshProUGUI titles;
  public TextMeshProUGUI wins;
  public GameObject face1;
  public GameObject car1;

  public AudioSource btn_sound;

  private int select = 0;

  // Start is called before the first frame update
  void Start()
  {
    piloto1.text = World.pilots[0].Name;
    country1.text = World.pilots[0].Country;
    team1.text = World.teams[0].Name;
    over1.text = World.pilots[0].Over.ToString();
    age1.text = "Age " + World.pilots[0].Age.ToString();
    titles.text = "Titles " + World.pilots[0].Title.ToString();
    wins.text = "Wins " + World.pilots[0].Wins.ToString();
    face1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[0].PilotString);
    car1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + World.teams[0].CarString);
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
      age1.text = "Age " + World.pilots[opc].Age.ToString();
      titles.text = "Titles " + World.pilots[opc].Title.ToString();
      wins.text = "Wins " + World.pilots[opc].Wins.ToString();
      face1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[opc].PilotString);
      car1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + World.teams[opc].CarString);
    }
    else if(opc < 13)
    {
      piloto1.text = World.pilots[opc].Name;
      country1.text = World.pilots[opc].Country;
      team1.text = "Free Agent";
      over1.text = World.pilots[opc].Over.ToString();
      age1.text = "Age " + World.pilots[opc].Age.ToString();
      titles.text = "Titles " + World.pilots[opc].Title.ToString();
      wins.text = "Wins " + World.pilots[opc].Wins.ToString();
      face1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[opc].PilotString);
      car1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + FindObjectOfType<GameSession>().GetPlayerCar());
    }
    else
    {
      piloto1.text = World.pilots[opc].Name;
      country1.text = World.pilots[opc].Country;
      team1.text = World.teams[opc-3].Name;
      over1.text = World.pilots[opc].Over.ToString();
      age1.text = "Age " + World.pilots[opc].Age.ToString();
      titles.text = "Titles " + World.pilots[opc].Title.ToString();
      wins.text = "Wins " + World.pilots[opc].Wins.ToString();
      face1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pilots/" + World.pilots[opc].PilotString);
      car1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Cars/" + World.teams[opc-3].CarString);
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
