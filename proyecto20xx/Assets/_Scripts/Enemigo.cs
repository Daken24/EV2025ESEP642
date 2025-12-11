using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Transform direccion;
    bool Girando; //recorda que los bool por default son false
    public float velocidad;

    // ¿Queres hacer?
    // Hacer que el enemigo se mueva hacia adelante
    // si choca contra una pared
    // este va a girar en sentido contrario
    

    void Start()
    {
       
    }

    void Update()
    {
        Girar(Girando);
    }
    void Girar(bool Giratrue)
    {
        
    }
}
