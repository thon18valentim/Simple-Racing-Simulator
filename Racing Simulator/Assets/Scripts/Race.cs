using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : MonoBehaviour
{
  
  public class Corrida
  {
    /*Todos os carros começam com um tempo X até o final da corrida (como 60 minutos), e a cada volta
     * eles abaixam esse tempo. Logo, quem abaixar mais tempo por volta, realizará as ultrapassagens e
     * terá vantagem sobre os adversários.*/

    float tempo_de_pista = 60.0f; //Tempo até o final da corrida

    public float Get_Race_Time()
    {
      return tempo_de_pista;
    }
  }

  public void Ultrapassagem(float tempo1, float tempo2)
  {
    if(tempo2 < tempo1)
    {
      //O carro de trás realiza a ultrapassagem
    }
  }

  Car Teste; //Teste

  // Start is called before the first frame update
  void Start()
    {
    Teste = new Car(); //Teste...
    Teste.Set_Cars(2, 3, 4, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
