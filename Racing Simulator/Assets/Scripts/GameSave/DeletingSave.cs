using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DeletingSave : MonoBehaviour
{
  // Deleting an Old Save file and Creating a New Campaign
  public void OpenNewGame()
  {
    // Getting Game Data Path
    string filePath = Application.dataPath + "/gameSave.data";
    try
    {
      // Deleting Save Data File
      File.Delete(filePath);
      Debug.Log("Data Save Deleted");
    }
    catch
    {
      // Fail to Delete Game Data File
      Debug.Log("No Data Save Found");
    }
    
  }
}
