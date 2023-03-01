using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject Bala;
    public int NumBalas = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Disparo(1);
        }
    }

    void Disparo(int cantidad)
    {
        

    for (int i = 0; i < cantidad; i++)
    {
        Vector3 pos = transform.position;
        Instantiate(Bala, pos, transform.rotation);
    }
    }
}