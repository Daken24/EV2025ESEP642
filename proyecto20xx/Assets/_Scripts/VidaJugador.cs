using Palmmedia.ReportGenerator.Core;
using System;
using System.Net;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    
    public int maxVida = 100;
    public int actualVida;
    public int expectedVida;
    public BarraVidaScript barraVida;
    public BarraVidaScript barrasegunda;
    public ElementoDanio daniador;
    void Start()
    {
        actualVida = maxVida;
        expectedVida = maxVida;
       
    }

    void Update()
    {
        
        if (expectedVida != actualVida) {
            
            expectedVida = actualVida;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ReciboDanio(20);

        }
        

    }

    public void ReciboDanio(int danio)
    {
        actualVida -= danio;
        if (actualVida < 0)
        {
            actualVida = 0;
            //aca ponemos la destruccion del personaje/gameobject
            
        }

    }
    // hacemos un void que destruya el personaje
    void PersonajeMuerte()
    {
        Destroy(GetComponent<GameObject>());
    }
}
