using UnityEngine;

public class Raycast : MonoBehaviour
{
    
    // Recorda que transform.forward es un atajo de Vector3 ejemplo (0 de x, 0 de y , 1 de z)
    // En nuestro caso funcionamos en el eje XY, recorda cambiar a cambiar eje X o rotar el 
    void Update()
    {
        Ray ray = new Ray(transform.position,transform.forward);
        Debug.DrawRay(ray.origin,ray.direction *30f);
    }
}
