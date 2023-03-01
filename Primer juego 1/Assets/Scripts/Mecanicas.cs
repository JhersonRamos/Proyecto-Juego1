using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanicas : MonoBehaviour
{
    
    public Vector3 Direccion;
    public float Hp = 10;
    public float Velocidad = 5f;
    void Start()
    {
        Debug.Log("Tu vida es de " + Hp);
        Debug.Log("Tu velocidad es de " + Velocidad);
    }
    void Update()
    {
       
    }
    void VidaJugador()
    {
     Hp = Hp +1 * Time.deltaTime;
    }
    void DañoJugador()
    {
     Hp = Hp -1* Time.deltaTime;
      
    }
    void Movimiento(){ 

        transform.Translate(Direccion * Time.deltaTime);
    }
}

