using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_3 : MonoBehaviour
{
    public GameObject Enemigo;
    public GameObject Player;
    public float Velocidad = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rot = Quaternion.LookRotation(Player.transform.position - Enemigo.transform.position);
        Enemigo.transform.rotation = Quaternion.Slerp(Enemigo.transform.rotation, rot, Velocidad * Time.deltaTime);
    }
}
