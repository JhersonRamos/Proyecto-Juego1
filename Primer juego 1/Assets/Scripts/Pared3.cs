using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared3 : MonoBehaviour
{
    public float rango = 10f;
    public float TiempoDeEspera = 2f;

    private Vector3 posOriginal;
    private Quaternion rotOrginal;

    void Start()
    {
        posOriginal = transform.position;
        rotOrginal = transform.rotation;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ParedDorada());
        }
        
    }

    IEnumerator ParedDorada()
    {
        yield return new WaitForSeconds(TiempoDeEspera);

        Vector3 nuevaPos = posOriginal + new Vector3(Random.Range(-rango, rango), 0, Random.Range(-rango, rango));
        Quaternion nuevaRot = Quaternion.Euler(0, Random.Range(0, 360), 0);

        transform.position = nuevaPos;
        transform.rotation = nuevaRot;
    }
}
