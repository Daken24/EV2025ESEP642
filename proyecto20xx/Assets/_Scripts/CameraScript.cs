using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
public class CameraScript : MonoBehaviour
{
    public Transform objetivo;
    public Camera cam;
    private Vector3 offset = new Vector3(0.0f, 1.5f, -8.0f);
    [Range(0.0f, 1.0f)] public float Smoothness = 0.5f;
    Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update(){
        //SmoothDamp = Gradualmente, cambia un vector hacia la direccion deseada a traves del tiempo calculado.
        transform.position= Vector3.SmoothDamp(transform.position,objetivo.position + offset,ref velocity, Smoothness);
        }
}
