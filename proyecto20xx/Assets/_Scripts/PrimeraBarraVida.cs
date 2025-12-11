using UnityEngine;

public class PrimerBarraVida : MonoBehaviour
{
    public VidaJugador Jugador;
    public BarraVidaScript BarraVida;
    public float VidaactUno;
    public float VidaUno;
  
    void Start()
    {
      
            VidaUno = Jugador.maxVida;
        
    }

  
    void Update()
    {
        VidaactUno = Jugador.actualVida;
        // NOTA = El valor de Vidaactual aparece como 0 en el void start de esta funcion (ya que se activa en otra funcion en un void start)
        // pero el valor se mantiene actualizado al dejarlo en el update
       BarraVida.VidaMaximaEstablecida(VidaactUno / VidaUno);
    }
}