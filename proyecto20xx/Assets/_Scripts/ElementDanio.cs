using Unity.VisualScripting;
using UnityEngine;

public class ElementoDanio : MonoBehaviour
{
    
    public int Danio;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider collision)
    {


        if (collision.GetComponent<PersonajeScript>()!= null)  
            
            collision.GetComponent<PersonajeScript>().knock(transform.position.x < collision.transform.position.x); 
        if (collision.GetComponent<VidaJugador>()!= null) // Chequear VidaJugador
        {
            // Danio al personaje
            collision.GetComponent<VidaJugador>().ReciboDanio(Danio);
        }
    }
}
