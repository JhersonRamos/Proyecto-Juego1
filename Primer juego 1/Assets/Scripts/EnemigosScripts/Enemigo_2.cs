using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_2 : MonoBehaviour
{
    public GameObject Enemigo;
    public GameObject Player;
    public float Velocidad = 1f;
    public float dist;
    public float Detener =4f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        Enemigo.transform.position =
        Vector3.Lerp(Enemigo.transform.position, Player.transform.position, Velocidad * Time.deltaTime);
    }
}
