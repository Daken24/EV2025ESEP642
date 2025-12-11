using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using System;
public class PersonajeScript : MonoBehaviour
{
    private CharacterController CC;
    //private Animator animador;
    public float VelocidadCaminar;
    public Vector3 VerticalMomentum;
    public Vector3 gravity;
    public Vector3 JumpForce;
    public Vector3 KnockbackIzquierda;
    public Vector3 KnockbackDerecha;
    public VidaJugador vidaJugador;
    private bool Ragdoll;
    public float Ragdolltimer;
    
    // Nota: En C#, el booleano por default es false no null....
    

    void Start()
    {
        CC = GetComponent<CharacterController>();
        vidaJugador= GetComponent<VidaJugador>();

        //  animador=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((CC.collisionFlags & CollisionFlags.Above) != 0)
        {
            //VerticalMomentum = Vector3.zero;
        }

        if (CC.isGrounded && Ragdoll==false)
        {
            VerticalMomentum = Vector3.zero;


        }
        VerticalMomentum += gravity * Time.deltaTime;

        if (CC.isGrounded)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //saltemos
                VerticalMomentum = JumpForce;
            }
        }
       
        
        Vector3 MovHorizontal= Vector3.zero;

        if (!Ragdoll) {
            MovHorizontal = transform.forward * Input.GetAxis("Horizontal") * VelocidadCaminar;
        }
        
            CC.Move((VerticalMomentum + MovHorizontal) * Time.deltaTime);
            // se multiplica dentro del Move
        
    }
    // Para determinar la direccion proviente del danio,
    // comparamos la ubicacion x del cubo con la ubicacion x del personaje
    public void knock(bool izq)
    {
        
        Ragdoll = true;
        Invoke("RagdollOff", Ragdolltimer);
        // Quiero que el personaje salga volando en direccion opuesta a quien lo choque
        if (izq)
        {
            //salis volando hacia la derecha
            VerticalMomentum = KnockbackDerecha;
        }
        else
        {
            VerticalMomentum = KnockbackIzquierda;
        }
    }
    void RagdollOff() { 
        Ragdoll= false;

    }
    // Una vez resuelto el tema de knockback, sigue: rotacion
    // El personaje tiene que rotar de acuerdo a la direccion Y, usa un rango de -90 a 90
    // 

}
