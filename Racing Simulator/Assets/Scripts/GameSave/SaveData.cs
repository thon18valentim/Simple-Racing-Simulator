using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Assets.Scripts;

public class SaveData : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void SavingGame()
  {
    Save();
    Debug.Log("Saving Game");
  }

  public void LoadingGame()
  {
    LoadSave();
    Debug.Log("Loading Game");
  }

  void Save()
  {
    BinaryFormatter bf = new BinaryFormatter();
    FileStream fs = File.Create(Application.persistentDataPath + "/gameSave.data");
    SaveClass s = new SaveClass();

    // Getting data
    s.currentGP = FindObjectOfType<GameSession>().GetCurrentTrack();
    s.week = FindObjectOfType<GameSession>().GetCurrentWeek();
    s.year = FindObjectOfType<GameSession>().GetYear();
    s.count_season = FindObjectOfType<GameSession>().GetTemporada();
    s.playerScore = FindObjectOfType<GameSession>().GetPlayerFinalScore();
    s.playerTeam = FindObjectOfType<GameSession>().GetPlayerTeam();
    s.playerPilot = FindObjectOfType<GameSession>().GetPlayerPilot();
    foreach(Pilot pilot in World.pilots)
    {
      s.pilots_data.Add(pilot);
    }
    foreach(Team team in World.teams)
    {
      s.teams_data.Add(team);
    }
    Debug.Log("Getting data");

    // Serializing
    bf.Serialize(fs, s);
    fs.Close();
    Debug.Log("Serializing data");
  }

  void LoadSave()
  {
    if (File.Exists(Application.persistentDataPath + "/gameSave.data"))
    {
      Debug.Log("Save File Found");
      BinaryFormatter bf = new BinaryFormatter();
      FileStream fs = File.Open(Application.persistentDataPath + "/gameSave.data",FileMode.Open);

      SaveClass s = (SaveClass)bf.Deserialize(fs);
      fs.Close();

      // Setting Saved Data
      FindObjectOfType<GameSession>().SetCurrentTrack(s.currentGP);
      FindObjectOfType<GameSession>().SetWeek(s.week);
      FindObjectOfType<GameSession>().SetYear(s.year);
      FindObjectOfType<GameSession>().SetTemporada(s.count_season);
      FindObjectOfType<GameSession>().SetPlayerScore(s.playerScore);
      FindObjectOfType<GameSession>().SetSavedPlayerPilot(s.playerPilot);
      FindObjectOfType<GameSession>().SetSavedPlayerTeam(s.playerTeam);
      int contador = 0;
      foreach(Pilot pilot in s.pilots_data)
      {
        World.pilots[contador] = pilot;
        contador++;
      }
      contador = 0;
      foreach(Team team in s.teams_data)
      {
        World.teams[contador] = team;
        contador++;
      }
      Debug.Log("Saved Data restored!");
    }
    else
    {
      Debug.Log("ERROR! Save File do not Found");
    }
  }
}

[Serializable]
class SaveClass
{
  // Campaign Localization
  public int currentGP;
  public int week;
  public int year;
  public int count_season;
  // Player Info
  public int playerScore;
  public Team playerTeam;
  public Pilot playerPilot;
  // World Info
  public List<Pilot> pilots_data = new List<Pilot>();
  public List<Team> teams_data = new List<Team>();
  //public List<Car> cars_data = new List<Car>();
}
