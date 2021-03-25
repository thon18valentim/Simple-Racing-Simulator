using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorials : MonoBehaviour
{
  // Defining Accordions
  public GameObject accordion_one;
  public GameObject accordion_two;
  public GameObject accordion_three;

  // Defining Accordion Arrows
  public GameObject arrow_one;
  public GameObject arrow_two;
  public GameObject arrow_three;

  // Defining Content Blocks
  public GameObject cont_block;
  public GameObject cont_block2;
  public GameObject cont_block3;

  // Scene title
  public GameObject scene_title;

  // Verfifying if accordion is open
  public int isOpen = 0;

  // Setting new Accordion Position
  public Vector2 newPosition = new Vector2();
  public Vector2 arrowPosition = new Vector2();

  // Start is called before the first frame update
  void Start()
    {
    newPosition.x = 970f;
    newPosition.y = 1000f;
    arrowPosition.x = 390f;
    arrowPosition.y = 980f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void OpenAccordion(int i)
  {
    if(i == 1)
    {
      accordion_one.SetActive(true);
      accordion_two.SetActive(false);
      accordion_three.SetActive(false);
      cont_block.SetActive(true);
      cont_block2.SetActive(false);
      cont_block3.SetActive(false);
      scene_title.SetActive(false);

      // Moving Accordion
      accordion_one.transform.position = newPosition;
      // Rotating Accordion
      arrow_one.transform.Rotate(0f, 0f, -90f);
      arrow_one.transform.position = arrowPosition;
    }
  }
}
