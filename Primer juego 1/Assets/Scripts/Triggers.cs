using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum Desafio1
{
    Comer,atacar
}
public class Triggers : MonoBehaviour
{
    bool TenerLlave = false;
    public GameObject PuertaAbierta;
    public GameObject Manzana;
    public Desafio1 Desafio12;
    void Start()
    {
        
    }

    
    void Update()
    {
       
    }
    
    private void OnTriggerEnter(Collider coli) 
    {
        if(coli.CompareTag("Llave"))
        {Destroy(GameObject.FindWithTag("Llave"),1f);
        TenerLlave = true;
        Debug.Log("Funciona La Llave");
        }

        if(coli.CompareTag("Puerta") && TenerLlave == true)
        {Debug.Log("Funciona La Puerta");
        Destroy(GameObject.FindObjectOfType<BoxCollider>(),1f);
        Destroy(GameObject.FindGameObjectWithTag("Puerta"),1f);
        PuertaAbierta.SetActive(true);
        }
        

        if(coli.CompareTag("Food"))
        {
        Instantiate(Manzana,transform.localPosition,transform.localRotation);
        Debug.Log("Funciona Food");
        }
    }
    void Desafio_1()
    {
        switch (Desafio12)
      {
        case Desafio1.atacar:
        Debug.Log("Estas Atacando");
        break;
        
        case Desafio1.Comer:
        Debug.Log("Estas Comiendo");
        break;
      }
    }
   
}
