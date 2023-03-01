using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio : MonoBehaviour
{
    public GameObject Player;
    private Vector3 normalScale;
    private bool isSmall = false;

    void Start()
    {
        normalScale = Player.transform.localScale;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            if (!isSmall)
            {
                Player.transform.localScale *= 0.5f;
                isSmall = true;
            }
            else
            {
                Player.transform.localScale = normalScale;
                isSmall = false;
            }
        }
    }
}

