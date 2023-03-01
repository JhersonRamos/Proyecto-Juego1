using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float Damage = 1f;
    public float Speed = 1f;
    public Vector3 direction;
    

    void Update()
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}
