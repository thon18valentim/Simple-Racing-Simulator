using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DeletingSave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void OpenNewGame()
  {
    string filePath = Application.dataPath + "/gameSave.data";
    try
    {
      File.Delete(filePath);
      Debug.Log("Data Save Deleted");
    }
    catch
    {
      Debug.Log("No Data Save Found");
    }
    
  }
}
