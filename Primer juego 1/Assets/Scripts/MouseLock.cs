using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
  public float MouseSensitivity = 100f;
  public Transform CuerpoDelJugador;
  float Rotacion = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        DMouse();
    }
void DMouse()
{
    float MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
    float MosueY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;
    Rotacion -= MosueY;
    Rotacion = Mathf.Clamp(Rotacion, -90f, 90f);
    transform.localRotation = Quaternion.Euler(Rotacion, 0f, 0f);
    CuerpoDelJugador.Rotate(Vector3.up * MouseX);
}   
}
