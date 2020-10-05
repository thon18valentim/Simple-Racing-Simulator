using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingArrow : MonoBehaviour
{
  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      transform.position = new Vector2(transform.position.x - 5f, 2f);
      CheckBoundaries();
    }

    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      transform.position = new Vector2(transform.position.x + 5f, 2f);
      CheckBoundaries();
    }


  }

  public void CheckBoundaries()
  {
    if (transform.position.x > 5f)
    {
      transform.position = new Vector2(5f, 2f);
    }
    if (transform.position.x < -5f)
    {
      transform.position = new Vector2(-5f, 2f);
    }
  }
}
