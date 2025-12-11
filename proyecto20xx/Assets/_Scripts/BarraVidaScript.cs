using UnityEngine;
using UnityEngine.UI;
public class BarraVidaScript : MonoBehaviour
{
    
    public Image imgbarra;
    public Image segundabarra;
    public void VidaMaximaEstablecida(float vida)
    {
        imgbarra.fillAmount = vida;
        
    }
    public void SegundaVidaMaximaBarra(float segbarra) { 
        segundabarra.fillAmount= segbarra;
    }
}
// Implementar Hitbox/ Hurtbox
