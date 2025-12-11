using System;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class RotarModelo : MonoBehaviour
{

    public Transform orientation;
    public Quaternion rotacion;
    public float RotacionAdelante = 90f;
    public float AntiRotacion = -90f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            //mirar a la izquierda
            transform.rotation = Quaternion.Euler(0,AntiRotacion,0);
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, RotacionAdelante, 0);

        }
    }
    void CambioDireccion()
    {

    }
}
