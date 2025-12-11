using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.Controls;

public class SegundaBarraVida : MonoBehaviour
{
    public VidaJugador Vjugador;
    public BarraVidaScript barraDos;
    public float hp;
    public float vidaactual;
    public float grado;
    public float valor;
    public float segundohp;
    void Start()
    {
        hp = Vjugador.maxVida;
        segundohp = Vjugador.maxVida;
        vidaactual = Vjugador.maxVida;
        //Debug.Log("Ahora seg es: " + segundohp + " Y vidaactual es: " + vidaactual);
        // Este debug me sirvio para saber si los valores eran asigados correctamente
        // PERO al usarlo tambien en el update implica un framedrop importante!!!  
    }

    void Update()
    {
        vidaactual = Vjugador.actualVida;
        
        // vidaactual depende del valor entero de la funcion VidaJugador 
        if (vidaactual >= segundohp)
        {
            segundohp = vidaactual;
        }
        if (vidaactual < segundohp)
        {
            // Debug.Log("Ahora seg es: " + segundohp + " Y vidaactual es: " + vidaactual);
            segundohp -= grado * Time.deltaTime;
            //segundohp = Mathf.Lerp(segundohp,vidaactual,-grado *Time.deltaTime); 
        }
        barraDos.SegundaVidaMaximaBarra(Mathf.Lerp(segundohp, vidaactual, -grado * Time.deltaTime) / hp);
    }


    // objetivo = Hacer una barra de vida que bajen de acuerdo al danio de manera gradual.NOTA= Ya se comunican las funciones entre si junto con las barras de vida 
    // siguiente paso = tomar los valores  

    // Matf.Clamp = Satura un valor entre dos valores float mínimo y máximo.
    // Mathf.Lerp = Linearly interpolates between a and b by t. retorna el promedio entre a y b.
}
