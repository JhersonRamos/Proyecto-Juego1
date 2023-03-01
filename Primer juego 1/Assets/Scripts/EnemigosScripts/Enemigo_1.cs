using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum Enemigo1
{
    Mirar,Seguir
}
public class Enemigo_1 : MonoBehaviour
{
public GameObject Enemigo;
public GameObject Player;
public float Velocidad = 1f;
public float dist;
public float Detener =1f;
public Enemigo1 EstadoDelEnemigo;

    void Start()
    {
        
    }


    void Update()
    {
        dist = Vector3.Distance(Player.transform.position, Enemigo.transform.position);
        if(dist <= Detener)
        {
          Velocidad = 0;
        }else
    {
        Velocidad = 1f;
    }
      switch (EstadoDelEnemigo)
      {
        case Enemigo1.Mirar:
        MirarAlPlayer();
        break;
        
        case Enemigo1.Seguir:
        MecanicasEnemigo();
        break;
      }
    }

void MecanicasEnemigo()
{
    
    Enemigo.transform.position =
    Vector3.Lerp(Enemigo.transform.position, Player.transform.position, Velocidad * Time.deltaTime);
}
void MirarAlPlayer()
{
      Quaternion rot = Quaternion.LookRotation(Player.transform.position - Enemigo.transform.position);
      Enemigo.transform.rotation = Quaternion.Slerp(Enemigo.transform.rotation, rot, Velocidad * Time.deltaTime);
}
}