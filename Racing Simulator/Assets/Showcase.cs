using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Showcase : MonoBehaviour
{
  public TextMeshProUGUI piloto1;

    // Start is called before the first frame update
    void Start()
    {
    piloto1.text = World.pilots[0].Name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
