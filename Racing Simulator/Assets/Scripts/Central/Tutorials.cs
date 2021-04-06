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
  public bool isOpen1 = false;
  public bool isOpen2 = false;
  public bool isOpen3 = false;

  // Getting original positions
  public Vector2 oriPosition = new Vector2();
  public Vector2 oriArrowPosition = new Vector2();
  public Vector2 oriPosition2 = new Vector2();
  public Vector2 oriArrowPosition2 = new Vector2();
  public Vector2 oriPosition3 = new Vector2();
  public Vector2 oriArrowPosition3 = new Vector2();

  // Setting new Accordion Position
  public Vector2 newPosition = new Vector2();
  public Vector2 arrowPosition = new Vector2();

  // Start is called before the first frame update
  void Start()
    {

    // Initializing Original Positions
    oriPosition.x = accordion_one.transform.position.x;
    oriPosition.y = accordion_one.transform.position.y;
    oriArrowPosition.x = arrow_one.transform.position.x;
    oriArrowPosition.y = arrow_one.transform.position.y;

    oriPosition2.x = accordion_two.transform.position.x;
    oriPosition2.y = accordion_two.transform.position.y;
    oriArrowPosition2.x = arrow_two.transform.position.x;
    oriArrowPosition2.y = arrow_two.transform.position.y;

    oriPosition3.x = accordion_three.transform.position.x;
    oriPosition3.y = accordion_three.transform.position.y;
    oriArrowPosition3.x = arrow_three.transform.position.x;
    oriArrowPosition3.y = arrow_three.transform.position.y;

    // Initializing New Positions
    newPosition.x = 970f;
    newPosition.y = 1000f;
    arrowPosition.x = 390f;
    arrowPosition.y = 980f;
    }

  // Verifying if Accordion 1 is Open
  public bool VerifyAcco1()
  {
    return isOpen1;
  }
  // Verifying if Accordion 2 is Open
  public bool VerifyAcco2()
  {
    return isOpen2;
  }
  // Verifying if Accordion 3 is Open
  public bool VerifyAcco3()
  {
    return isOpen3;
  }

  // Updating vars for Open Accordion
  public void SetIsOpen(int i)
  {
    if (i == 1)
    {
      isOpen1 = true;
      isOpen2 = false;
      isOpen3 = false;
    }
    else if (i == 2)
    {
      isOpen1 = false;
      isOpen2 = true;
      isOpen3 = false;
    }
    else
    {
      isOpen1 = false;
      isOpen2 = false;
      isOpen3 = true;
    }
  }

  // Updating vars for Close Accordion
  public void SetNotOpen(int i)
  {
    if (i == 1)
    {
      isOpen1 = false;
    }
    else if (i == 2)
    {
      isOpen2 = false;
    }
    else
    {
      isOpen3 = false;
    }
  }

  // Opening Accordion
  public void OpenAccordion(int i)
  {
    if(i == 1)
    {
      // Opening Accordion 1
      if (!VerifyAcco1())
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
        SetIsOpen(1);
        
      }
      // Closing Accordion 1
      else
      {
        accordion_one.SetActive(true);
        accordion_two.SetActive(true);
        accordion_three.SetActive(true);
        cont_block.SetActive(false);
        cont_block2.SetActive(false);
        cont_block3.SetActive(false);
        scene_title.SetActive(true);

        // Moving Accordion
        accordion_one.transform.position = oriPosition;
        // Rotating Accordion
        arrow_one.transform.Rotate(0f, 0f, 90f);
        arrow_one.transform.position = oriArrowPosition;
        SetNotOpen(1);
        
      }
    }
    else if (i == 2)
    {
      // Opening Accordion 2
      if (!VerifyAcco2())
      {
        accordion_one.SetActive(false);
        accordion_two.SetActive(true);
        accordion_three.SetActive(false);
        cont_block.SetActive(false);
        cont_block2.SetActive(true);
        cont_block3.SetActive(false);
        scene_title.SetActive(false);

        // Moving Accordion
        accordion_two.transform.position = newPosition;
        // Rotating Accordion
        arrow_two.transform.Rotate(0f, 0f, -90f);
        arrow_two.transform.position = arrowPosition;
        SetIsOpen(2);
        
      }
      // Closing Accordion 2
      else
      {
        accordion_one.SetActive(true);
        accordion_two.SetActive(true);
        accordion_three.SetActive(true);
        cont_block.SetActive(false);
        cont_block2.SetActive(false);
        cont_block3.SetActive(false);
        scene_title.SetActive(true);

        // Moving Accordion
        accordion_two.transform.position = oriPosition2;
        // Rotating Accordion
        arrow_two.transform.Rotate(0f, 0f, 90f);
        arrow_two.transform.position = oriArrowPosition2;
        SetNotOpen(2);
        
      }
    }
    else
    {
      // Opening Accordion 3
      if (!VerifyAcco3())
      {
        accordion_one.SetActive(false);
        accordion_two.SetActive(false);
        accordion_three.SetActive(true);
        cont_block.SetActive(false);
        cont_block2.SetActive(false);
        cont_block3.SetActive(true);
        scene_title.SetActive(false);

        // Moving Accordion
        accordion_three.transform.position = newPosition;
        // Rotating Accordion
        arrow_three.transform.Rotate(0f, 0f, -90f);
        arrow_three.transform.position = arrowPosition;
        SetIsOpen(3);
        
      }
      // Closing Accordion 3
      else
      {
        accordion_one.SetActive(true);
        accordion_two.SetActive(true);
        accordion_three.SetActive(true);
        cont_block.SetActive(false);
        cont_block2.SetActive(false);
        cont_block3.SetActive(false);
        scene_title.SetActive(true);

        // Moving Accordion
        accordion_three.transform.position = oriPosition3;
        // Rotating Accordion
        arrow_three.transform.Rotate(0f, 0f, 90f);
        arrow_three.transform.position = oriArrowPosition3;
        SetNotOpen(3);
        
      }
    }
  }
}
