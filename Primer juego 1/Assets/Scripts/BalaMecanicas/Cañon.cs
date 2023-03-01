using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject Bala;
    public Transform posSpawn;
    public float Tiempo = 5f;
    public float TiempoOriginal = 5f;
    
  
    void Start()
    {
        
    
    }

    void Update()
    {
        Temporizador();
        

    }
    void Temporizador()
{
    Tiempo -= Time.deltaTime;
    if (Tiempo <= 0)
    {
        RestartTemp();
        Instantiate(Bala, posSpawn.position, transform.rotation);
       
    }
}
    void RestartTemp()
    {
    Tiempo = TiempoOriginal;
    }
    
}

