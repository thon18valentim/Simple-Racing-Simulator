using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
  public class Track
  {
    public string Nome { get; set; }
    public string Pais { get; set; }
    public int Voltas { get; set; }
    public int Aer_max { get; set; }
    public int Pow_max { get; set; }
    public int Dur_max { get; set; }
    public int Cha_max { get; set; }

    public Track(string name, string country, int laps, int aero_max, int power_max, int dura_max, int chas_max)
    {
      Nome = name;
      Pais = country;
      Voltas = laps;
      Aer_max = aero_max;
      Pow_max = power_max;
      Dur_max = dura_max;
      Cha_max = chas_max;
    }
  }

  public class Classificacao
  {
    public string Nome_piloto { get; set; }
    public Team Time { get; set; }

    public Classificacao(string nome, Team time)
    {
      Nome_piloto = nome;
      Time = time;
    }
  }
}
