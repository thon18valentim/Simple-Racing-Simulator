using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class Race : MonoBehaviour
{

  //Gp Text
  public TextMeshProUGUI gp_name;
  public TextMeshProUGUI gp_country;

  //Pit markers
  public TextMeshProUGUI mark1;
  public TextMeshProUGUI mark2;

  //Lap Count
  int current_lap = 1;

  //Lap marker
  public TextMeshProUGUI mark_lap;

  // Integer for changing the pit lap
  int select1 = 10;
  int select2 = 30;

  public TextMeshProUGUI[] grid_corrida = new TextMeshProUGUI[10];
  public int[] grid_auxiliar = new int[10];
  public int[] aero_quali = new int[10];
  public int[] chassi_quali = new int[10];
  public int[] power_quali = new int[10];

  private void Start()
  {
    SetPit();
    mark_lap.text = "Laps: " + current_lap.ToString() + " / " + World.tracks[0].Laps;

    gp_name.text = World.tracks[0].Name;
    gp_country.text = World.tracks[0].Country;
   
    
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.A))
    {
      select1--;
      if(select1 < 1 || select1 >= select2)
      {
        select1 = World.tracks[0].Laps;
      }
      SetPit();
    }

    if (Input.GetKeyDown(KeyCode.S))
    {
      select2--;
      if(select2 <= select1)
      {
        select2 = World.tracks[0].Laps;
      }
      SetPit();
    }

    if (Input.GetKeyDown(KeyCode.D))
    {
      select1++;
      if (select1 > World.tracks[0].Laps || select1 >= select2)
      {
        select1 = 1;
      }
      SetPit();
    }

    if (Input.GetKeyDown(KeyCode.F))
    {
      select2++;
      if (select2 > World.tracks[0].Laps)
      {
        select2 = select1+1;
      }
      SetPit();
    }
  }

  public void SetPit()
  {
    mark1.text = select1.ToString();
    mark2.text = select2.ToString();
  }

  public void SetTyre(int i)
  {
    if(i == 1)
    {
      print("Soft Tyre had been chosen!");
    }
    else if(i == 2)
    {
      print("Medium Tyre had been chosen!");
    }
    else if(i == 3)
    {
      print("Hard Tyre had been chosen!");
    }
    else
    {
      print("ERROR! Tyre not found!");
    }
  }

  public void ArrowClicker(int i)
  {
    if(i == 1) //Seta D
    {
      select1++;
      if (select1 > World.tracks[0].Laps || select1 >= select2)
      {
        select1 = 1;
      }
      SetPit();
    }
    else if(i == 2) //Seta F
    {
      select2++;
      if (select2 > World.tracks[0].Laps)
      {
        select2 = select1 + 1;
      }
      SetPit();
    }
    else if(i == 3) //Seta A
    {
      select1--;
      if (select1 < 1 || select1 >= select2)
      {
        select1 = World.tracks[0].Laps;
      }
      SetPit();
    }
    else if(i == 4) //Seta S
    {
      select2--;
      if (select2 <= select1)
      {
        select2 = World.tracks[0].Laps;
      }
      SetPit();
    }
    else
    {
      Debug.Log("Arrow not found!");
    }
  }
  public static int NumberBetween(float minimumValue, float maximumValue)
  {
    int numero = (int)Random.Range(minimumValue, maximumValue);
    return numero;
  }

  public void Qualification()
  {
    int i;
    ResetQuali();

    aero_quali[0] = NumberBetween(World.teams[0].Car.Aerodynamics, World.tracks[0].Aerodynamics);
    aero_quali[1] = NumberBetween(World.teams[1].Car.Aerodynamics, World.tracks[1].Aerodynamics);
    aero_quali[2] = NumberBetween(World.teams[2].Car.Aerodynamics, World.tracks[2].Aerodynamics);
    aero_quali[3] = NumberBetween(World.teams[3].Car.Aerodynamics, World.tracks[3].Aerodynamics);
    aero_quali[4] = NumberBetween(World.teams[4].Car.Aerodynamics, World.tracks[4].Aerodynamics);
    aero_quali[5] = NumberBetween(World.teams[5].Car.Aerodynamics, World.tracks[5].Aerodynamics);
    aero_quali[6] = NumberBetween(World.teams[6].Car.Aerodynamics, World.tracks[6].Aerodynamics);
    aero_quali[7] = NumberBetween(World.teams[7].Car.Aerodynamics, World.tracks[7].Aerodynamics);
    aero_quali[8] = NumberBetween(World.teams[8].Car.Aerodynamics, World.tracks[8].Aerodynamics);
    aero_quali[9] = NumberBetween(World.teams[9].Car.Aerodynamics, World.tracks[9].Aerodynamics);

    chassi_quali[0] = NumberBetween(World.teams[0].Car.Chassis, World.tracks[0].Chassi);
    chassi_quali[1] = NumberBetween(World.teams[1].Car.Chassis, World.tracks[1].Chassi);
    chassi_quali[2] = NumberBetween(World.teams[2].Car.Chassis, World.tracks[2].Chassi);
    chassi_quali[3] = NumberBetween(World.teams[3].Car.Chassis, World.tracks[3].Chassi);
    chassi_quali[4] = NumberBetween(World.teams[4].Car.Chassis, World.tracks[4].Chassi);
    chassi_quali[5] = NumberBetween(World.teams[5].Car.Chassis, World.tracks[5].Chassi);
    chassi_quali[6] = NumberBetween(World.teams[6].Car.Chassis, World.tracks[6].Chassi);
    chassi_quali[7] = NumberBetween(World.teams[7].Car.Chassis, World.tracks[7].Chassi);
    chassi_quali[8] = NumberBetween(World.teams[8].Car.Chassis, World.tracks[8].Chassi);
    chassi_quali[9] = NumberBetween(World.teams[9].Car.Chassis, World.tracks[9].Chassi);

    power_quali[0] = NumberBetween(World.teams[0].Car.Power, World.tracks[0].Power);
    power_quali[1] = NumberBetween(World.teams[1].Car.Power, World.tracks[1].Power);
    power_quali[2] = NumberBetween(World.teams[2].Car.Power, World.tracks[2].Power);
    power_quali[3] = NumberBetween(World.teams[3].Car.Power, World.tracks[3].Power);
    power_quali[4] = NumberBetween(World.teams[4].Car.Power, World.tracks[4].Power);
    power_quali[5] = NumberBetween(World.teams[5].Car.Power, World.tracks[5].Power);
    power_quali[6] = NumberBetween(World.teams[6].Car.Power, World.tracks[6].Power);
    power_quali[7] = NumberBetween(World.teams[7].Car.Power, World.tracks[7].Power);
    power_quali[8] = NumberBetween(World.teams[8].Car.Power, World.tracks[8].Power);
    power_quali[9] = NumberBetween(World.teams[9].Car.Power, World.tracks[9].Power);

    for(i = 0; i < 10; i++)
    {
      World.teams[i].Car.Quali_power = aero_quali[i] + chassi_quali[i] + power_quali[i] + World.teams[i].Pilot.Over;
      /*if (World.teams[i].Name == "Silver Tech")
        World.teams[i].Car.Quali_power += 6;
      else if (World.teams[i].Name == "Blue Devils")
        World.teams[i].Car.Quali_power += 4;
      else if (World.teams[i].Name == "Team Italy")
        World.teams[i].Car.Quali_power += 2;
      else if (World.teams[i].Name == "Float Point Team")
        World.teams[i].Car.Quali_power += 3;
      else if (World.teams[i].Name == "Orange Team")
        World.teams[i].Car.Quali_power += 3;
      else if (World.teams[i].Name == "Yell Motors")
        World.teams[i].Car.Quali_power += 3;
      else if (World.teams[i].Name == "White Devils")
        World.teams[i].Car.Quali_power += 2;
      else if (World.teams[i].Name == "Juliet Motors")
        World.teams[i].Car.Quali_power += 1;
      else if (World.teams[i].Name == "American Mono")
        World.teams[i].Car.Quali_power += 1;
      else if (World.teams[i].Name == "Blue Sky Racing")
        World.teams[i].Car.Quali_power += 1;*/
    }

    grid_auxiliar[0] = World.teams[0].Car.Quali_power;
    grid_auxiliar[1] = World.teams[1].Car.Quali_power;
    grid_auxiliar[2] = World.teams[2].Car.Quali_power;
    grid_auxiliar[3] = World.teams[3].Car.Quali_power;
    grid_auxiliar[4] = World.teams[4].Car.Quali_power;
    grid_auxiliar[5] = World.teams[5].Car.Quali_power;
    grid_auxiliar[6] = World.teams[6].Car.Quali_power;
    grid_auxiliar[7] = World.teams[7].Car.Quali_power;
    grid_auxiliar[8] = World.teams[8].Car.Quali_power;
    grid_auxiliar[9] = World.teams[9].Car.Quali_power;

    //World.teams[0].Pilot.Name;

    int z = 0;
    i = 0;
    int auxiliar = 0;
    while(z < 100)
    {
      if (grid_auxiliar[i] < grid_auxiliar[i + 1])
        auxiliar = grid_auxiliar[i];
        grid_auxiliar[i] = grid_auxiliar[i + 1];
        grid_auxiliar[i + 1] = auxiliar;

      if (i == 9)
          i = 0;

      z += 1;
      i += 1;
    }
  }

  public void ResetQuali()
  {
    for (int i = 0; i < 10; i++)
    {
      World.teams[i].Car.Quali_power = 0;
    }
  }

  public void ResetTime()
  {
    for(int i=0; i < 10; i++)
    {
      World.teams[i].Car.Time = 0;
    }
  }
}
