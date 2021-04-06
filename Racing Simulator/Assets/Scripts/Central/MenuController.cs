using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
  public List<GameObject> buttons = new List<GameObject>(); // List of buttons in the scene
  public List<GameObject> stripes = new List<GameObject>(); // List of background stripes in the scene

  public TextMeshProUGUI subText; // Help Text

  int selection = 0; // Index to acces the lists

  public AudioSource backMusic;

  // Start is called before the first frame update
  void Start()
  {
    backMusic = GameObject.Find("Music Source").GetComponent<AudioSource>();
    if (!backMusic.isPlaying)
    {
      backMusic.Play();
    }

    SetOption(selection);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      selection++;
      if (selection > 3)
        selection = 0;
      SetOption(selection);
    }

    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      selection--;
      if (selection < 0)
        selection = 3;
      SetOption(selection);
    }

    if (Input.GetKeyDown(KeyCode.Return))
    {
      if (buttons[selection].name == "Campaign Button") // Changing the scene
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }

    // Setting Menu Options Sub
    if (selection == 0)
    {
      subText.text = "Start or Load your Pilot Journey";
    }
    else if (selection == 1)
    {
      subText.text = "Prove yourself among our challenges";
    }
    else if (selection == 2)
    {
      subText.text = "Our glorious team";
    }
    else
    {
      subText.text = "Exit Game";
    }
  }

  // Setting the according button options (i.e. colors, background...)
  public void SetOption(int x)
  {
    buttons[x].GetComponent<Button>().Select();
    foreach (var y in stripes)
      y.GetComponent<Image>().color = new Color(0, 0, 0);
    stripes[x].GetComponent<Image>().color = new Color(200, 200, 200);
  }

  // Set Quit Game func (Works only when playing .exe)
  public void QuitGame()
  {
    Application.Quit();
  }
}
