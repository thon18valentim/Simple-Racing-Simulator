using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calender : MonoBehaviour
{
  public GameObject info_australia;
  public GameObject info_bahrain;
  public GameObject info_brazil;
  public GameObject info_austria;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void ShowInfo(int id)
  {
    if(id == 1)
    {
      info_australia.SetActive(true);
      info_bahrain.SetActive(false);
      info_brazil.SetActive(false);
      info_austria.SetActive(false);
    }
    else if(id == 2)
    {
      info_australia.SetActive(false);
      info_bahrain.SetActive(true);
      info_brazil.SetActive(false);
      info_austria.SetActive(false);
    }
    else if (id == 3)
    {
      info_australia.SetActive(false);
      info_bahrain.SetActive(false);
      info_brazil.SetActive(true);
      info_austria.SetActive(false);
    }
    else if (id == 4)
    {
      info_australia.SetActive(false);
      info_bahrain.SetActive(false);
      info_brazil.SetActive(false);
      info_austria.SetActive(true);
    }
  }
}
