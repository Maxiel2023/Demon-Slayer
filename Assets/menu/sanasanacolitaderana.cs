using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanasanacolitaderana : MonoBehaviour
{
    [SerializeField] private AudioClip recolectarSonido;

   private void OnCollisionEnter2D(Collision2D other)
   {


    if(other.gameObject.CompareTag("Jugador1"))
    {
        ControladorSonido.Instance.EjecutarSonido(recolectarSonido);
        other.gameObject.GetComponent<enemigo>().Curar(20);
        Destroy(gameObject);
      
    }

    if(other.gameObject.CompareTag("Jugador2"))
    {
        ControladorSonido.Instance.EjecutarSonido(recolectarSonido);
        other.gameObject.GetComponent<Enemy>().Curar(20);
        Destroy(gameObject);
        
    }
   }

}
