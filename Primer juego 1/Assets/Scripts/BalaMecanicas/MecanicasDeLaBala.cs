using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicasDeLaBala : MonoBehaviour

{
    public float Destruir;

   
    void Start()
    {
        Destroy(gameObject,Destruir + 2);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    }
}
